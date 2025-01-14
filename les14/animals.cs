using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les14
{
    abstract class Animals
    {
        public abstract string Name { get; set; }

        public Animals(string name) 
        {
            Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }

    }

    class Cat : Animals
    {
        private string name;
        private string povedenie;
        public override string Name
        { get => name;
          set => name=value; 
        }
        public Cat(string name, string povedenie)
            :base(name)
        {
            this.povedenie = povedenie;
        }
        public override void Say()
        {
            Console.WriteLine($"говорит Мяу и {povedenie}");
        }
    }

    class Dog : Animals
    {
        private string name;
        private string povedenie;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name, string povedenie)
            : base(name)
        {
            this.povedenie = povedenie;
        }
        public override void Say()
        {
            Console.WriteLine($"говорит Гав-гав и {povedenie}");
        }
    }

}
