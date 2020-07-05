namespace BobFit.Api.SDK.Models
{
    public class ApiConsumerConfig
    {
        public string BaseUrl;

        public ApiConsumerConfig()
        {
        }

        public ApiConsumerConfig(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
    }
}
