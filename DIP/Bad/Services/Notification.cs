public class Notification
{
    private EmailSender _emailSender = new();

    public void Send(string message)
    {
        _emailSender.SendEmail(message);
    }
}
//Notification sınıfı doğrudan EmailSender sınıfına bağlı. Yarın SMS gönderme istersek, kodu değiştirmemiz gerekir.