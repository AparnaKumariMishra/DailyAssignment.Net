
    internal class UC5
    {
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int No_of_Working_Days = 2;
        static void Main(string[] args)
        {
            int empHrs = 0, empWages = 0, totalEmpWages = 0;
            for (int days = 0; days <= No_of_Working_Days; days++)
            {
                Random random = new Random();
            int empCheck = random.Next(0, 3);
                Console.WriteLine("Emp Wage : " + empWages);
                Console.WriteLine("Total Emp Wage:" + totalEmpWages);
            }
        }
    }

