using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            EmpPresent_Absent_UC1.FindEmpPresent_Absent();
            EmpDailyWage_UC2.FindJobPeriod();
            EmpPartTimeWage_UC3.FindPartTime();
            EmpWage_SwitchCase_UC4.SwitchCase();
            EmpWageForMonth_UC5.FindWageMonth();
            EmpWageTotalWorkingHrMonth_UC6.FindTotalWorkingHrMonth();
            RefactorWithClassMethod_UC7.RefactorTotalWorkingHrMonth();
            Console.ReadLine();
        }
    }
}
