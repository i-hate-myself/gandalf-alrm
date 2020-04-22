using System;

namespace sax
{
    class Program
    {
        static void Main(string[] args)
        {
            int ooga = 1;
            do
            {

                Console.WriteLine("type in the amount of tabs you want:  ");
                ooga = short.Parse(Console.ReadLine());
            } while (ooga < 1);
            int hour;
            int minute;
            int second;
            do
            {

                Console.WriteLine("type in the hour you want make sure its 2 digits formatted as 24hr time: ");
                hour = short.Parse(Console.ReadLine());
            } while (hour < 0);
            do
            {

                Console.WriteLine("type in the minute you want make sure its 2 digits formatted as 24hr time: ");
                minute = short.Parse(Console.ReadLine());
            } while (minute < 0);
            do
            {
                Console.WriteLine("type in the second you want make sure its 2 digits formatted as 24hr time: ");
                second = short.Parse(Console.ReadLine());
            } while (second < 0);
            Console.WriteLine(DateTime.Now);
            string x = DateTime.Today.ToString("dd");
            string y = DateTime.Today.ToString("MM");
            string z = DateTime.Today.ToString("yyyy");
            int day = short.Parse(x);
            Console.WriteLine("what day do you want it to go off: ");
            day = short.Parse(Console.ReadLine());
            int month = short.Parse(y);
            int year = short.Parse(z);
            DateTime datere = new DateTime(year, month, day, hour, minute, second);
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now >= datere)
                {
                    for (int a = 1; a <= ooga; a++)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = @"/C start https://www.youtube.com/watch?v=G1IbRujko-A";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    break;
                }
            }
        }
    }
}
