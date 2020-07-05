using BobFit.Api.SDK.Models;
using ItaBank.Mapping;
using ItaBank.SDK.Consumers;
using ItaBank.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItaBank.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var config = new ApiConsumerConfig("https://localhost:5001/api");
            var apiConsumer = new ApiConsumer(config);

            var accounts = apiConsumer.GetAccounts();
            var viewModel = new AccountViewModel
            {
                Accounts = AccountMapper.SDKToDomain(accounts)
            };

            return View(viewModel);
        }
    }
}
