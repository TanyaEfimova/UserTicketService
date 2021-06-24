namespace UserTicketService
{
    public class Notification
    {
        IMailSender mailSender;
        public Notification(IMailSender mailSender)
        {
            this.mailSender = mailSender;
        }

        public bool MakeNotification()
        {
            try
            {
                this.mailSender.Send();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
