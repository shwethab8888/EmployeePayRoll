using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    public class EmployeePayRoll
    {
        public const int WAGEPERHR = 20;
        public const int FULLDAYHRS = 8;
        public const int PARTDAYHRS = 4;
        public const int WORKINGDAYSPERMONTH = 20;
        public const int MAXWORKINGHRSINMONTH = 100;
        public static int EmployeeAttendanceCheck()
        {
            Random random = new Random();
            int check = random.Next(0,3);
            //Console.WriteLine(check);
            return check;
        }
        public static int EmployeeDailyWage()
        {
            int check = EmployeeAttendanceCheck();
            int workingHrs = 0;
            switch (check)
            {
                case 0:
                    workingHrs = 0;
                    break;
                case 1:
                    workingHrs = 4;
                    break;
                case 2:
                    workingHrs = 8;
                    break;
                default:
                    workingHrs = 9;
                    break;
            }
            int dailyWage = workingHrs * WAGEPERHR;
            return dailyWage;

        }
        public static int MonthlyWage()
        {
            int totalEmpWage = 0;

            for (int i=1; i <= WORKINGDAYSPERMONTH; i++)
            {
                totalEmpWage += EmployeeDailyWage();
            }
            return totalEmpWage;
        }
        public static int MonthlyWageBasedOnCriteria()
        {
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalDays = 0;
            
            while (totalEmpHrs < MAXWORKINGHRSINMONTH && totalDays < WORKINGDAYSPERMONTH)
            {
                totalDays++;
                int dailyWage = EmployeeDailyWage();
                if (dailyWage == 160)
                    totalEmpHrs += 8;
                else if (dailyWage == 80)
                    totalEmpHrs += 4;

                totalEmpWage+= dailyWage;
                Console.WriteLine(totalEmpHrs + " " + totalEmpWage);
            }

            return totalEmpWage;
        }
    }
}
