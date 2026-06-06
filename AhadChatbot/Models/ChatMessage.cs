namespace AhadChatbot.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string Sender { get; set; } // "User" or "Bot"
        public string Message { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
