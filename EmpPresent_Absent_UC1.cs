using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpPresent_Absent_UC1
    {
        public static void FindEmpPresent_Absent()
        {
            //UC1
            int isPresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);//0 to 2 -->0,1

            if (isPresent == empInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
