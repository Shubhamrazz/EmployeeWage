using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpDailyWage_UC2
    {
        public static void FindJobPeriod()
        {
            //Variables
            int isPresent = 1;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            //Computation
            int empInput = random.Next(0, 2);//0 to 2 -->0,1
            if (isPresent == empInput)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("UC2_Daily Emp Wage : " + empWage);
        }
    }
}
