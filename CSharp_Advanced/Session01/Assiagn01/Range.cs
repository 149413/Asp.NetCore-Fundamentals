namespace Assiagn01
{
    /*1.create a generic Range < T > class that represents a range of values from a
minimum value to a maximum value.The range should support basic
operations such as checking if a value is within the range and determining
the length of the range.
Requirements: 
1. Create a generic class named Range<T> where T represents the type of
values.

2. Implement a constructor that takes the minimum and maximum values
to define the range. 

3. Implement a method IsInRange(T value) that returns true if the given
value is within the range, otherwise false. 

4. Implement a method Length() that returns the length of the range (the
difference between the maximum and minimum values). 

5. Note: You can assume that the type T used in the Range<T> class
implements the IComparable<T> interface to allow for comparisons.*/


    internal class Range<T> : IComparable<Range<T>> where T : IComparable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }


        public Range(T min, T max)
        {
            Minimum = min;
            Maximum = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public int CompareTo(Range<T>? other)
        {
            if (other is null) return 1;

            if (Minimum.CompareTo(other.Minimum) < 0)
            {
                return -1;
            }
            return Maximum.CompareTo(other.Maximum);

        }

        public double Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return (double)(max - min);
        }

    }
}
