using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolaCzasu
{
    class Program
    {
        static void Main(string[] args)
        {

            FuncAndNumChooser();
            
            Console.ReadLine();
        }
        static private DateTime AddDays(string datetime, int numofdays)
        {
            DateTime dt = DateTime.Parse(datetime);
            var timeInFuture = dt.AddDays(numofdays);
            return timeInFuture;
        }
        static private DateTime RemoveDays(string datetime, string numfodays)
        {
            String numfodaysint = "-" + numfodays;
            Int32 numfodaysints = Int32.Parse(numfodaysint);
            DateTime dt = DateTime.Parse(datetime);
            var timeInPast = dt.AddDays(numfodaysints);
            return timeInPast;
        }
        static private void FuncAndNumChooser()
        {
            Console.WriteLine("If you want to see date in future press \'1\' if in past press \'2\' ");
            try
            {
                NumChooser();
            }
            catch
            {
                Console.WriteLine("It's impossible Sir...");
  

            } 
        }
        static private void NumChooser()
        {
            string chooseFunc = Console.ReadLine();
            int choosedFunc = Int32.Parse(chooseFunc);
            if (choosedFunc == 1)
            {
                Console.WriteLine("Give me date first: (year/month/day) and then number of days in future to go");
                var a = Console.ReadLine();
                Console.WriteLine("Now Set a number of days from 1 to 99999");
                var b = Console.ReadLine();
                int be = Int32.Parse(b);
                var ready1 = AddDays(a, be);
                var got = ready1.ToLongDateString();
                Console.WriteLine(got);
            }
            else if (choosedFunc == 2)
            {
                Console.WriteLine("Give me date first: (year/month/day) and then number of days in past to go");
                var a = Console.ReadLine();
                Console.WriteLine("Now Set a number of days from 1 to 99999");
                var b = Console.ReadLine();
                var ready2 = RemoveDays(a, b);
                var got1 = ready2.ToLongDateString();
                Console.WriteLine(got1);
            }
            else
            {
                var an = ("It's impossible Sir...");
                Console.WriteLine(an);
            }
        }
    }
}
