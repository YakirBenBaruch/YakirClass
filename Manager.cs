using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Manager : Employee
    {
        private string Title;
        public string GetTitle()
        {
            return this.Title;
        }

        public Manager(string Title , string name, Date dateOfGetIntoWork, double salary)
        {
            this.Title = Title;
        }
    }
}