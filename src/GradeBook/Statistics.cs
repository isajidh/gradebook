namespace GradeBook.Statistics
{
    public class Statistics
    {
        public double Average { get { return Total / Count; } }
        public double Low;
        public double High;
        public double Total;
        public int Count;
        public char Letter
        {
            get
            {
                switch (Letter)
                {
                    case var d when d >= 90:
                        return 'A';

                    case var d when d >= 80:
                        return 'B';

                    case var d when d >= 70:
                        return 'C';

                    case var d when d >= 60:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }
        public void Add(double number)
        {
            Total += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }


        public Statistics()
        {
            High = double.MinValue;
            Low = double.MaxValue;
            Total = 0.0;
            Count = 0;
        }
    }
}