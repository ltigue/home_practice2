using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend

{
    class Person 
    {
        public string people { get; set; }
    }
       

    class Program
    {
        static void Main(string[] args)
        {
            
            Person[]people = new Person [4];
             var n = 0;
            do
            {
               
                people[n]=new Person();
                n++;
               
            }
            while (n < 4);

            Console.WriteLine(people);
            Console.ReadLine();

            


        }
    }
}
