using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stp57variablesdataexcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string answers = Console.ReadLine();
            Console.WriteLine("What Page number?");
            string favNum = Console.ReadLine();
            Console.WriteLine("Do you need help with anything?" + " Please answer" + " true" + " or" + " false" + ".");
            bool needHelp = true;
            Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share?" + " Please give specifics.");
            string givespec = Console.ReadLine();
            Console.WriteLine("Is there any positive feedback you'd like to share?" + " Please be specific.");
            string bespec = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Thank You for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
    }
    }
}
