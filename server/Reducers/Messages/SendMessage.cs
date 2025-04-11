
using SpacetimeDB;
public static partial class Module
{

    [Reducer]
    public static void SendMessage(ReducerContext ctx, string text)
    {
        text = ValidateMessage(text);
        Log.Info(text);
        ctx.Db.message.Insert(
            new Message
            {
                Sender = ctx.Sender,
                Text = text,
                Sent = ctx.Timestamp,
            }
        );
    }

    /// Takes a message's text and checks if it's acceptable to send.
    private static string ValidateMessage(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Messages must not be empty");
        }
        return text;
    }
}
