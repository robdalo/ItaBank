using ItaBank.Core.Services.Interfaces;
using ItaBank.Mapping;
using ItaBank.SDK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            var accountsMapped = AccountMapper.DomainToSDK(accounts);
            return accountsMapped;
        }
    }
}
