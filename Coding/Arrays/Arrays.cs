using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Arrays
{
    public class Arrays
    {
        public static void main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[2] = 3;
            arr[4] = 5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void ain(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] brr = { 5, 6, 7, 8, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach (int a in brr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("git test");
        }
    }

    //Array Functions
    public class ArrayFunctions
    {
        //array Max Function
        public int arrayMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        //array Min Function
        public int arrayMin(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max > array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //print array
        public void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        
        public static void aain(string[] args)
        {
            ArrayFunctions array = new ArrayFunctions();
            int[] arr = { 1, 3, 3, 4, 5, 6, 7, 9 };
            var max = array.arrayMax(arr);
            var min = array.arrayMin(arr);
            array.printArray(arr);
            Console.WriteLine();
            Console.WriteLine(max);
            Console.WriteLine();
            Console.WriteLine(min);
        }
    }


    //Multi dimensional Array
    public class MultiDimensionalArray
    {
        public static void aain(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    //Jagged Array
    public class JaggedArray
    {
        public static void bain(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { 1, 2, 3, 4, 5 };
            array[1] = new int[] { 9, 8, 7, 6 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }

    //params
    public class ParamsClass
    {
        public void Show(params int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        public void Display(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public static void aain(string[] args)
        {
            ParamsClass param = new ParamsClass();
            param.Show(9, 8, 7, 4, 5, 6, 3, 2, 1);
            param.Display("Varun S N", "TYP2226", "O+", 9874563212);
        }
    }

    //ArrayClass Functions
    public class ArrayClass
    {
        public static void main(string[] args)
        {
            int[] array = new int[] { 9, 3, 4, 5, 6, 8, 2, 1};
            array[2] = 12;
            var isFixedSize = array.IsFixedSize;
            var isReadOnly = array.IsReadOnly;
            var isSynchronized = array.IsSynchronized;
            var length = array.Length;
            var longLength = array.LongLength;
            var rank = array.Rank;
            var syncRoot = array.SyncRoot;
            Console.WriteLine(isFixedSize);
            Console.WriteLine(isReadOnly);
            Console.WriteLine(longLength);
            Console.WriteLine(rank);
            Console.WriteLine(syncRoot);
            Console.WriteLine(isSynchronized);
            Console.WriteLine(length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            
            Array.Reverse(array);
            Console.WriteLine(  );
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine(  );
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            
        }
    }
}
