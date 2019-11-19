using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Tema2
{
    public class TestPerson
    {
        static void Main()
        {
            var Ion = new Person("Ion Ionescu");
            var Vasile = new Person("Vasile Dochita", 32);
            var Andrei = new Person("Andrei Bogdan");

            Console.WriteLine("{0}\n{1}", Ion, Vasile, Andrei);
        }

    }
}
