using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Domain
{
    public enum TransferState
    {
        STARTED = 1,
        DEBITED = 2,
        COMPLETED = 3,
        REJECTED = 4,
    }
}
