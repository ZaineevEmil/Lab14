using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            cat.ShowInfo();
            Console.WriteLine("\n");
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string titleAnimal { get; set; }
        public Animal(string title)
        {
            titleAnimal = title;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write("Название животного: {0} , звук животного: ", titleAnimal);
            Say();
        }
    }
    class Cat : Animal
    {
        string title;
        public override string titleAnimal
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public Cat(string title)
            : base(title)
        {
        }
        public override void Say()
        {
            Console.Write("Мяу");
        }

    }
    class Dog : Animal
    {
        string title;
        public override string titleAnimal
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public Dog(string title)
            : base(title)
        {
        }
        public override void Say()
        {
            Console.Write("Гав");
        }

    }


}
