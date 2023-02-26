namespace EmployeePayRoll
{
    internal class Program
    {
        static  int Main(string[] args)
        {
             int monthlyWage = EmployeePayRoll.MonthlyWageBasedOnCriteria();
           // int monthlyWage = EmployeePayRoll.EmployeeAttendanceCheck();

            return monthlyWage;

        }
    }
}