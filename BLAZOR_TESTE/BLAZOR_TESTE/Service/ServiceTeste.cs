using System.Net;

namespace BLAZOR_TESTE.Service
{
    public class ServiceTeste : IServiceTeste
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<int> GetCount_1()
        {
            var httpRequest = new HttpRequestMessage(
                HttpMethod.Get,
                "https://localhost:7065/api/Teste/GetTeste01");

            var response = await _httpClient.SendAsync(httpRequest);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Não foi possivel realizar a requisição");

            int result = int.Parse(await response.Content.ReadAsStringAsync());

            return result;
        }

        public async Task<int> GetCount_2()
        {
            var httpRequest = new HttpRequestMessage(
                HttpMethod.Get,
                "https://localhost:7065/api/Teste/GetTeste02");

            var response = await _httpClient.SendAsync(httpRequest);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Não foi possivel realizar a requisição");

            int result = int.Parse(await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
