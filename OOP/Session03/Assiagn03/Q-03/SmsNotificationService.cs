namespace Assiagn03.Q_03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"[Sms] To: {recipient} | Message: {message}");

        }
    }
}
