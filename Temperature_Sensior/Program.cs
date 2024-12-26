using Temperature_Sensior;
namespace Temp_Sensor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sensor sensor = new();
            Display display = new();
            Alarm alarm = new();
            sensor.Link += display.ShowTemp;
            sensor.Link += alarm.Fire;
            while (true)
            {
                Console.WriteLine("Enter The Following :-");
                Console.WriteLine("1 - Set The New Temp .");
                Console.WriteLine("2 - Change Temp's Alarm .");
                Console.WriteLine("3 - Exist .");
                Console.Write("Enter Your Choice :");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Write("Enter New Temp : ");
                        int newTemp=int.Parse(Console.ReadLine());
                        sensor.changeTemp(newTemp);
                        break;
                    case "2":
                        Console.Write("Enter New Alarm : ");
                        int newAlarm = int.Parse(Console.ReadLine());
                        alarm.ChangeAlarm(newAlarm);
                        break;
                    case"3":
                        return;
                        break;
                    default:
                        Console.WriteLine("\n\t\tWrong Input !\n");
                       break; 
                }
            }
        }
    }
}