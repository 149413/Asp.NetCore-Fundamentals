using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05_Demo.Sealed
{
    internal sealed class PaymentProcessor
    {
        public void ProcessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount: {Amount}");
        }
    }

    //internal class MyPaymentProcessor : PaymentProcessor
    //{
    //    public new void ProcessPayment(decimal Amount)
    //    {
    //        Console.WriteLine($"Amount: {Amount + 20}");
    //    }
    //}
}
