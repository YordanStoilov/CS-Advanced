using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            Mail message = Inbox.FirstOrDefault(m => m.Sender == sender);
            
            return Inbox.Remove(message);
        }

        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;

            Archive.AddRange(Inbox);
            Inbox = new List<Mail>();

            return count;
        }

        public string GetLongestMessage()
        {
            Mail longestMail = Inbox.OrderByDescending(m => m.Body.Length).First();

            return longestMail.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new();

            sb.AppendLine("Inbox:");

            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
