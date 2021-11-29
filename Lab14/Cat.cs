using System;

namespace Lab14
{
    public class Cat : Animal
    {
        string title;
        public override string Title
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
        public override void Say()
        {
            Console.Write("Мяу");
        }

    }
    //class Dog : Animal
    //{
    //    string title;
    //    public new string Title
    //    {
    //        get
    //        {
    //            return title;
    //        }
    //        set
    //        {
    //            title = value;
    //        }
    //    }
    //    public override void Say()
    //    {
    //        Console.Write("Гав");
    //    }
    //}

}
