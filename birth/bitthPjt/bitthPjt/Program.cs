using System;

namespace bitthPjt
{
    class Program

    {

        static void Main(string[] args)

        {

            DateTime birthday = new DateTime(1995, 11, 08);

            int years = HowManyYearsOld(birthday);

            Console.WriteLine($"You are { years } years old.");

            int months = HowManyMonthsOld(birthday);

            Console.WriteLine($"You are { months } months old.");

            int days = HowManyDaysOld(birthday);

            Console.WriteLine($"You are { days } days old.");


            // 생일까지 남은 일수
            int daysUntilBirthday = DaysUntilNextBirthday(birthday);

            Console.WriteLine($"There are { daysUntilBirthday } days until your birthday.");



            int monthsUntilBirthday = MonthsUntilNextBirthday(birthday);

            Console.WriteLine($"There are { monthsUntilBirthday } months until your birthday.");



            Console.ReadLine();

        }



        private static int HowManyYearsOld(DateTime birthday)

        {

            int sbYears = DateTime.Now.Year - birthday.Year;
            return sbYears;

        }



        private static int HowManyMonthsOld(DateTime birthday)

        {
            DateTime nowtime;
            nowtime = DateTime.Now;
            TimeSpan timeDiff = nowtime - birthday;
            int monthDiff = timeDiff.Days/30;

            return monthDiff;

        }



        private static int HowManyDaysOld(DateTime birthday)
        {
            DateTime nowtime;
            nowtime = DateTime.Now;
            TimeSpan timeDiff = nowtime - birthday;
            int dayDiff = timeDiff.Days;

            return dayDiff;

        }



        private static int DaysUntilNextBirthday(DateTime birthday)

        {
            int sbYears = DateTime.Now.Year - birthday.Year;
            DateTime nowtime;
            nowtime = DateTime.Now;
            TimeSpan timeDiff = birthday.AddYears(sbYears+1)-nowtime;
            int dayDiff = timeDiff.Days;
            return dayDiff;

        }



        private static int MonthsUntilNextBirthday(DateTime birthday)

        {

            int sbYears = DateTime.Now.Year - birthday.Year;
            DateTime nowtime;
            nowtime = DateTime.Now;
            TimeSpan timeDiff = birthday.AddYears(sbYears + 1) - nowtime;
            int monthDiff = timeDiff.Days/30;
            return monthDiff;

        }



    }
}
