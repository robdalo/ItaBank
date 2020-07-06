using System.Collections.Generic;
using ItaBank.SDK.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItaBank.ApiApp.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        [HttpGet]
        public ActionResult<List<Account>> Get()
        {
            var accountsMapped = new List<Account>()
            {
                new Account
                {
                    Id = 1,
                    Code = "AC0001",
                    Name = "Mr Rob Daley",
                    Address = "10 Downing Street, Westminster, London, EC1 1LV",
                    Balance = 25000
                }
            };

            return accountsMapped;
        }
    }
}
