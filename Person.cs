using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Tema2
{
    public class Person
    {
        private string Name;
        private int Age;
        public Person(string Name, int? Age = null)
        {
            this.Name = Name;
            this.Age = Age;
           
        }
        public string Names
        {
            get { return this.Names; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name can't be null"); 
                }
                this.Names = value;
            }
            
        }
        public int age 
        {
            get { return this.age; }
            private set
            {
                if (value < 1 )
                {
                    Console.WriteLine("The age (in years) should be bigger than 1"); 
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            var Show = new StringBuilder();

            Show.Append(string.Format("Name: {0}, Age: {1}", this.name, this.Age == null ? "Age not available" : this.Age.ToString()));

            return Show.ToString();
        }
    }
}
