internal class UC4
{
    public const int Is_Part_time = 1;
    public const int Is_Full_time = 2;
    public const int Emp_Rate_Per_Hour = 20;
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empwags = 0;
        Random rand = new Random();
        int empcheck = rand.Next(0, 3);
        Console.WriteLine("emp wage= " + empwags);
    }
}
