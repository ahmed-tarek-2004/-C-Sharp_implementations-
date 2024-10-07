using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APP
{
    internal class Email:Info
    {
        private string email { get; set; }

        public Email()
        {
            email = Type = Desc = "";
        }


        internal override string get()
        {
            return $"\n\t\t1 - Email : {(email == "" ? "None" : email)} \n\t\t2 - Email Type : {(Type == "" ? "None" : Type)}\n\t\t3 - Describtion : {(Desc == "" ? "None" : Desc)}\n\t\t";
        }

        internal override void set()
        {
            do
            {
                Console.Write("Enter Email : ");
                email = Console.ReadLine();
            } while (email == " " || email == "" || email == null);

            Console.Write("Enter Type (if Don't Have press Enter) : ");
            Type = Console.ReadLine();

            Console.Write("Enter Describition (if Don't Have press Enter) : ");
            Desc = Console.ReadLine();
        }

    }
}
