using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05_Demo.Abstraction
{
    /// Abstract Class
    /// is a Partial Implementation for Other Classes.
    /// is a Container for Common Code[Fully Implemented Members, Abstract Members] among many Classes
    /// U can't Create an Object From Abstract Class [it is not fully implemented]
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        protected Shape(decimal Dim01, decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }

        // Abstract Property = Virtual Property Without Implementation
        public abstract decimal Perimeter { get; }

        // Abstract Method = Virtual Method Without Implementation
        public abstract decimal CalcArea();
    }

    abstract class RectBase : Shape
    {
        protected RectBase(decimal Dim01, decimal Dim02): base(Dim01,Dim02)
        {
            
        }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Concrete Class
    class Rect : RectBase
    {
        public Rect(decimal Dim01, decimal Dim02): base(Dim01, Dim02) 
        {
            
        }
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

    }

    // Concrete Class
    class Square : RectBase
    {
        public Square(int Dim) : base(Dim, Dim)
        {
            //this.Dim01 = this.Dim02 = Dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

    }

    // Concrete Class
    class Circle : Shape/*, IDraw2D, IDraw3D*/
    {
        public Circle(decimal Radius) : base(Radius, Radius)
        {
            //this.Dim01 = this.Dim02 = Radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14M * this.Dim01; }
        }

        public override decimal CalcArea()
        {
            return 3.14M * this.Dim01 * this.Dim01;
        }

        #region Draft
        //void IDraw2D.Draw()
        //{
        //    throw new NotImplementedException();
        //}

        //void IDraw3D.Draw()
        //{
        //    throw new NotImplementedException();
        //} 
        #endregion
    }

    // Concrete Class
    class Triangle : Shape
    {
        public decimal Dim03 { get; set; }

        public Triangle(decimal Dim01, decimal Dim02, decimal Dim03) : base(Dim01, Dim02)
        {
            //this.Dim01 = Dim01;
            //this.Dim02 = Dim02;
            this.Dim03 = Dim03;
        }
        public override decimal Perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }

    #region Draft

    //interface IDraw2D
    //{
    //    void Draw();
    //}

    //interface IDraw3D
    //{
    //    void Draw();
    //}

    //class Parent
    //{
    //    private protected int salary;

    //    public virtual int Salary
    //    {
    //        get { return salary; }
    //        set { salary = value < 5000 ? 5000 : value; }
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("I am Parent");
    //    }
    //}

    //class Child : Parent
    //{
    //    public override int Salary
    //    {
    //        get { return base.Salary; }
    //        set { base.Salary = value + 2000; }
    //    }

    //    public override void Print()
    //    {
    //        Console.WriteLine("I am Child");
    //    }
    //} 
    #endregion
}
