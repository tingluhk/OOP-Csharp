namespace Console01.Mails
{
    public interface IMailable
    {
        void Send();
    }
    public class MailService : IMailable
    {
        public void Send(Mail mail){
            System.Console.WriteLine($"sending email...");
        }

        public void Send()
        {
            System.Console.WriteLine("sending email...");
        }
    }
}