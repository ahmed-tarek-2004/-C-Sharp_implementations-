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

            while (true)
            {
                string command;

                Console.Write(" >> ");
                command = Console.ReadLine().Trim();

                int cmdLength = command.IndexOf(" ");
                string cmd = command.Substring(0, cmdLength == -1 ? 0 : cmdLength).ToLower();
                string path = command.Substring(cmdLength + 1).Trim();



                if (cmd == "list")
                {
                    bool temp = false;

                    if (Directory.Exists(path))
                    {
                        temp = true;
                        foreach (var item in Directory.GetDirectories(path))
                        {
                            Console.WriteLine($"[Dir] : {item}");
                        }
                    }

                    if (true)
                    {
                        temp = true;
                        foreach (var item in Directory.GetFiles(path))
                        {
                            Console.WriteLine($"[Fil] : {item}");
                        }
                    }
                    if (!temp)
                    {
                        Console.WriteLine("\tInvalid Path");
                    }
                }


                else if (cmd == "info")
                {
                    if (File.Exists(path))
                    {
                        DirectoryInfo info = new DirectoryInfo(path);
                        Console.WriteLine("[Type] : File");
                        Console.WriteLine($"Created At : {info.CreationTime}");
                        Console.WriteLine($"Last Updated At : {info.LastWriteTime}");

                    }
                    else if (Directory.Exists(path))
                    {
                        DirectoryInfo info = new DirectoryInfo(path);
                        Console.WriteLine("[Type] : Director");
                        Console.WriteLine($"Created At : {info.CreationTime}");
                        Console.WriteLine($"Last Updated At : {info.LastWriteTime}");

                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Path");
                    }
                }


                else if (cmd == "mkdir")
                {
                    string tempDirectory = path.Substring(0, path.LastIndexOf("\\"));
                    if (Directory.Exists(tempDirectory))
                    {
                        Directory.CreateDirectory(path);
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Path");
                    }
                }


                else if (cmd == "remove")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path);
                    }
                    else if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Path");
                    }
                }


                else if (cmd == "print")
                {
                    if (File.Exists(path))
                    {
                        File.ReadAllText(path);
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Path");
                    }
                }

                else if (cmd == "exist")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\tSORRY INVALID CMD ");
                }
            }
           
        }
    }


}
