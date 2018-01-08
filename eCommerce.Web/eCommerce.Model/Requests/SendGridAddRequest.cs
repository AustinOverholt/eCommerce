namespace eCommerce.Model.Requests
{
    public class SendGridAddRequest
    {
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string Message { get; set; }
    }
}
