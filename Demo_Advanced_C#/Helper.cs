using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C_
{
    internal class Helper<T> where T : IComparable<T>
    {
        #region Non generics 
        //public static void SWAP(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;


        //}

        //public static void SWAP(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;

        //}
        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;

        //} 

        //public static int SearchArray(int[] array, int value)
        //{  if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i] == value)
        //                return i;

        //        }
        //    }
        //    return -1;




        //public static void BubbleSort(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length - i - 1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                Helper<int>.SWAP(ref array[j], ref array[j + 1]);

        //            }

        //        }

        //    }
        //}
        #endregion

        #region Generics
        //T => Generics type
        // SWAP => Generics method
        public static void SWAP(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }


        public static int SearchArray(T[] array, T value)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i]))
                        return i;

                }
            }
            return -1;
        }




        public static void BubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo( array[j + 1])==1)
                    {
                        Helper<T>.SWAP(ref array[j], ref array[j + 1]);

                    }

                }

            }
        }



        #endregion











    }
}
