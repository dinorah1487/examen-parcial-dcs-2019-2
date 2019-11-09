using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transactions.Application;
using Transactions.Application.Dtos;

namespace Transactions.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransfersController : ControllerBase
    {
        private readonly ITransactionApplicationService _transactionApplicationService;

        public TransfersController(ITransactionApplicationService transactionApplicationService)
        {
            _transactionApplicationService = transactionApplicationService;
        }

        // POST api/transfers
        [HttpPost]
        public async Task<IActionResult> PerformMoneyTransfer([FromBody] PerformMoneyTransferRequestDto dto)
        {
            PerformMoneyTransferResponseDto response = await _transactionApplicationService.PerformTransfer(dto);
            return Ok(response);
        }


        [HttpPost]
        
        //tambien agregar post para crear servicios
        // GET api/transfers
        [HttpGet]
        public IActionResult Home()
        {
            return Ok();
        }
    }
}
