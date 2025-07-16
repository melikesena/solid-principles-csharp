public class GoodEmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email gönderildi: {message}");
    }
}
