using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Tema2
{
    public class TestStudent
    {
        public static void Main()
        {
            Student student1 = new Student("Mihai", "Bogdan", "Andrei", 1122334455, "Iasi", 0722222222, "mihai@whatever.com",
                                            "Universitatea Cuza", "Specializare Engleza Franceza", "Facultatea de Litere");
            Student student2 = new Student("Butnaru", "Alexandra", "Ionela", 2233445566, "Tg. Frumos", 0733333333, "alexandra@whatever.com",
                                            "Universitatea Asachi", "Specializarea Constructii", "Facultatea de constructii");

            Console.WriteLine("\nIs Mihai equal to Alexandra?");
            Console.WriteLine(student1.Equals(student2));

            Console.WriteLine("\n Comparison :Mihai and Alexandran");
            Console.WriteLine(student1.CompareTo(student2));

            Console.WriteLine("\n Copying Mihai");
            var Mihai2 = student1.Clone();

            Console.WriteLine("\n Is Mihai = Alexandra?");
            Console.WriteLine(student1 == student2);
        }
    }
}
