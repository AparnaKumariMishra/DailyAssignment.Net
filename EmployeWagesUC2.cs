using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresent
{
    public class EmployeWagesUC2
    {
      public static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int EmpHRS = 0;
            int EmpWeg = 0;
            Random random = new Random();   
            int EmpCheck = random.Next(0,2);
            if (EmpCheck == IS_FULL_TIME)
            {
                EmpHRS = 8;
            }
            else
            {
                EmpHRS = 0;
            }
            EmpWeg = EmpHRS * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" +EmpWeg);
        }

    }
}
