namespace Assiagn03.Q_03
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"[Email] To: {recipient} | Message: {message}");
        }
    }
}
