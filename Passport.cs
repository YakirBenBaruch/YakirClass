using System;

namespace Yakir
{
    public class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;

        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = new Date(expiryDate);
        }

        public Passport(Passport passport)
        {
            this.name = passport.name;
            this.number = passport.number;
            this.expiryDate = new Date(passport.expiryDate);
        }

        public override string ToString()
        {
            return "Name: " + name + "\nPass. num: " + number + "\nExp date: " + expiryDate;
        }

        public bool IsValid(Date dateChecked)
        {
            return expiryDate.CompareTo(dateChecked) >= 0;
        }

        public void SetExpiryDate(Date expiryDate)
        {
            this.expiryDate = new Date(expiryDate);
        }

        public static void UnitTest()
        {
            // 1) יצירה + ToString
            Passport p1 = new Passport("Yakir", 111111, new Date(1, 1, 2030));
            Console.WriteLine("---- Test 1: Create + ToString ----");
            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            // 2) IsValid - תאריך לפני התפוגה (צריך true)
            Date check1 = new Date(1, 1, 2025);
            Console.WriteLine("---- Test 2: IsValid (before expiry) ----");
            Console.WriteLine(p1.IsValid(check1)); // true
            Console.WriteLine();

            // 3) IsValid - אותו תאריך כמו תאריך תפוגה (צריך true לפי >= 0)
            Date check2 = new Date(1, 1, 2030);
            Console.WriteLine("---- Test 3: IsValid (same as expiry) ----");
            Console.WriteLine(p1.IsValid(check2)); // true
            Console.WriteLine();

            // 4) IsValid - תאריך אחרי התפוגה (צריך false)
            Date check3 = new Date(1, 1, 2035);
            Console.WriteLine("---- Test 4: IsValid (after expiry) ----");
            Console.WriteLine(p1.IsValid(check3)); // false
            Console.WriteLine();

            // 5) SetExpiryDate - אחרי הארכה צריך להיות תקף
            Console.WriteLine("---- Test 5: SetExpiryDate ----");
            p1.SetExpiryDate(new Date(1, 1, 2040));
            Console.WriteLine(p1.IsValid(check3)); // true (כי 2040 >= 2035)
            Console.WriteLine();

            // 6) Copy Constructor - בדיקה שהעתקה עובדת ושזו העתקה מלאה (Deep Copy)
            Console.WriteLine("---- Test 6: Copy Constructor ----");
            Passport p2 = new Passport(p1);

            // משנים ל-p1 את תאריך התפוגה, ואם זה Deep Copy אז p2 לא אמור להשתנות
            p1.SetExpiryDate(new Date(1, 1, 2026));

            Console.WriteLine("p1 valid in 2035? (צריך false)");
            Console.WriteLine(p1.IsValid(check3)); // false

            Console.WriteLine("p2 valid in 2035? (צריך true כי נשאר 2040)");
            Console.WriteLine(p2.IsValid(check3)); // true
        }
    }
}