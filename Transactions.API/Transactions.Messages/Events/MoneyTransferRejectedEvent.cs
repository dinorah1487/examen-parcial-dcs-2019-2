using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Messages.Events
{
    public class MoneyTransferRejectedEvent : IEvent
    {
        public string TransferId { get; protected set; }

        public MoneyTransferRejectedEvent(string transferId)
        {
            TransferId = transferId;
        }
    }
}
