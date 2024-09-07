namespace Section20.CleanCode.SOLID.D
{
    public class Notification
    {
        private readonly IEmailService _emailService;

        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Send(string message)
        {
            _emailService.SendEmail($"user@example.com", "Notification", message);
        }
    }
}
