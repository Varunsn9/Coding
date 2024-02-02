using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Arrays.ArrayPractice
{
    public class ArrayPractice
    {
        public static void SumOfArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];    
            }
            Console.WriteLine(sum);
        }

        public static void MaxOfArray()
        {
            int[] array = { 1, 2, 9,11, 8, 7, 3, 4, 5, 6 };
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine( $"{max} this is the max number from the array" );
        }
        public static void MinOfArray()
        {
            int[] array = { 9, 5, 8, 6, 7, 4, 2, 3, 1, 2, 1, 9 };
            int min = array[0];
            for(int i = 0; i<array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"{min} this is the minimun value present in array");
        }
        public static void rotationOfArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] rotatedArray = new int[array.Length];
            int rotation = Convert.ToInt32(Console.ReadLine());
            int value = 0;
            for(int i = rotation; i < array.Length; i++)
            {
                rotatedArray[value] = array[i];
                value++;
            }for(int i = 0; i < rotation; i++)
            {
                rotatedArray[value] = array[i];
                value++;
            }

            foreach(int i in rotatedArray)
            {
                Console.Write(i);
            }
        }
        public static void sortingArrayInAscendingOrder()
        {
            int[] array = { 7, 4, 1, 8, 5, 2, 9, 6, 3 };
            int num;
            for(int i = 0; i < array.Length; i++)
            {
                 
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        num = array[j];
                        array[j] = array[i];
                        array[i] = num;
                    }
                }
            }
            
            foreach(int a in array)
            {
                Console.Write(a);
            }
        }

        public static void ReversalOfArray()
        {
            int[] array = new int[9];
            int num;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for(int i = 0; i <= array.Length/2; i++)
            {
                num = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i]= num;
            }

            foreach(int a in array)
            {
                Console.Write(a);
            }
        }
        public static void SearchInAnArray()
        {
            
            int search=int.Parse(Console.ReadLine());
            int[] array = new int[10];
            int count = 10;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = count--;
            }
            count = 0;
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    Console.Write($"Index is { i}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(-1);
            }
        }
        public static void ArrayIntersection()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array1 = { 5, 6, 3, 2, 1 };
            int[] common = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        common[count] = array1[j];
                        count++;
                    }
                }
            }
            foreach(int a in common)
            {
                if (a != 0) 
                { 
                Console.WriteLine(a);
                }
            }

        }
        public static void Union()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array1 = { 6, 6, 7, 8, 9 };

            int[] concat = array.Concat(array1).Distinct().ToArray();

            foreach(int b in concat)
            {
                Console.WriteLine(b);
            }
        }
    }
}
