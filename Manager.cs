using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Manager : Employee
    {
        private string title;

        public Manager(string title, string name, Date startDate)
            : base(name, startDate)
        {
            this.title = title;
        }

        public Manager(string title, string name, Date startDate, double salary)
            : base(name, startDate, salary)
        {
            this.title = title;
        }

        public string GetTitle() { return this.title; }
        public override double Bonus()
        {
            return this.GetSalary() * 10;
        }
        public override string ToString()
        {
            return $"{this.title} {base.ToString()}";
        }
    }
}