namespace LearningScripts.Services
{
    public class MyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task method()
        {
            using (HttpClient httpClient = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://finnhub.io/api/v1/quote?symbol=AAPL&token=d3vcrvhr01qt2ctp6es0d3vcrvhr01qt2ctp6esg"),
                    Method = HttpMethod.Get,
                };

                HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                Stream stream = httpResponseMessage.Content.ReadAsStream();
                StreamReader streamReader = new StreamReader(stream);
                string response = streamReader.ReadToEnd();
            }
        }
    }
}
