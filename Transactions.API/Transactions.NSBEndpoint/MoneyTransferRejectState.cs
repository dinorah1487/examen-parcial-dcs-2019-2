using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transactions.Messages.Events;

namespace Transactions.NSBEndpoint
{
    public class MoneyTransferRejectState : IHandleMessages<MoneyTransferRejectState>
    {
        static readonly ILog log = LogManager.GetLogger<PerformMoneyTransferHandler>();

        public Task Handle(MoneyTransferRejectState message, IMessageHandlerContext context)
        {
            log.Info($"MoneyTransferRejectState*_*, EstadoId = {message.EstadoId}");
            return Task.CompletedTask;
        }
    }
}