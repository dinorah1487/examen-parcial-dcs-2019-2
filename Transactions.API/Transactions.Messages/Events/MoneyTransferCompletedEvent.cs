using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Messages.Events
{
    public class MoneyTransferCompletedEvent : IEvent
    {
        public string TransferId { get; protected set; }

        public MoneyTransferCompletedEvent(string transferId)
        {
            TransferId = transferId;
        }
    }
}
