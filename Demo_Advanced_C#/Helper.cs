using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C_
{
    internal class Helper<T>
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



        #endregion


    }








}
