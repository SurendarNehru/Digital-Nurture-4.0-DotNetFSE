namespace CustomerCommLib
{
    public class CustomerComm
    {
        private readonly IMailSender Mailsender;

        public CustomerComm(IMailSender mailsender)
        {
            Mailsender = mailsender;
        }

        public bool SendMailToCustomer()
        {
            string email = "cust123@abc.com";
            string message = "Some Message";

            return Mailsender.SendMail(email, message);
        }
    }
}
