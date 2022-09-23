namespace ControlFY.Catalogo.Infraestrutura.RabbitMq.Contratos
{
    public interface ISenderBase<T> where T : IRabbitMessage
    {
        void PublicarNaFila(T message);
    }
}
