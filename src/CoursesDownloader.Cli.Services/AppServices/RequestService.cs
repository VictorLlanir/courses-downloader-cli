using CoursesDownloader.Cli.Core.Services;
using Newtonsoft.Json;

namespace CoursesDownloader.Cli.Services.AppServices
{
    public class RequestService : IRequestService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        public RequestService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
        }

        public async Task<T> MakeRequest<T>(HttpRequestMessage message) where T : class
        {
            var content = await _httpClient.SendAsync(message);
            var response = await content.Content.ReadAsStringAsync();

            if (content.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(response);
            }

            return default;
        }
    }
}
