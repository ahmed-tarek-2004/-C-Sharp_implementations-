using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace APP
{
  
    internal class Phone : Info
    {

        public string Number { get; set; }

        public Phone()
        {
            Number = Type = Desc = "";
        }

        internal override string get()
        {
            return $"\n\t\t1 - Phone Number : {(Number == "" ? "None" : Number)} \n\t\t2 - Phone Type : {(Type == "" ? "None" : Type)}\n\t\t3 - Describtion : {(Desc == "" ? "None" : Desc)}\n\t";
        }

        internal override void set()
        {
            do
            {
                Console.Write("Enter Phone Number : ");
                Number = Console.ReadLine();
            } while (Number == " " || Number == "" || Number == null);

            Console.Write("Enter Type (if Don't Have press Enter) : ");
            Type = Console.ReadLine();

            Console.Write("Enter Describition (if Don't Have press Enter) : ");
            Desc = Console.ReadLine();

        }
    }
}
