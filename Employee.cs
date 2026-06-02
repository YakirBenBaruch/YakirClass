using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Employee
    {
        private const double DefaultSalary = 15000;
        private string Name;
        private Date DateOfGetIntoWork;
        private double Salary;

        public Employee(string name, Date dateOfGetIntoWork, double salary)
        {
            this.Name = name;
            this.DateOfGetIntoWork = new Date(dateOfGetIntoWork);
            this.Salary = salary;
        }

        public Employee(string name, Date dateOfGetIntoWork) : this(name, dateOfGetIntoWork, Employee.DefaultSalary) { }

        public string GetName()
        {
            return this.Name;
        }

        public Date GetDateOfGetIntoWork()
        {
            return new Date(this.DateOfGetIntoWork);
        }

        public double GetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(double salary)
        {
            this.Salary = salary;
        }

        public virtual double Bonus()
        {
            return this.Salary * 1.7;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nDate of get into work: " + this.DateOfGetIntoWork + "\nSalary: " + this.Salary + "\nBonus: " + this.Bonus();
        }

        public static void UnitTest()
        {
            Console.WriteLine("========== Employee UnitTest ==========");
            // 1) יצירה + ToString
            Employee e1 = new Employee("Yakir", new Date(1, 1, 2020), 20000);
            Console.WriteLine("---- Test 1: Create + ToString ----");
            Console.WriteLine(e1);
            Console.WriteLine();

            // 2) יצירה עם ברירת מחדל + Getters
            Employee e2 = new Employee("Yakir", new Date(1, 1, 2020));
            Console.WriteLine("---- Test 2: Create with default salary + Getters ----");
            Console.WriteLine("Name: " + e2.GetName());
            Console.WriteLine("Date of get into work: " + e2.GetDateOfGetIntoWork());
            Console.WriteLine("Salary: " + e2.GetSalary());
            Console.WriteLine();

            // 3) Setters + Bonus
            e2.SetSalary(25000);
            Console.WriteLine("---- Test 3: Setters + Bonus ----");
            Console.WriteLine("New Salary: " + e2.GetSalary());
            Console.WriteLine("Bonus: " + e2.Bonus());
        }
    }
}
