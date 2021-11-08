namespace Nuki
{
    public static class Authorization
    {
        private static string _apiToken;

        public static string ApiToken
        {
            get { return _apiToken; }
            set { _apiToken = value; }
        }
    }
}
