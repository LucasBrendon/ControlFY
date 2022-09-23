using ControlFY.Catalogo.Infraestrutura.RabbitMq.Config;
using ControlFY.Catalogo.Infraestrutura.RabbitMq.Contratos;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace ControlFY.Catalogo.Infraestrutura.RabbitMq
{
    public abstract class SenderBase<T> : ISenderBase<T> where T : IRabbitMessage
    {
        private readonly ConnectionFactory _factory;
        private readonly RabbitMqConfiguration _config;
        protected abstract string Fila { get; }

        public SenderBase(IOptions<RabbitMqConfiguration> options)
        {
            _config = options.Value;

            _factory = new ConnectionFactory
            {
                HostName = _config.HostName,
                VirtualHost = _config.VirtualHost,
                Port = _config.Port,
                UserName = _config.UserName,
                Password = _config.Password
            };
        }

        public void PublicarNaFila(T message)
        {
            using (var connection = _factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(
                        queue:Fila,
                        durable:true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                        );

                    var messageSerialized = JsonConvert.SerializeObject(message);
                    var messageBytes = Encoding.UTF8.GetBytes(messageSerialized);

                    channel.BasicPublish(
                        exchange: "",
                        routingKey: Fila,
                        basicProperties: null,
                        body: messageBytes
                        );
                }
            }
        }
    }
}
