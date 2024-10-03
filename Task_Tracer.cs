using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using static System.Console;

namespace hellworld
{
    class Program
    {

        public static void Main()
        {
            List<string> list = new List<string>();
            bool @continue = true;
            while (@continue)
            {

                Console.WriteLine("\t\t Welcome To My Task Tracer");
                Console.WriteLine("\t\t =========================\n");


                Console.WriteLine("[1] - Add Task .\n" +
                                  "[2] - Complete Task .\n" +
                                  "[3] - Remove Task .\n" +
                                  "[4] - View All Tasks .\n" +
                                  "[5] - Exist .");

                Console.Write("Enter You Choice : ");
                string test = Console.ReadLine();

                if (string.IsNullOrEmpty(test) || test.Length > 1 || int.Parse(test) > 5)
                {
                    Console.WriteLine("\n\t====================================");
                    Console.WriteLine("\t\tinvalid Input");
                    Console.WriteLine("\t====================================\n");
                    continue;
                }
                char choice = char.Parse(test);
                switch (choice)
                {
                    case '1':
                        string mission;
                        do
                        {
                            Console.Write($"Enter Task Numer {list.Count + 1} : ");
                            mission = Console.ReadLine();
                            if (string.IsNullOrEmpty(mission))
                            {
                                Console.WriteLine("\n\t====================================");
                                Console.WriteLine("\t\tEnter Vaild Input");
                                Console.WriteLine("\t====================================\n");

                            }

                        } while (string.IsNullOrEmpty(mission));
                        list.Add(mission);
                        Console.WriteLine("\t====================================");
                        Console.WriteLine("\t\tTask Added Successfully ^_^");
                        Console.WriteLine("\t====================================\n");
                        break;
                    case '2':
                        Console.Write("Enter Targeted Task Number To Complete : ");
                        int temp = int.Parse(Console.ReadLine());
                        list.RemoveAt(temp - 1);
                        Console.WriteLine("\t====================================");
                        Console.WriteLine("\t\tTask Completed Successfully ^_^");
                        Console.WriteLine("\t====================================\n");
                        break;
                    case '3':
                        Console.Write("Enter Targeted Task Number To Delete : ");
                        temp = int.Parse(Console.ReadLine());
                        list.RemoveAt(temp - 1);
                        Console.WriteLine("\t====================================");
                        Console.WriteLine("\t\tTask Deleted Successfully ^_^");
                        Console.WriteLine("\t====================================\n");
                        break;
                    case '4':

                        if (list.Count == 0)
                        {
                            Console.WriteLine("\t====================================");
                            Console.WriteLine("\t\t          No Tasks To List ");
                            Console.WriteLine("\t====================================\n");
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine("\t====================================");
                                Console.WriteLine($"\t\t         Task - {i + 1} : {list[i]}");
                                Console.WriteLine("\t====================================\n");
                            }
                        }
                        break;
                    default:
                        @continue = false;
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("\n\t\t====================================");
            Console.WriteLine("\t\t      Visit Us Again (^ _ ^)");
            Console.WriteLine("\t\t====================================\n");
          

        }
    }
}
