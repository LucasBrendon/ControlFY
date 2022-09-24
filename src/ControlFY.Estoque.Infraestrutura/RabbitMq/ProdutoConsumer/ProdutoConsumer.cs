using ControlFY.Estoque.Infraestrutura.RabbitMq.Config;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System;
using ControlFY.Estoque.Infraestrutura.Servicos.Produtos;

namespace ControlFY.Estoque.Infraestrutura.RabbitMq.ProdutoConsumer
{
    public class ProdutoConsumer : BackgroundService
    {
        private readonly RabbitMqConfiguration _config;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly IServiceProvider _serviceProvider;

        public ProdutoConsumer(IOptions<RabbitMqConfiguration> options, IServiceProvider serviceProvider)
        {
            _config = options.Value;
            _serviceProvider = serviceProvider;

            var factory = new ConnectionFactory
            {
                HostName = _config.HostName,
                VirtualHost = _config.VirtualHost,
                Port = _config.Port,
                UserName = _config.UserName,
                Password = _config.Password
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(
                        queue: "Teste",
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);
        } 

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) =>
            {
                var contentArray = eventArgs.Body.ToArray();
                var contentString = Encoding.UTF8.GetString(contentArray);
                var message = JsonConvert.DeserializeObject<ProdutoReceiverViewModel>(contentString);

                await AdicionarEditarProduto(message);

                _channel.BasicAck(eventArgs.DeliveryTag, false);
            };

            _channel.BasicConsume("Teste", false, consumer);

            return Task.CompletedTask;
        }

        private async Task AdicionarEditarProduto(ProdutoReceiverViewModel receiver)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var produtoService = scope.ServiceProvider.GetRequiredService<IProdutoReceiverServico>();
                await produtoService.CriarProduto(receiver);
            }
        }
    }
}
