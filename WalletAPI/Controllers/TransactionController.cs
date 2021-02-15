using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;
using WalletAPI.Core.Interfaces;

namespace WalletAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private ITransactionService transService;

        public TransactionController(ITransactionService service, ILogger<TransactionController> logger)
        {
            transService = service;
        }

        [HttpPut]
        public async Task<bool> ExecuteTransaction(string guid, Transaction transaction)
        {
            return await transService.CommitTransactionAsync(guid, transaction);
            
        }
    }
}
