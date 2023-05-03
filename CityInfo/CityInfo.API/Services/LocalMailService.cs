namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettngs:mailToAddress"];
            _mailFrom = configuration["mailSettngs:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            //demo way to mailoutput in console
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}," + $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
