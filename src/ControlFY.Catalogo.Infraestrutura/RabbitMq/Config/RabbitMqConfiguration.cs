﻿namespace ControlFY.Catalogo.Infraestrutura.RabbitMq.Config
{
    public class RabbitMqConfiguration
    {
        public string HostName { get; set; }
        public string VirtualHost { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
