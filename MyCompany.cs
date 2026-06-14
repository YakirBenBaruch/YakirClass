using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class MyCompany
    {
        private string CompanyName;
        private Employee[] Employees;

        public MyCompany(string companyName, Employee[] employees, Manager[] managers)
        {
            this.CompanyName = companyName;
            this.Employees = employees;
        }

        public MyCompany()
        {
            this.Employees = new Employee[17];
            this.Employees[0] = new Employee("Yakir", new Date(1, 1, 2020), 20000);
            this.Employees[1] = new Manager("Web Manager", "Rahav", new Date(1, 1, 2019), 40000);
            this.Employees[2] = new Employee("John", new Date(1, 1, 2021), 18000);

            Console.WriteLine(this.Employees[1]);

            Console.WriteLine();

            Console.WriteLine(this.Employees[1].Bonus());

            Console.WriteLine();

            object o = this.Employees[1];
            Console.WriteLine(o.ToString());
        }

        public static void UnitTest()
        {
            MyCompany myCompany = new MyCompany();
        }
    }
}