using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APP
{
    internal class Address:Info
    {
        private string address { get; set; }

        public Address()
        {
            address = Type = Desc = "";
        }

       

        internal override string get()
        {
            return $"\n\t\t1 - Address : {(address == "" ? "None" : address)} \n\t\t2 - Address Type : {(Type == "" ? "None" : Type)}\n\t\t3 - Describtion : {(Desc == "" ? "None" : Desc)}\n\t\t";
        }

        internal override void set()
        {
            do
            {
                Console.Write("Enter Address : ");
                address = Console.ReadLine();
            } while (address == " " || address == "" || address == null);

            Console.Write("Enter Type (if Don't Have press Enter) : ");
            Type = Console.ReadLine();

            Console.Write("Enter Describition (if Don't Have press Enter) : ");
            Desc = Console.ReadLine();

        }
    }
}
