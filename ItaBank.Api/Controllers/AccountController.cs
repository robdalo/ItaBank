using ItaBank.Core.Mapping;
using ItaBank.Core.Services.Interfaces;
using ItaBank.SDK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ItaBank.Api.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<List<Account>> Get()
        {
            var accounts = _accountService.Get();
            var accountsMapped = accounts.Select(a => AccountMapper.Map(a)).ToList();
            return accountsMapped;
        }
    }
}
