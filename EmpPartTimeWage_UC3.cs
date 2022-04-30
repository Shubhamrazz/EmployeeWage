using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpPartTimeWage_UC3
    {
        public static void FindPartTime()
        {
            //Variables
            int fullTime = 1;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            int partTime = 2;
            Random random = new Random();
            //Computation
            int empInput = random.Next(0, 3);//0 to 2 -->0,1,2
            //Selection Statement
            if (fullTime == empInput)
            {
                Console.WriteLine("FullTime Employee is Present");
                empHrs = 8;
            }
            else if (partTime == empInput)
            {
                Console.WriteLine("PartTime Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("UC3_Daily Emp Wage : " + empWage);
        }
    }
}
