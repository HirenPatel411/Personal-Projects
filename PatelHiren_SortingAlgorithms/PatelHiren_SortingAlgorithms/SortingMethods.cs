using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Research Paper - Code Profiling Research
//	File Name:		SortingMethods.cs
//	Description:	This class has all the sorting algorithm methods. This class also has a title and menu method.
//	Author:			Hiren Patel, patelhm@etsu.edu, East Tennessee State University
//	Created:		Tuesday, March 31, 2020
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PatelHiren_SortingAlgorithms
{
    /// <summary>
    /// This class has all the sorting algorithm methods.
    /// </summary>
    public class SortingMethods
    {
        private static int N = 100;                     //Number of integers in the array
        private static Random rand = new Random();     //New random numbers
        private static int choice;                      //choice of the number in the menu.

        /// <summary>
        /// This method fills up the list with random numbers between 0-400.
        /// </summary>
        /// <param name="list">The list of integers</param>
        public static void FillList(List<int> list)
        {
            for (int i = 0; i < N; i++)
            {
                list.Add(rand.Next(0, 150));
            }//end for
        }//end FillList

        /// <summary>
        /// This method swaps the numbers in the array.
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <param name="n">array at position n</param>
        /// <param name="m">array at position m</param>
        private static void Swap(List<int> list, int n, int m)
        {
            int i = list[n];
            list[n] = list[m];
            list[m] = i;
        }//end Swap

        /// <summary>
        /// This method gets the maximum number for the list
        /// </summary>
        /// <param name="list">list of integers</param>
        /// <param name="i">the number in the list</param>
        /// <returns></returns>
        private static int MaxNum(List<int> list, int i)
        {
            int max = 0;
            for (int j = 0; j < i; j++)
            {
                if (list[max] < list[j])
                {
                    max = j;
                }//end if
            }//end for

            return max;
        }//end Max

        /// <summary>
        /// This method adds the result to the existing list.
        /// </summary>
        /// <param name="left">The left side of the list </param>
        /// <param name="right">The right side of the list.</param>
        /// <returns></returns>
        private static List<int> Append(List<int> left, List<int> right)
        {
            List<int> result = new List<int>(left);
            foreach (int x in right)
                result.Add(x);
            return result;
        }//end Append

        /// <summary>
        /// This method is the sink sort algorithm for the integers
        /// </summary>
        /// <param name="list">list of integers</param>
        public static void Sink(List<int> list)
        {
            bool sorted = false;
            int pass = 0;

            while (!sorted && (pass < N))
            {
                pass++;
                sorted = true;
                for (int i = 0; i < N - pass; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }//end if
                }//end for
            }//end while
        }//end Sink

        /// <summary>
        /// This method is the selection sort algorithm for the integers
        /// </summary>
        /// <param name="list">list of integers</param>
        public static void Selection(List<int> list, int i)
        {
            if (i <= 1)
            {
                return;
            }//end if

            int max = MaxNum(list, i);

            if (list[max] != list[i - 1])
            {
                Swap(list, max, i - 1);
            }//end if

            Selection(list, i - 1);
        }//end Selection

        /// <summary>
        /// This method is the insertion sort algorithm for the integers.
        /// </summary>
        /// <param name="list">list of integers</param>
        /// <param name="j">number in list</param>
        /// <param name="k">number in list</param>
        public static void Insertion(List<int> list, int j, int k)
        {
            for (int i = 1; i < N; i++)
            {
                j = list[i];
                for (k = i; k > 0 && j < list[k - 1]; k--)
                {
                    list[k] = list[k - 1];
                }//end for

                list[k] = j;
            }//end for
        }//end Insertion

        /// <summary>
        /// Merge sort algorithm for N
        /// </summary>
        /// <param name="left">left integers in the list</param>
        /// <param name="right">right integers in the list</param>
        /// <returns>The list of integers</returns>
        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }//end if
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }//end while

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }//end while

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }//end while

            return result;
        }//end Merge

        /// <summary>
        /// This method is the merge sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <returns></returns>
        public static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;


            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(list[i]);
            for (int i = middle; i < list.Count; i++)
                right.Add(list[i]);
            left = MergeSort(left);
            right = MergeSort(right);

            result = Merge(left, right);
            return result;
        }//end MergeSort

        /// <summary>
        /// quick sort algorithm for N
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <param name="start">start of the integers in the list</param>
        /// <param name="end">end of the integers in the list</param>
        public static void QuickSort(List<int> list, int start, int end)
        {
            int left = start;
            int right = end;

            if (left >= right)
            {
                return;
            }//end if

            while (left < right)
            {
                while (list[left] <= list[right] && left < right)
                {
                    right--;
                }//end while

                if (left < right)
                {
                    Swap(list, left, right);
                }//end if

                while (list[left] <= list[right] && left < right)
                {
                    left++;
                }//end while

                if (left < right)
                {
                    Swap(list, left, right);
                }//end if
            }//end while

            QuickSort(list, start, left - 1);
            QuickSort(list, right + 1, end);
        }//end QuickSort

        /// <summary>
        /// This method is the original quick sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        public static void OriginalQuickSort(List<int> list)
        {
            QuickSort(list, 0, list.Count - 1);
        }//end OriginalQuickSort

        /// <summary>
        /// quick sort algorithm for N
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <param name="end">end of the integers in the list</param>
        /// <param name="start">start of the integers in the list</param>
        public static void QuickMedianOfThree(List<int> list, int end, int start)
        {
            const int cut = 10;
            if (start + cut > end)
            {
                Insertion(list, start, end);
            }//end if

            else
            {
                int middle = (start + end) / 2;
                if (list[middle] < list[start])
                {
                    Swap(list, start, middle);
                }//end if
                if (list[end] < list[start])
                {
                    Swap(list, start, middle);
                }//end if
                if (list[end] < list[middle])
                {
                    Swap(list, start, middle);
                }//end if

                int pivot = list[middle];
                Swap(list, start, end - 1);

                int left, right;
                for (left = start, right = end - 1; ;)
                {
                    while (list[++left] < pivot) ;
                    while (pivot > list[--right]) ;
                    if (left < right)
                    {
                        Swap(list, left, right);
                    }//end if
                    else
                    {
                        break;
                    }//end else
                    Swap(list, left, end - 1);
                    QuickMedianOfThree(list, start, left - 1);
                    QuickMedianOfThree(list, left + 1, end);
                }//end for
            }//and else
        }//end QuickMedianOfThreeSort

        /// <summary>
        /// This method is the quick median-of-three sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        public static void QuickMedianOfThreeSort(List<int> list)
        {
            QuickMedianOfThree(list, 0, list.Count - 1);
        }//end QuickMedianOfThreeSort

        /// <summary>
        /// This method is the shell sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        public static void Shell(List<int> list)
        {
            for (int gap = N / 2; gap > 0; gap = (gap == 2 ? 1 : (int)(gap / 2.2)))
            {
                int temp, j;
                for (int i = gap; i < list.Count; i++)
                {
                    temp = list[i];
                    for (j = i; j >= gap && temp < list[j - gap]; j -= gap)
                    {
                        list[j] = list[j - gap];
                    }//end for
                    list[j] = temp;
                }//end for
            }
        }//end ShellSort

        /// <summary>
        /// This method is the counting sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <returns>the new list</returns>
        public static List<int> Counting(List<int> list)
        {
            List<int> newList = new List<int>(list);

            int max = list.Max();
            int[] counts = new int[max + 1];

            for (int i = 0; i <= max; i++)
                counts[i] = 0;

            for (int j = 0; j < list.Count; j++)
                counts[list[j]]++;

            for (int j = 1; j <= max; j++)
                counts[j] += counts[j - 1];

            for (int j = 0; j < newList.Count; j++)
            {
                newList[counts[list[j]] - 1] = list[j];
                counts[list[j]]--;
            }//end for

            return newList;
        }//end Counting

        /// <summary>
        /// Copies to result to the list
        /// </summary>
        /// <param name="bin">The bin.</param>
        /// <param name="result">The result.</param>
        private static void CopyToResult(List<List<int>> bin, List<int> result)
        {
            result.Clear();
            for (int i = 0; i < 10; i++)
                foreach (int j in bin[i])
                {
                    result.Add(j);
                }//end foreach
        }//end CopyToResult

        /// <summary>
        /// Puts the digits in the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digitPosition">The digit position</param>
        /// <returns></returns>
        private static int Digit(int value, int digitPosition)
        {
            return (value / (int)Math.Pow(10, digitPosition) % 10);
        }//end Digit

        /// <summary>
        /// This method is the radix sort algorithm for the integers.
        /// </summary>
        /// <param name="list">The list of integers</param>
        /// <returns>the new list</returns>
        public static List<int> RadixSort(List<int> list)
        {
            List<List<int>> bin = new List<List<int>>(10);

            for (int i = 0; i < 10; i++)
            {
                bin.Add(new List<int>(list.Count));
            }//end for

            int numDigits = list.Max().ToString().Length;

            for (int j = 0; j < numDigits; j++)
            {
                for (int k = 0; k < list.Count; k++)
                    bin[Digit(list[k], j)].Add(list[k]);

                CopyToResult(bin, list);

                for (int i = 0; i < 10; i++)
                {
                    bin[i].Clear();
                }//end for
            }//end for

            return list;
        }//end Radix

        /// <summary>
        /// This method puts the integers in order
        /// </summary>
        /// <returns>the numbers</returns>
        public static List<int> SortedList(int N)
        {
            var v = new Random();
            var randNums = new List<int>();
            for (var i = 0; i < N; i++)
            {
                randNums.Add(v.Next(1, 150));
            }//end for
            randNums.Sort();
            return randNums;
        }//end SortedList

        /// <summary>
        /// This method puts the integers in reversed
        /// </summary>
        /// <returns>the numbers</returns>
        public static List<int> ReversedList(int N)
        {
            var v = new Random();
            var randNums = new List<int>();
            for (var i = 0; i < N; i++)
            {
                randNums.Add(v.Next(1, 150));
            }//end for

            randNums.Sort();
            randNums.Reverse();
            return randNums;
        }//end ReversedList

        /// <summary>
        /// This method puts the integers about 10% in not order
        /// </summary>
        /// <returns>the numbers</returns>
        public static List<int> TenPercentList(int N)
        {
            Random random = new Random();
            var v = new Random();
            var randNums = new List<int>();
            for (var i = 0; i < N; i++)
            {
                randNums.Add(v.Next(1, 150));
            }//end for

            randNums.Sort();

            for (int i = 0; i < randNums.Count; i++)
            {
                if (i % 10 == 0)
                {
                    int randInt = random.Next(randNums.Count);
                    Swap(randNums, i, randInt);
                }//end if
            }//end for

            return randNums;
        }//end TenPercentList

        /// <summary>
        /// Displays welcome message at the beginning of the program.
        /// </summary>
        public static void Title()
        {
            Console.Title = "CSCI-2210-001-PatelHiren-CodeProfilingResearch";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }

        /// <summary>
        /// Display Press any key to continue.
        /// </summary>
        public static void PressAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine(" Press any key to return to the main menu... ");
            Console.ReadKey();
        }//end PressAnyKey

        /// <summary>
        /// This method creates the choices the user can choose when beginning the program.
        /// </summary>
        /// <returns>Users choice</returns>
        public static int Menu()
        {
            Console.WriteLine("\n\t         Code Profiling Research Tester");
            Console.WriteLine("\t--------------------------------------------------");
            Console.WriteLine("\t1.  Sink");
            Console.WriteLine("\t2.  Selection");
            Console.WriteLine("\t3.  Insertion");
            Console.WriteLine("\t4.  Merge sort");
            Console.WriteLine("\t5.  Quick sort (Original)");
            Console.WriteLine("\t6.  Quick sort (Median-of-three)");
            Console.WriteLine("\t7.  Shell");
            Console.WriteLine("\t8.  Counting");
            Console.WriteLine("\t9.  Radix");
            Console.WriteLine("\t10. Exit");
            choice = int.Parse(Console.ReadLine());

            return choice;
        }//end menu

    }//end SortingMethods

}//end PatelHiren-SortingAlgorithms
