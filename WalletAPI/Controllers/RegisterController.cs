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
    public class RegisterController : ControllerBase
    {
        private IUserService usrService;

        public RegisterController(IUserService userService, ILogger<RegisterController> logger)
        {
            usrService = userService;
        }

        [HttpGet]
        public async Task<Balance> GetUsersBalance(string guid)
        {
            return await usrService.GetBalanceByGuidAsync(guid);
        }

        [HttpPut]
        public async Task<bool> RegisterUser(User user)
        {
           return await usrService.CreateUser(user);
        }
    }
}
