using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM STATEMENT NUMBER 2

            Console.WriteLine("----Employee Time Keeping System----");
            Console.WriteLine($"\nToday's Date:  {DateTime.Today.ToShortDateString()}");
            Console.WriteLine("\n\t*Please Type your name*\n\t*To log your Time-In*\n");
            Console.WriteLine("V--Employee Name--V");
                string employeeName = Console.ReadLine();
            Console.WriteLine($"\tGood Morning {employeeName}!");   
            Console.Write("\n\tPlease Enter your employee ID number\n\tTo log your Time-In\n");
            Console.WriteLine("V--ID Number--V ");
                string idnum = Console.ReadLine();
                string hidden = new string('*',idnum.Length);
            System.Console.WriteLine($"Your ID number is: {hidden}");
               
            TimeSpan timeIn = new TimeSpan(10,30,0);

            Console.WriteLine($"\nYour login time is recorded: {timeIn}");

            Console.WriteLine("\n*********************************");
            Console.Write("\nTo log your time-out enter your employee id:");
            idnum = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(17, 0, 0);
            Console.WriteLine($"\nYour logout time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;

            System.Console.WriteLine("\n*********************************");
            
            Console.WriteLine($"\nThe Employee total hours worked is: {totalHours}");

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0,0,0);
            TimeSpan earlyOut = new TimeSpan(0,0,0);
            

            if (timeIn > regularHoursStart) 
            {
                lateIn = timeIn - regularHoursStart;
            }

            if (timeOut < regularHoursEnd)
            {
                 earlyOut = timeOut - regularHoursEnd;
            }

            TimeSpan totalRegularHours = totalHours - (lateIn + earlyOut);

            TimeSpan lateTimein = new TimeSpan(0,0,0);
             TimeSpan timelate = new TimeSpan(8,30,0);
             TimeSpan gracePeriod = new TimeSpan(0,30,0);

                if(timeIn>=timelate)
                {
                    lateTimein = timeIn - timelate + gracePeriod;
                }

            Console.WriteLine($"\nThe Employee Total Late is: {lateTimein}");
            Console.WriteLine($"\nThe Employee total regular hours worked is: {totalRegularHours}");
            Console.ReadLine();
        }
    }
}
