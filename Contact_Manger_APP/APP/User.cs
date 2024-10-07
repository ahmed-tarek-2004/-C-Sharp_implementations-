using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class User
    {
        private int id;
        private string firstName;
        private string secondName;
        private string Gender;
        private string city;
        private DateOnly addedDate;
        private Phone userPhone;
        private Address userAddress;
        private Email userEmail;
        public User()
        {
            id = 0; firstName = secondName = Gender = city = "";
            addedDate = new DateOnly();
            userPhone = new Phone();
            userAddress = new Address();
            userEmail = new Email();
        }
        public bool searchByFirstname(string name)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First Name IS Empty");
                return false;
            }
            return firstName.Equals(name, StringComparison.OrdinalIgnoreCase);
        }
        public bool searchBySecondname(string name)
        {
            if (string.IsNullOrWhiteSpace(secondName))
            {
                Console.WriteLine("First Name IS Empty");
                return false;
            }
            return secondName.Equals(name, StringComparison.OrdinalIgnoreCase);
        }
        public bool searchBycity(string name)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine("City IS Empty");
                return false;
            }
            return city.Equals(name, StringComparison.OrdinalIgnoreCase);
        }
        public bool searchByPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(userPhone.Number))
            {
                Console.WriteLine("Phone Number IS Empty");
                return false;
            }
            return userPhone.Number.Equals(phone, StringComparison.OrdinalIgnoreCase);
        }

        public void set()
        {
            Console.Write("Enter First Name : ");
            firstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            secondName = Console.ReadLine();

            Console.Write("Enter Gender : ");
            Gender = Console.ReadLine();

            Console.Write("Enter City : ");
            city = Console.ReadLine();

            string[] dateFormats = {
            "dd/MM/yyyy",
            "d/MM/yyyy",
            "dd/M/yyyy",
            "d/M/yyyy",

            "MM/dd/yyyy",
            "M/dd/yyyy",
            "MM/d/yyyy",
            "M/d/yyyy",



           "dd-MM-yyyy",
            "d-MM-yyyy",
            "dd-M-yyyy",
            "d-M-yyyy",

            "MM-dd-yyyy",
            "M-dd-yyyy",
            "MM-d-yyyy",
            "M-d-yyyy",

            "MM/dd/yy",
        };

            string temp;
            do
            {
                Console.Write("(YYYY/MM/DD) Enter  Added Date : ");
                temp = Console.ReadLine();

            } while (!DateOnly.TryParseExact(temp, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out addedDate));


            userPhone.set();
            userAddress.set();
            userEmail.set();

        }
        public void show()
        {
            Console.WriteLine("\n===============================================\n");
            string tempforFirstName = firstName;
            string tempforLastName = secondName;
            if (!string.IsNullOrEmpty(firstName))
            {
                firstName = firstName.ToLower();
                if (firstName[0] >= 'a' && firstName[0] <= 'z' && !string.IsNullOrEmpty(firstName))
                {
                    firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
                }
            }
            if (!string.IsNullOrEmpty(secondName))
            {
                secondName = secondName.ToLower();
                if (secondName[0] >= 'a' && secondName[0] <= 'z' && !string.IsNullOrEmpty(secondName))
                {
                    secondName = char.ToUpper(secondName[0]) + secondName.Substring(1);
                }
            }

            Console.WriteLine($"\n\t1- First Name : {firstName}\n\t2- Last Name : {secondName}\n\t3- Gender : {Gender}\n\t4- City : {city}\n\t5- {userPhone.get()}\n\t6- {userAddress.get()}\n\t7- {userEmail.get()}\n\t" +
                $"8- {addedDate.ToString()}\n");
            firstName = tempforFirstName;
            secondName = tempforLastName;

            Console.WriteLine("\n===============================================\n");
        }

        public void Edit()
        {
            int choice;
            do
            {
                Console.WriteLine("\n\t[1] - Edit First Name ." +
                              "\n\t[2] - Edit Last Name ." +
                              "\n\t[3] - Edit City ." +
                              "\n\t[4] - Edit Phone Number ." +
                              "\n\t[5] - Edit Add Date ." +
                              "\n\t[6] - Cansel Operation .\n");
                Console.Write("\t\tChoose Your Answer : ");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 6);

            if (choice == 1)
            {
                editFirstName();
            }
            else if (choice == 2)
            {
                editLastName();
            }
            else if (choice == 3)
            {
                editCity();
            }
            else if (choice == 4)
            {
                editPhone();
            }
            else if (choice == 5)
            {
                editAddedDate();
            }
            else
            {
                return;
            }
        }
        private void editFirstName()
        {
            string first;
            do
            {
                Console.WriteLine("Enter New First Number : ");
                first = Console.ReadLine();
            } while (string.IsNullOrEmpty(first) || string.IsNullOrWhiteSpace(first));

            firstName = first;
        }
        private void editLastName()
        {
            string second;
            do
            {
                Console.WriteLine("Enter New Second Number : ");
                second = Console.ReadLine();
            } while (string.IsNullOrEmpty(second) || string.IsNullOrWhiteSpace(second));
            secondName = second;
        }
        private void editCity()
        {
            string City;
            do
            {
                Console.WriteLine("Enter New City : ");
                City = Console.ReadLine();
            } while (string.IsNullOrEmpty(City) || string.IsNullOrWhiteSpace(City));
            City = city;
        }
        private void editPhone()
        {
            string phone;
            do
            {
                Console.WriteLine("Enter New Phone Number : ");
                phone = Console.ReadLine();
            } while (string.IsNullOrEmpty(phone) || string.IsNullOrWhiteSpace(phone));
            userPhone.Number = phone;
        }
        public void editAddedDate()
        {
            string[] dateFormats = {
            "dd/MM/yyyy",
            "d/MM/yyyy",
            "dd/M/yyyy",
            "d/M/yyyy",

            "MM/dd/yyyy",
            "M/dd/yyyy",
            "MM/d/yyyy",
            "M/d/yyyy",



           "dd-MM-yyyy",
            "d-MM-yyyy",
            "dd-M-yyyy",
            "d-M-yyyy",

            "MM-dd-yyyy",
            "M-dd-yyyy",
            "MM-d-yyyy",
            "M-d-yyyy",

            "MM/dd/yy",
        };

            string temp;
            do
            {
                Console.Write("(YYYY/MM/DD) Enter  Added Date : ");
                temp = Console.ReadLine();

            } while (!DateOnly.TryParseExact(temp, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out addedDate));
        }

    }
}
