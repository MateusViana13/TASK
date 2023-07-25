namespace WEB_API_TESTE.Service
{
    public class ServiceTeste : IServiceTeste
    {
        public ServiceTeste() { }

        public async Task<int> GetCountAsync()
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(2000);
                count++;
            }

            return count;
        }

        public async Task<int> GetCountAsync_2()
        {
            int count = 0;

            for (int i = 0; i < 5;i++)
            {
                await Task.Delay(1000);
                count++;
            }

            return count;
        }
    }
}
