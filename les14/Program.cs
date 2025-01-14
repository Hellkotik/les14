using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace les14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите имя кота");
            string name_cat=Console.ReadLine();
            Console.WriteLine("Напишите, что делает кот");
            string povedenie_cat=Console.ReadLine();
            Cat cat=new Cat(name_cat,povedenie_cat);
            Console.WriteLine("Напишите имя собаки");
            string name_dog = Console.ReadLine();
            Console.WriteLine("Напишите, что делает собака");
            string povedenie_dog = Console.ReadLine();
            Dog dog = new Dog(name_dog, povedenie_dog);
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();

        }
    }
}
