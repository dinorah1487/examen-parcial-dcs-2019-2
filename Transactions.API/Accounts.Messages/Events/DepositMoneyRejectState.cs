using NServiceBus;

namespace Accounts.Messages.Events
{
    public class DepositMoneyRejectState : IEvent
    {
        public string TransactionId { get; protected set; }

        public DepositMoneyRejectState(string transactionId)
        {
            TransactionId = transactionId;
        }
    }
}