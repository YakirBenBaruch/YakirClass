using System;

namespace Yakir
{
    public class Traveler
    {
        private Passport passport;
        private bool hasPaid;

        public Traveler(Passport passport, bool hasPaid)
        {
            this.passport = new Passport(passport);
            this.hasPaid = hasPaid;
        }

        public void Pay()
        {
            hasPaid = true;
        }

        public bool HasPaid()
        {
            return hasPaid;
        }

        public bool CheckTravel(Date travelDate)
        {
            return hasPaid && passport.IsValid(travelDate);
        }

        public static int TravelersAllowedToTravel(Traveler[] travelers, Date travelDate)
        {
            int count = 0;
            for (int i = 0; i < travelers.Length; i++)
            {
                if (travelers[i].CheckTravel(travelDate))
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            return passport.ToString() + "\nHas paid: " + hasPaid;
        }
        public static void UnitTest()
        {
            Console.WriteLine("========== Traveler UnitTest ==========");

            // תאריכים לבדיקה
            Date travelOk = new Date(1, 1, 2025);
            Date travelAfterExpiry = new Date(1, 1, 2035);

            // דרכון: תוקף עד 2030
            Passport p = new Passport("Yakir", 123456, new Date(1, 1, 2030));

            // 1) נוסע שלא שילם
            Traveler t1 = new Traveler(p, false);

            Console.WriteLine("---- Test 1: HasPaid initial ----");
            Console.WriteLine(t1.HasPaid()); // false
            Console.WriteLine();

            Console.WriteLine("---- Test 2: CheckTravel without payment (valid passport) ----");
            Console.WriteLine(t1.CheckTravel(travelOk)); // false (לא שילם)
            Console.WriteLine();

            // 2) תשלום ואז בדיקה שוב
            Console.WriteLine("---- Test 3: Pay + HasPaid ----");
            t1.Pay();
            Console.WriteLine(t1.HasPaid()); // true
            Console.WriteLine();

            Console.WriteLine("---- Test 4: CheckTravel after payment (valid passport) ----");
            Console.WriteLine(t1.CheckTravel(travelOk)); // true
            Console.WriteLine();

            // 3) שילם אבל הדרכון לא בתוקף בתאריך הטיסה
            Console.WriteLine("---- Test 5: CheckTravel after payment (expired passport) ----");
            Console.WriteLine(t1.CheckTravel(travelAfterExpiry)); // false
            Console.WriteLine();

            // 4) ToString בדיקה
            Console.WriteLine("---- Test 6: ToString ----");
            Console.WriteLine(t1.ToString());
            Console.WriteLine();

            // 5) בדיקת copy behavior (Traveler עושה new Passport(passport))
            Console.WriteLine("---- Test 7: Traveler keeps its own passport copy ----");
            Traveler t2 = new Traveler(p, true);

            // משנים את הדרכון המקורי p לתפוגה מוקדמת
            p.SetExpiryDate(new Date(1, 1, 2020));

            // אם Traveler שמר עותק (כמו בקוד שלנו) אז t2 אמור עדיין להיות תקף ב-2025
            Console.WriteLine("Original passport valid in 2025? (צריך false)");
            Console.WriteLine(p.IsValid(travelOk)); // false

            Console.WriteLine("Traveler t2 CheckTravel in 2025? (צריך true אם נשמר עותק)");
            Console.WriteLine(t2.CheckTravel(travelOk)); // true
        }

    }
}