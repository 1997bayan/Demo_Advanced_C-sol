using Demo_Advanced_C_.Generics;
using System.Drawing;
using Point = Demo_Advanced_C_.Generics.Point;

namespace Demo_Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non generics [swap EX]

            //int A = 1;
            //int B = 2;

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP( ref A, ref B );

            //Console.WriteLine($"\n After swaping");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Console.WriteLine($"\n  swaping double ");
            //double A = 1.6;
            //double B = 5.5;

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP<double>(ref A, ref B);

            //Console.WriteLine($"\n After swaping");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(3, 2);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);


            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine($"\n After swaping");
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);


            #endregion

            #region Generics search EX

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int index = Helper<int>.SearchArray(array, 6);
            Console.WriteLine($"INDEX OF 6 = {index}");


            #region Struct Employee
            //Employee employee01 = new Employee() { Id = 1, Name = "Bayan", Salary = 1000 };
            //Employee employee02 = new Employee() { Id = 2, Name = "hana", Salary = 2000 };

            //if (employee01 == employee02)  /// " == " dont work with user defiend struct so we need to override
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");

            //} 

            // Employee[] employees = new Employee[] { employee01, employee02 };

            //int index2= Helper<Employee>.SearchArray(employees , employee02 );
            // Console.WriteLine($"INDEX = {index2}");
            #endregion


            #region Employee Class
            EmployeeClass emp01 = new EmployeeClass() { Id = 1, Name = "Bayan", Salary = 1000 };
            EmployeeClass emp02 = new EmployeeClass() { Id = 1, Name = "Bayan", Salary = 1000 };

            if (emp01 == emp02)  // Compare the addresses
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");

            }

            if (emp01.Equals(emp02))    // compare data
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");

            }

            Console.WriteLine($"HC EMP01 = {emp01.GetHashCode()}"); //HC EMP01 = 215122094
            Console.WriteLine($"HC EMP02 = {emp02.GetHashCode()}"); //HC EMP02 = 215122094

            #endregion

            #region Bubble sort
            int[] array2 = { 1, 16, 34, 5, 667, 78 };
            Helper<int>.BubbleSort(array2);
            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }


            EmployeeClass[] emps = new EmployeeClass[]
            {
                new EmployeeClass() { Id = 1,Name="SAAD" ,Salary = 1000 },
                new EmployeeClass() { Id = 2,Name = "mohsen" , Salary = 2000 },
                new EmployeeClass() { Id = 3,Name = "fofo" , Salary=3400 }
            };

            Console.WriteLine("\n");

            Helper<EmployeeClass>.BubbleSort(emps);
            foreach (EmployeeClass emp in emps) {
                Console.WriteLine($"{emp} ");
            }

            #endregion

            Point[] points = {

             new Point(2,3),
             new Point(4,3),
             new Point(2,6),
             new Point(2,3),
             new Point(7,8),

            };
            Helper<Point>.BubbleSort(points);

            foreach (Point point in points) 
            { Console.WriteLine($"\n({point})"); }



            #endregion
        }
    }
}
