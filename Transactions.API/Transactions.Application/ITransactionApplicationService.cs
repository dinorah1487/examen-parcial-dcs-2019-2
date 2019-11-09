using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transactions.Application.Dtos;

namespace Transactions.Application
{
    public interface ITransactionApplicationService
    {
        Task<PerformMoneyTransferResponseDto> PerformTransfer(PerformMoneyTransferRequestDto dto);
    }
}
