namespace Demo_01
{
    internal class Program
    {
        //1. Class
        //2. Interfac
        //3. Struct
        //4. Enum


        static void Main(string[] args)
        {

            #region Struct

            // Struct: Value Type : Stack

            // Employee
            // Id , name , Salary


            // Point
            // Point P01;
            //Declare for Object From Type 'Point'

            // P01 : Object At the Stack

            // Allocate  UnInitializ 8 Bytes At STACK


            //Console.WriteLine(P01.X);
            // Console.WriteLine(P01.Y);

            //P01.X = 12;
            //P01.Y = 12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point();
            //P01 = new Point(1, 2);
            // New : Used For select/ Call The Constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new(2, 5);
            //P01.printPoint();
            // Must by Calling By Object As
            //its Non-Static methods

            //Before Override ToString() 
            // Console.WriteLine(P01);  // NameSpace: Demo_01.Point

            //After Override ToString() 
            //Console.WriteLine(P01); 
            #endregion

            #region OOP Overview
            // OOP: Object Orianted Programming
            // Programming Paradigm
            // OOP: The Best paradigm Used For Build Any Business.


            //Class : Blueprint(Model) Of The Object 
            //Object: Specific Instance From Class

            // Pillars
            // =================
            //1. Encapsolation  ==> Separeate Difination from Using 
            //2. Inheritance    ==> Inheritance Properties of Super Calss From Child Class
            // 3. Polymorphism  ==> Provide More than Shapes  
            // 4. Abstracttion  ==> Using Methods Without Knowing Impelementation. 
            #endregion

            #region Apply Encapsolation User Setter Getter Methods

            // Encapsolation :
            // Seprate Data Defination (Attributes) from Its Using
            // [Setter && Getter   -  Properties ]
            // Apply on Class or Struct

            // Without Encapsolation
            //1. End User Can Access by himSelf.
            //2. No Data Validation
            //3. No Read-Only Variable         

            // Apply Encssolation:
            //1. Make All Data (Attribute) Private.
            //2. Aceess Data Through:
            //2.1 Setter Getter Methods
            //2.2 Properties


            // Employee
            // Id , Name , salaray

            // Employee E; // Declare Object from Type 'Employee' at Stack

            //E.id = 1;
            //E.name = "Ahmed";
            //E.salary = -1200;

            //Console.WriteLine(E.id);
            //Console.WriteLine(E.name);
            //Console.WriteLine(E.salary);


            // 1.1 Apply Encapsolation Useing Setter Getter Methods
            // Employee E01 = new Employee();

            //E01.SetId(1);
            //E01.SetName("Ali");
            //E01.SetSalary(-1200);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            //Employee E02 = new Employee(1, "Mohamed", 5000);
            //Employee E03 = new Employee(-1, "Ali", -1200);

            //Console.WriteLine(E02);
            //Console.WriteLine(E03); 
            #endregion


            #region Apply Encapsolation User Proerties [Recommended]
            // Apply Encapsolation User Proerties [Recommended]
            //1. Properties Full Properties
            //2. Automitic Properties
            //3. Special Properties (Idexer))


            #region Full Property
            // Full Property--->If You Need Logic

            //Employee E01 = new Employee();

            //  E01.Id = 1;   //The Id read-only

            //E01.Name = "Mohamed";
            //E01.Salary = 1200;
            //E01.address = "Cairo";


            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.address);

            //Console.WriteLine(E01);  // Syntax suger to E01.ToString()
            //Console.WriteLine(E01.ToString());  
            #endregion

            #region Indexer
            // Indexer
            //PhoneBook phoneBook = new PhoneBook(4);

            //phoneBook.AddPerson("Ahmed", 111, 0);
            //phoneBook.AddPerson("Ali", 222, 1);
            //phoneBook.AddPerson("Omar", 333, 2);
            //phoneBook.AddPerson("Ahmed", 121, 3);


            //Console.WriteLine(phoneBook.GetName(222));
            //phoneBook.UpdateName(222, "Abdullah");
            //Console.WriteLine(phoneBook.GetName(222));

            //Console.WriteLine(phoneBook.GetNumber("Omar"));
            //phoneBook.UpdateNumber("Omar", 999);
            //Console.WriteLine(phoneBook.GetNumber("Omar"));

            // Indexer Buy Number
            //Console.WriteLine(phoneBook["Ahmed"]);
            //phoneBook["Ahmed"] = 777;
            //Console.WriteLine(phoneBook["Ahmed"]);

            // Indexer
            //Console.WriteLine(phoneBook[111]);

            //phoneBook[111] = "Hazem";
            //Console.WriteLine(phoneBook[111]); 
            #endregion


            #endregion

            #region Class
            //Class: Reference Type

            //Car : Id , Model , Speed

            //public int address { get; set; } // [prop + Table]

            //Car C01;
            // Declare for reference (pointer) from type 'Car'
            //C01: Can refer To Instance From Type 'Car' Or Any Any Instance Inherite from it.
            // C01: refer To Null

            //Console.WriteLine(C01);

            // 8 Bytes Will Be allocated at Stack For referance (C01)
            // 0 Bytes will be Allocated At The Heap

            // C01 = new Car();
            //new:
            //1. Allocate Requires Bytes For The Object At The Heap
            //2. Initialize The Bytes With Defualt Value
            //3. Call User-Defined Constuctor if Exists.
            //4. Assiagn Object/Instance To Referance (C01)

            //Console.WriteLine(C01.Id);    //Defualt: 0 
            //Console.WriteLine(C01.Model); //Defualt: "" 
            //Console.WriteLine(C01.Speed); //Defualt: 0 

            ////Console.WriteLine(C01); // Namespace: Demo_01.Car
            //// After overide ToString()
            //Console.WriteLine(C01);
            ////Console.WriteLine(C01.ToString());

            // Called by new:
            //C01 = new Car(1, "XYZ", 2200);
            //C01 = new Car(2, "ABC");
            //C01 = new Car(123);

            //Console.WriteLine(C01);

            // Constructor Chenning : internal Chennig
            //C01 = new Car(111, "XML", 5000);

            //Console.WriteLine(C01);

            #endregion

            #region Struct VS. Class
            // Struct Vs. Class

            //1. Value Type                                     |      Refereance Type
            //2. Create At Stack                                |      At Heap
            //3. Declare To Object                              |      Declare To Reference(Pointer)
            //4. Resposisible For initialize                    |      is new (in run Time)
            //  Attribute is Constractor (In Compile Time)      |   
            //5.Creating Constructor(Parameterize - Defualt)    |      Cancels The defult(Parameterless) Constructor
            // Not Cancels The defult(Parameterless) Constructor|
            //6. Not Support Ineritance                         |      Support Ineritance 

            #endregion


        }
    }
}
