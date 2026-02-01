namespace OnlineEdu.WebUI.Helpers
{
    public static class HttpClientInstance
    {
        public static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7138/api/");
            return client;
        }
    }
}
