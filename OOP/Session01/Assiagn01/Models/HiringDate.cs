namespace Assiagn01.Models
{
    internal class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Day must be between 1 and 31");
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Year must be valid");
            }
        }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            //return $"{Day}/{Month}/{Year}";
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

    }
}
