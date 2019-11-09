using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transactions.Messages.Commands
{
    public class CompleteMoneyTransferCommand : ICommand
    {
        public string TransferId { get; private set; }

        public CompleteMoneyTransferCommand(string transferId)
        {
            TransferId = transferId;
        }
    }
}
