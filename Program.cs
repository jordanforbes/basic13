using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {1,2,3,4};
            int[] negArr = {-5,-2,3,-4,};
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(myArr);
            FindMax(negArr);
            GetAverage(myArr);
            OddArray();
            GreaterThanY(myArr,1);
            SquareArrayValues(myArr);
            EliminateNegatives(negArr);
            MinMaxAverage(myArr);
            ShiftValues(myArr);
            NumToString(negArr);
        }

        public static void PrintArrays(int[] intArr)
        {
            for(int i = 0; i< intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
        }
        public static void PrintNumbers()
        {
            for(int i = 1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if(i%2==1)
                {
                Console.WriteLine(i);

                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum +=i;
                Console.WriteLine($"New number: {i}, Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int i = 0; i<numbers.Length;i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
        }
        public static int FindMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
            return min;
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            for(int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int avg = sum/numbers.Length;
            Console.WriteLine(avg);
        }
        public static int FindAvg(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;
            Console.WriteLine(avg);
            return avg;
        }

        public static int[] OddArray()
        {
            List<int> listArr = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    listArr.Add(i);
                }
            }
            int[] output = listArr.ToArray();
            for(int k = 0; k < output.Length; k++)
            {
                Console.WriteLine(output[k]);
            }    
            return output;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int amtGreater = 0;
            for(int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i] > y)
                {
                    amtGreater++;
                }
            }
            Console.WriteLine(amtGreater);
            return amtGreater;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i]*numbers[i];
            }
            PrintArrays(numbers);     
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for(int i = 0; i< numbers.Length; i++)
            {
                if(numbers[i]<0)
                {
                    numbers[i]=0;
                }
            }

            PrintArrays(numbers);
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = FindMax(numbers);
            int min = FindMin(numbers);
            int avg = FindAvg(numbers);
            Console.WriteLine($"Max: {max}, Min: {min}, Average: {avg}");

        }
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for(int i = 0; i<numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            PrintArrays(numbers);
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] objArr = new object[numbers.Length];
            for(int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i] <0)
                {
                    objArr[i] = "Dojo";
                }
                else
                {
                    objArr[i] = numbers[i];
                }
            }
            foreach(object item in objArr)
            {
                Console.WriteLine(item);
            }
            return objArr;

        }
    }

}
