using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)
        {

        }
        public Date(Date other) : this(other.day, other.month, other.year)
        {
            this.day = other.day;
            this.month = other.month;
            this.year = other.year;
        }

        public int getDay() { return day; }

        public int getMonth() { return month; }

        public int getYear() { return year; }

        public void setDay(int day) { this.day = day; }

        public void setMonth(int month) { this.month = month; }

        public void setYear(int year) { this.year = year; }

        public int CompareTo(Date other)
        {
            if (this.year != other.year)
            {
                return this.year.CompareTo(other.year);
            }
                
            if (this.month != other.month)
            {
                return this.month.CompareTo(other.month);
            }
            
            return this.day.CompareTo(other.day);
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        public static void UnitTest()
        {
            Date d1 = new Date(10, 5, 2024);
            Date d2 = new Date(15, 5, 2024);
            Date d3 = new Date(10, 5, 2024);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.getDay());
            Console.WriteLine(d1.getMonth());
            Console.WriteLine(d1.getYear());

            Console.WriteLine(d1.CompareTo(d2));
            Console.WriteLine(d2.CompareTo(d1));
            Console.WriteLine(d1.CompareTo(d3));

            d1.setDay(20);
            d1.setMonth(6);
            d1.setYear(2025);

            Console.WriteLine(d1.ToString());
        }
    }
}
