using Day_05_Demo.Abstraction;
using Day_05_Demo.Partial;
using Day_05_Demo.Sealed;
using Day_05_Demo.Static;

namespace Day_05_Demo
{
    class Program
    {

        #region Draft
        // static void PrintShapeInfo(Shape shape)
        // {
        //     shape.CalcArea();
        // }

        /// static void Draw2D(IDraw2D shape)
        ///{
        ///    shape.Draw();
        ///} 
        #endregion

        static void CalcPayment(PaymentProcessor processor)
        {
            processor.ProcessPayment(100);
        }
        static void Main(string[] args)
        {

			#region Abstraction [Abstract Class, Abstract Method, Abstract Property]

			/// /// Shape shape = new Shape();
			/// /// shape.CalcArea();
			/// 
			/// Shape shape;
			/// 
			/// /*Rect rect*/
			/// shape = new Rect(10,20) /*{ Dim01 = 10, Dim02 = 20}* /;
			/// 
			/// decimal rectArea = shape.CalcArea();
			/// decimal rectPeri = shape.Perimeter;
			/// 
			/// Console.WriteLine($"Rect Peri = {rectPeri}");
			/// Console.WriteLine($"Rect Area = {rectArea}");
			/// 
			/// /*Square square*/
			/// shape = new Square(20);
			/// 
			/// decimal squarePeri = shape.Perimeter;
			/// decimal squareArea = shape.CalcArea();
			/// 
			/// Console.WriteLine($"Sequare Peri = {squarePeri}");
			/// Console.WriteLine($"Sequare Area = {squareArea}");
			/// 
			/// 
			/// /*Circle circle*/
			/// shape = new Circle(10);
			/// 
			/// decimal circlePeri = shape.Perimeter;
			/// decimal circleArea = shape.CalcArea();
			/// 
			/// Console.WriteLine($"Circle Peri = {circlePeri}");
			/// Console.WriteLine($"Circle Area = {circleArea}"); 

			#endregion

			#region Static [Static Class, Static Attribute, Static Property, Static Constructor, Static Method] and Const
			//Utility U01 = new Utility(1, 2);
			//Utility U02 = new Utility(5, 10);

			// The Result of Calling this Method will not be different By the Difference of the Object State[Data(X,Y)]
			///Console.WriteLine(Utility.CmToInch(254));
			///Console.WriteLine(Utility.CmToInch(254));

			//Console.WriteLine($"Circle Area = {Utility.CalcCircleArea(10)}");
			//Console.WriteLine($"Circle Area = {Utility.CalcCircleArea(10)}");

			//Math
			//Convert
			//Console

			//Console.WriteLine(Guid.NewGuid()); 
			#endregion

			#region Sealed [Class, Property, Method]
			//ImmutableString str = new ImmutableString("Ahmed");

			//string.value
			//str = new ImmutableString("Mohamed"); 
			#endregion

			#region Partial [Class, Struct, Interface, Method]
			//Employee employee = new Employee()
			//{
			//    Id = 12345,
			//    Name = "Doaa",
			//    Age = 24,
			//    Address = "New Cairo."
			//}; 
			#endregion

			#region Class Types Summary

			/// 1. Concrete Class
			/// 2. Static   Class
			/// 3. Abstract Class
			/// 4. Sealed   Class
			/// 5. Partial  Class 

			#endregion

		}
	}
}
