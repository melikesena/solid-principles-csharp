public class GoodNotification
{
    private readonly IMessageSender _messageSender;

    public GoodNotification(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Send(string message)
    {
        _messageSender.SendMessage(message);
    }
}
