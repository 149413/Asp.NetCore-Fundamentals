namespace Assiagn03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mulitple Choice in PDf



            #region Part 02

            #region Q 01
            /* Question 01: 
                   Define an interface named IShape with a property Area and a method
                   DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from
                   IShape.Implement these interfaces in classes Circle and Rectangle. Test your
                   implementation by creating instances of both classes and displaying their shape
                   information.*/

            //IShape shape;
            //shape = new Circle(7);
            //shape.DisplayShapeInfo();

            //shape = new Rectangle(4, 8);
            //shape.DisplayShapeInfo();

            #endregion

            #region Q 02

            /*Question 02: 
            In this example, we start by defining the IAuthenticationService interface with
            two methods: AuthenticateUser and AuthorizeUser.
                  
            The BasicAuthenticationService class implements this interface and provides the
            specific implementation for these methods.

            In the BasicAuthenticationService class, the AuthenticateUser method compares
            the provided username and password with the stored credentials.
            
            It returns true if the user is authenticated and false otherwise.The AuthorizeUser method
            checks if the user with the given username has the specified role.It returns true if 
            the user is authorized and false otherwise.

            In the Main method, we create an instance of the BasicAuthenticationService
            class and assign it to the authService variable of type IAuthenticationService.We
            then call the AuthenticateUser and AuthorizeUser methods using this interface reference. */



            //while (true)
            //{
            //    // Look At The List Of Data Base Inside BasicAuthenticationService Class

            //    Console.Write("UserName: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Password: ");
            //    string pass = Console.ReadLine();

            //    IAuthenticationService authService;
            //    authService = new BasicAuthenticationService(name, pass);

            //    Console.WriteLine(authService.AuthenticateUser());
            //    Console.WriteLine(authService.AuthorizeUser());

            //}
            #endregion

            #region Q 03

            /*Question 03: 
             
            we define the INotificationService interface with a method SendNotification that
            takes a recipient and a message as parameters.

            We then create three classes: EmailNotificationService, SmsNotificationService, 
            and PushNotificationService, which implement the INotificationService interface. 

            In each implementation, we provide the logic to send notifications through the
            respective communication channel: 


            The EmailNotificationService class simulates sending an email by outputting a
            message to the console.

            The SmsNotificationService class simulates sending an SMS by outputting a
            message to the console.

            The PushNotificationService class simulates sending a push notification by
            outputting a message to the console.

            In the Main method, we create instances of each notification service class and call
            the SendNotification method with sample recipient and message values.*/


            //INotificationService email = new EmailNotificationService();
            //INotificationService sms = new SmsNotificationService();
            //INotificationService push = new PushNotificationService();

            //email.SendNotification("ali@gmail.com", "Welcome to our service!");
            //sms.SendNotification("+20123456789", "Your OTP is +20");
            //push.SendNotification("Ali's Device", "You have a new message!");




            #endregion

            #endregion



        }
    }
}
