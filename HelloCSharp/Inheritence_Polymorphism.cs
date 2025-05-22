

namespace Inheritence_Polymorphism
{
    /*Base class*/
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Makes sound");
        }
    }
    //Derived class dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }

    }
    //Derived class cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}