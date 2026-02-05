using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class ClassPractice
    {
        public static void UnitTest()
        {
            CssGrades student1;
            student1 = new CssGrades();
            student1.name = "Josh";
            student1.magen371 = 82;
            student1.bagrut371 = 98;
            student1.magen271 = 87;
            student1.bagrut271 = 17;
            student1.proj = 100;

            int g = student1.Calc371();
            Console.WriteLine(g);
            Console.WriteLine(student1.Calc271());
            Console.WriteLine(student1.Calc3());
            Console.WriteLine(student1.Has5());
            Console.WriteLine(student1.Calc5());
            Console.WriteLine(student1.FinalString());
        }
    }
}
