using System;

namespace MassTransit.ServiceBus
{
    public interface IEndpoint :
        IDisposable
    {
        string Address { get; }
    }
}