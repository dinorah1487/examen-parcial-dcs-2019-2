using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Messages.Commands
{
    public class RejectMoneyTransferCommand : ICommand
    {
        public string TransferId { get; private set; }

        public RejectMoneyTransferCommand(string transferId)
        {
            TransferId = transferId;
        }
    }
}
