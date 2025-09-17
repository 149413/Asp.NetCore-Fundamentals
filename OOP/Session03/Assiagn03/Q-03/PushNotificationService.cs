namespace Assiagn03.Q_03
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"[Push] To: {recipient} | Message: {message}");
        }
    }
}
