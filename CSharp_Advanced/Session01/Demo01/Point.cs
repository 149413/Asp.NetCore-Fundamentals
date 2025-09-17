namespace Demo01
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }


        #region is && as Casting Operator
        //public int CompareTo(object? obj)
        //{
        //    // 1. is Conditional Operator
        //    if (obj is not null)
        //    {
        //        if (obj is Point P)
        //        {
        //            //Point P = (Point)obj;
        //            if (X == P.X)
        //                return Y.CompareTo(P.Y);
        //            return X.CompareTo(P.X);

        //        }

        //    }
        //    return 1;
        //}

        //public int CompareTo(object? obj)
        //{
        //    // 2. as Conditional Operator
        //    Point P = obj as Point;
        //    if (P is not null)
        //    {
        //        if (X == P.X)
        //            return Y.CompareTo(P.Y);
        //        return X.CompareTo(P.X);
        //    }
        //    return 1;
        //} 
        #endregion


        #region Genaric Icomparable
        // Genaric Icomparable 
        public int CompareTo(Point? other)
        {
            if (other is null)
            {
                if (X == other.X)
                    return Y.CompareTo(other.Y);
                return X.CompareTo(other.X);
            }
            return 1;

        }
        #endregion


        public override string ToString()
        {
            return $"({X} , {Y})";
        }

    }
}
