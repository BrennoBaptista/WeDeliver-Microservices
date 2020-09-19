using System;
using System.Threading.Tasks;

namespace WeDeliver.Common.Application.CQRS.Messaging
{
    public interface IMediatorHandler
    {
        Task<bool> EnqueueAsync<T>(T command, string queueName);
    }
}
