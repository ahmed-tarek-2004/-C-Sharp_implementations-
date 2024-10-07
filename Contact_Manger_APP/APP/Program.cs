// See https://aka.ms/new-console-template for more information
using APP;
using System;
namespace ContactManger
{
    class Run
    {
        public static void Main(String[] args)
        {
            Contact contact = new Contact();
            while (true)
            {
                contact.Run();
            }
        }
    }
}