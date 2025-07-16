public class SMSSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS gönderildi: {message}");
    }
}
// SMSSender sınıfı IMessageSender arayüzünü uyguluyor, böylece DIP prensibine uygun hale geliyor.