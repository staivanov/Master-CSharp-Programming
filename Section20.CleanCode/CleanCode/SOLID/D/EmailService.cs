namespace Section20.CleanCode.SOLID.D
{
    public class EmailService
    {

        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject {subject}.");
        }


    }
}
