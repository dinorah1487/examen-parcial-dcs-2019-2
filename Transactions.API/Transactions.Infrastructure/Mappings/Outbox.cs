﻿using NServiceBus.Outbox.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Infrastructure.Mappings
{
    public class Outbox : IOutboxRecord
    {
        public virtual long Id { get; set; }
        public virtual string MessageId { get; set; }
        public virtual bool Dispatched { get; set; }
        public virtual DateTime? DispatchedAt { get; set; }
        public virtual string TransportOperations { get; set; }
    }
}
