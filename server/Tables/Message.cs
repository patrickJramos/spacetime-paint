using SpacetimeDB;

public static partial class Module
{
    [Table(Name = "message", Public = true)]
    public partial class Message
    {
        public Identity Sender;
        public Timestamp Sent;
        public string Text = "";
    }
}
