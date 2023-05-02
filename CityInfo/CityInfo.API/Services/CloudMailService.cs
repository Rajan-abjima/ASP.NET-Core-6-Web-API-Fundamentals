namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettngs:mailToAddress"];
            _mailFrom = configuration["mailSettngs:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            //demo way to mailoutput in console
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}," + $"with {nameof(CloudMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
