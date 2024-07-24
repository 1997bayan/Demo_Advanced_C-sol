using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C_.Generics
{
    internal class EmployeeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";

        }



        public override bool Equals(object? obj)
        {
            EmployeeClass? employee = (EmployeeClass?)obj;
            return (this.Id == employee?.Id) && (this.Name == employee?.Name) && (this.Salary == employee?.Salary);

        }

        public override int GetHashCode()
        {
           // return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? 0 + this.Salary.GetHashCode() ; //we dont use this way beacause  : 10 : Aliaa : 1000 , 1000 : Aliaa : 10
           return HashCode.Combine(Id.GetHashCode() , Name.GetHashCode() , Salary.GetHashCode());
        }

    }
}
