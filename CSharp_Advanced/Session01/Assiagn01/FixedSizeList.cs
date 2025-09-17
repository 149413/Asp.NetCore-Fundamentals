namespace Assiagn01
{
    /* 4.implement a custom list called FixedSizeList<T> with a predetermined
    capacity.This list should not allow more elements than its capacity and
    should provide clear messages if one tries to exceed it or access invalid indices.
    Requirements:

    1.Create a generic class named FixedSizeList<T>.

    2. Implement a constructor that takes the fixed capacity of the list as aparameter.

    3.Implement an Add method that adds an element to the list, but throws
    an exception if the list is already full. 

    4.Implement a Get method that retrieves an element at a specific index in 
    the list but throws an exception for invalid indices.*/


    internal class FixedSizeList<T>
    {
        public int Capacity { get; set; }
        public T[] list { get; set; }
        private int len { get; set; }


        public FixedSizeList(int capacity)
        {
            if (capacity > 0)
            {
                Capacity = capacity;
            }
            else
            {
                Capacity = 4;
            }

            list = new T[Capacity];
            len = 0;
        }

        public void Add(T item)
        {
            if (len < Capacity)
            {
                list[len++] = item;
            }
            else
            {
                Console.WriteLine("The List is already Full.");
            }
        }
        public T Get(int idx)
        {
            if (idx > 0 && idx < len)
            {
                return list[idx];
            }
            else
            {
                Console.WriteLine("The Index is Out Of Range");
                return default(T);
            }

        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
