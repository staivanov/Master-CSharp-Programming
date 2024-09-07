namespace Section20.CleanCode.SOLID.D
{
    public interface IEmailService
    {
        public void SendEmail(string to, string subject, string body);
    }
}
