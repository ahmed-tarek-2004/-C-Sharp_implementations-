using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// 1- add Done
    /// 2- sarch Done
    /// 3- Show all Done
    /// 
    /// </summary>
    internal class Contact
    {
        List<User> users;
        public static int count = 0;
        public Contact()
        {
            users = new List<User>();
        }
        private void addUser()
        {
            User temp = new User();
            temp.set();
            users.Add(temp);
            count++;
        }
        private void searchForShow()
        {
            Console.WriteLine("Search BY :- \n" +
                "1 - First Name .\n" +
                "2 - Second Name .\n" +
                "3 - City .\n" +
                "4 - Phone Number\n");
            Console.Write("  Enter Your Choice : ");

              
            int choice = -1;
            do
            {
                if (choice == 0)
                {
                    Console.WriteLine("\n===============================\n" + "Sorry Invalid Summition");
                }
                Console.WriteLine("Search BY :- \n" +
               "1 - First Name .\n" +
               "2 - Second Name .\n" +
               "3 - City .\n" +
               "4 - Phone Number\n");
              Console.Write( "    Enter Your Choice : ");

            } while (!int.TryParse(Console.ReadLine(), out choice));
            if (choice == 1)
            {
                Console.Write("Enter First Name To Search : ");
                string name = Console.ReadLine();
                for (int i = 0; i < users?.Count; i++)
                {
                    if (users[i].searchByFirstname(name) == true)
                    {
                        users[i].show();
                    }
                }

            }
            else if (choice == 2)
            {
                Console.Write("Enter Second Name To Search : ");
                string name = Console.ReadLine();
                for (int i = 0; i < users?.Count; i++)
                {
                    if (users[i].searchBySecondname(name) == true)
                    {
                        users[i].show();
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter City To Search : ");
                string name = Console.ReadLine();
                for (int i = 0; i < users?.Count; i++)
                {
                    if (users[i].searchBycity(name) == true)
                    {
                        users[i].show();
                    }
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter Phone Number To Search : ");
                string Number = Console.ReadLine();
                for (int i = 0; i < users?.Count; i++)
                {
                    if (users[i].searchByPhone(Number) == true)
                    {
                        users[i].show();
                    }
                }
            }
        }
        private void ShowAll()
        {
            for (int i = 0; i < users?.Count; ++i)
            {
                users.ElementAt(i).show();
            }
        }
        private void deleteUser()
        {
            Console.WriteLine("Enter User Phone TO Delete : ");
            string phone = Console.ReadLine();
            int position = searchForEdition(phone);
            if (position >= 0)
            {
                users.RemoveAt(position);
                count--;
            }
            else
            {
                Console.WriteLine("Sorry! Phone Number Not Found ");
            }
        }
        private int searchForEdition(string name)
        {
            for (int i = 0; i < users?.Count; i++)
            {
                if (users[i].searchByPhone(name) == true)
                {
                    return i;
                }
            }

            return -1;
        }
        private void Edit()
        {
            Console.Write("\n Enter User Phone To Edit : ");
            string phone = Console.ReadLine();
            int position = searchForEdition(phone);
            if (position >= 0)
            {
                users[position].Edit();
            }
            else
            {
                Console.WriteLine("Sorry! Invalid Phone");
            }
        }
        public void Run()
        {
            int choice;
            do
            {
                Console.WriteLine("[1] - Add User .\n" +
                "[2] - Edit User .\n" +
                "[3] - Show All Users .\n" +
                "[4] - Search For A User .\n" +
                "[5] - Delete User . \n" +
                "[6] - Number Of Users . \n");
                Console.Write("\tEnter Your Choice : ");
                int.TryParse(Console.ReadLine(), out choice);

            } while (choice < 1 || choice > 6);

            if (choice == 1)
            {
                addUser();
            }
            else if (choice == 2)
            {
                Edit();
            }
            else if (choice == 3)
            {
               ShowAll();
            }
            else if (choice == 4)
            {
                searchForShow();
            }
            else if (choice == 5)
            {
               deleteUser();
            }
            else if (choice == 6)
            {
                Console.WriteLine($"You Have {count} User/s");
            }
        }
    }
}
