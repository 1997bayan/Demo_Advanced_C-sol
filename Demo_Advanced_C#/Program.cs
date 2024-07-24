using Demo_Advanced_C_.Generics;
using System.Drawing;

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


            Employee employee01 = new Employee() { Id = 1 , Name = "Bayan" , Salary = 1000};
            Employee employee02 = new Employee() { Id = 2, Name = "hana", Salary = 2000 };

            if (employee01 == employee02)  /// " == " dont work with user defiend struct so we need to override
            {
                Console.WriteLine("Equal");
            }
            else { 
                Console.WriteLine("Not Equal");

            }

            Employee[] employees = new Employee[] { employee01, employee02 };

           int index2= Helper<Employee>.SearchArray(employees , employee02 );
            Console.WriteLine($"INDEX = {index2}");


            #endregion
        }
    }
}
