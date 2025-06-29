namespace CustomerCommLib
{
    public interface IMailSender
    {
        bool SendMail(string toaddress, string message);
    }
}
