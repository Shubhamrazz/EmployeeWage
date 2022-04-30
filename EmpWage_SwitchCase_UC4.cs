using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpWage_SwitchCase_UC4
    {
        public static void SwitchCase()
        {
            //CONSTANT
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //Variable
            int empRatePerHr = 20, empHrs = 0, empWage = 0;
            Random random = new Random();
            //Computation
            int empInput = random.Next(0, 3);//0,1,2

            //Implimentation Of Switch Case
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
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("UC4_Daily Employee Wage by implimentation of switch: " + empWage);
            Console.ReadLine();
        }
    }
}
