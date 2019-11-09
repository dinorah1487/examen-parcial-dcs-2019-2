using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transactions.Messages.Events;

namespace Transactions.NSBEndpoint
{
    public class MoneyTransferRejectedHandler : IHandleMessages<MoneyTransferRejectedEvent>
    {
        static readonly ILog log = LogManager.GetLogger<PerformMoneyTransferHandler>();

        public Task Handle(MoneyTransferRejectedEvent message, IMessageHandlerContext context)
        {
            log.Info($"MoneyTransferRejectedEvent*_*, TransferId = {message.TransferId}");
            return Task.CompletedTask;
        }
    }
}
