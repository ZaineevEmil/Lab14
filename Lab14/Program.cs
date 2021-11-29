using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static object Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.title = "Кошка";
            //cat.ShowInfo();

            //Dog dog = new Dog();
            //dog.Title = "Собака";
            //dog.ShowInfo();

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
            Console.WriteLine("Название животного: {0} , звук животного:", titleAnimal);
            Say();
        }
    }
    public class Cat : Animal
    {
        public override string titleAnimal { get { return title; } set { title = value; } }

        public Cat(string titleAnimal)
            :base(titleAnimal)
        {

        }
        public override void Say()
        {
            Console.Write("Мяу");
        }

    }
}
