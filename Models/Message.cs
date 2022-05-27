namespace DatingApp.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public User Sender { get; set; }

        public int RecipientId { get; set; }
        public string RecipientUsername { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime? MessageSent { get; set; } = DateTime.UtcNow;
        public bool SenderDeleted { get; set; } // The sender deleted the message
        public bool RecipientDeleted { get; set; } // The recipient deleted the message
    }
}

// We will delete a message from the server only if both the sender and the recipient deleted it.