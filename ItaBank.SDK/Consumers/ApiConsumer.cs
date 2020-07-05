using BobFit.Api.SDK.Models;
using ItaBank.SDK.Models;
using System.Collections.Generic;

namespace ItaBank.SDK.Consumers
{
    public class ApiConsumer
    {
        private ApiConsumerConfig _config;

        private RestConsumer _restConsumer;
        
        private const string GetAccountsEndpoint = "account";

        public ApiConsumer(ApiConsumerConfig config)
        {
            _config = config;

            _restConsumer = new RestConsumer(_config.BaseUrl);
        }

        public List<Account> GetAccounts()
        {
            var authToken = GetToken();

            var accounts = _restConsumer.Get<List<Account>>(GetAccountsEndpoint, authToken);

            return accounts;
        }

        public string GetToken()
        {
            return "";
        }
    }
}
