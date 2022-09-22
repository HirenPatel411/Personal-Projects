using System;
using System.Collections.Generic;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Research Paper - Code Profiling Research
//	File Name:		Program.cs
//	Description:	This class demonstrates all the sorting algorithm methods depending on what the user chooses
//	Author:			Hiren Patel, patelhm@etsu.edu, , East Tennessee State University
//	Created:		Tuesday, March 31, 2020
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PatelHiren_SortingAlgorithms
{
    /// <summary>
    /// This class demonstrates all the sorting algorithm methods depending on what the user chooses
    /// </summary>
    public class Program
    {
        private static int N = 100;                      //Number of integers in the list
        private static Random rand = new Random();     //New random numbers

        /// <summary>
        /// This method displays the different sorting methods and the user selects one of the following
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int choice = 0;                          //User choice
            List<int> list = new List<int>();        //New list of integers


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //These three methods executes the sorted list, reversed list, and 10% not in order.
            //The default is a simple random sort.
            //Please uncomment only one if you would like to use it. Cannot use all three at the same time
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //SortingMethods.SortedList(N);
            //SortingMethods.ReversedList(N);
            //SortingMethods.TenPercentList(N);

            SortingMethods.Title();      //makes the title of program
            rand.NextDouble();           //returns double

            while (choice != 10)
            {
                choice = SortingMethods.Menu();
                SortingMethods.FillList(list);

                switch (choice)
                {
                    case 1:         //Sink sort

                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Sink:");
                        SortingMethods.Sink(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }// end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 2:         //Selection sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Selection:");
                        SortingMethods.Selection(list, N);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                            SortingMethods.Selection(list, 0);
                        }// end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 3:         //Insertion sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Insertion:");
                        SortingMethods.Insertion(list, N, 0);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 4:         //Merge sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Merge sort:");
                        list = SortingMethods.MergeSort(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 5:         //Original quick sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Original quick sort:");
                        SortingMethods.OriginalQuickSort(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 6:         //Quick median-of-three sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted in Quick median-of-three sort:");
                        SortingMethods.QuickMedianOfThreeSort(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 7:         //Shell sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted in Shell sort:");
                        SortingMethods.Shell(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 8:         //Counting sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Counting sort:");
                        list = SortingMethods.Counting(list);

                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 9:         //Radix sort
                        Console.WriteLine("\n\nThe integers in the list:");
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine(list[i]);
                        }// end for

                        Console.WriteLine("\nThe numbers sorted using Radix sort:");
                        SortingMethods.RadixSort(list);
                        for (int j = 0; j < N; j++)
                        {
                            Console.WriteLine(list[j]);
                        }//end for

                        SortingMethods.PressAnyKey();
                        Console.Clear();

                        break;

                    case 10:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Your selection was invalid. Please choose a number between 1-10.");
                        break;
                }//end switch
                list.Clear();   //clears the elements in list

            }//end while

        }//end Main

    }//end Driver

}//end 2210-001-PatelHiren-SortingAlgorithms
