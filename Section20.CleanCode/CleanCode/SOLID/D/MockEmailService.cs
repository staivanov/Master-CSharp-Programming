namespace Section20.CleanCode.SOLID.D
{
    public class MockEmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
