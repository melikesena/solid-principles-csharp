partial class Program
{
    static void Main()
    {
        IMessageSender sender = new GoodEmailSender(); // ya da new SMSSender();
        GoodNotification notification = new GoodNotification(sender);

        notification.Send("Merhaba Dependency Inversion!");
    }
}
