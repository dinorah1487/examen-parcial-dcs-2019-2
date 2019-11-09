using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transactions.Messages.Events;

namespace Transactions.NSBEndpoint
{
    public class MoneyTransferCompletedHandler : IHandleMessages<MoneyTransferCompletedEvent>
    {
        static readonly ILog log = LogManager.GetLogger<PerformMoneyTransferHandler>();

        public Task Handle(MoneyTransferCompletedEvent message, IMessageHandlerContext context)
        {
            log.Info($"MoneyTransferCompletedEvent!!!, TransferId = {message.TransferId}");
            return Task.CompletedTask;
        }
    }
}
