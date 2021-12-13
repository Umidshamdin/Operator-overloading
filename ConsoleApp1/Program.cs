using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Umid ","Shamdinli",21);

            Person person1 = new Person("Resul", "Teymurlu", 20);

            Console.WriteLine(person1.Age);
            Console.WriteLine(person.Age);

                
                

        }
    }
}
