using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C_.Generics
{
    internal class EmployeeClass : IComparable<EmployeeClass>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"({Id} :: {Name} :: {Salary})";

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

        public int CompareTo(object? obj)
        {
            //compare based on salary
            //  EmployeeClass? passedEmployee = (EmployeeClass?)obj; //Unsafe and MAY THROW exception 
            #region Is conditional Operator
            // Is operator will return True in 2 cases:
            // 1- if obj is emplpyeeClass
            // 2- if obj is an Object inherit from EmployeeClass
            //if (obj is EmployeeClass) 
            //{
            //    return this.Salary.CompareTo((EmployeeClass)obj);
            
            //}
            //return 1;
            #endregion
            #region As casting Operator

            EmployeeClass? employeePassed = obj as EmployeeClass;
            // Casting will succeed in 2 cases :
            // 1- if obj is emplpyeeClass
            // 2- if obj is an Object inherit from EmployeeClass

            return this.Salary.CompareTo(employeePassed?.Salary);


            #endregion

        }

        public int CompareTo(EmployeeClass? other)
        {
            throw new NotImplementedException();
        }
    }
}
