using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpWageTotalWorkingHrMonth_UC6
    {
        public static void FindTotalWorkingHrMonth()
        {
            //Variables
            int empWage = 0, empHrs = 0, totalEmpWage = 0;
            //CONSTANT
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_HR = 80;

            int workingHrs = 0;
            int day = 1;
            Random random = new Random();

            while (day <= NUM_OF_WORKING_DAYS && workingHrs <= MAX_WORKING_HR)//78
            {
                int empInput = random.Next(0, 3);//0 TO 3(0,1,2)

                switch (empInput)
                {
                    case FULL_TIME:
                        Console.WriteLine("FullTime Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("PartTime Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Daily Wage for day{0} is:{1}", day, +empWage);
                //totalEmpwage=totalEmpwage+empwage;
                totalEmpWage += empWage;
                workingHrs += empWage;
                day++;
            }
            Console.WriteLine("UC6_TotalWage for {0} days and working hrs:{1} and wage is:{2}", day - 1, workingHrs, totalEmpWage);
            Console.ReadLine();
        }
    }
}
