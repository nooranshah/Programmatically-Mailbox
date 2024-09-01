using API.Enum;

namespace API.Models
{
    public class MailBoxModel
    {
        public string Id { get; set; }
        public string[] Ids { get; set; }
        public string MailAddress { get; set; }
        public string Name { get; set; }
        public DateTime SentDateTime { get; set; }
        public string Sender { get; set; }
        public bool HasAttachments { get; set; }
        public string Note { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public int Amount { get; set; }
        public bool Approval { get; set; }
        public string PDFUrl { get; set; }
        public bool IsSelected { get; set; }
        public string File { get; set; }
        public MailBoxType MailboxType { get; set; }
    }
}
