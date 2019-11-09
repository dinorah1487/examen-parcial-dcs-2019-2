using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.NSBEndpoint
{
    public class MoneyTransferSagaData : ContainSagaData
    {
        public virtual string TransferId { get; set; }
        public virtual string SourceAccountId { get; set; }
        public virtual string DestinationAccountId { get; set; }
        public virtual decimal Amount { get; set; }

        public virtual string EstadoId { get; set; }

    }
}
