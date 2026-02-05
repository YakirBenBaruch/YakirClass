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
            student1 = new CssGrades("Josh", 82, 98, 87, 17, 100);
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
