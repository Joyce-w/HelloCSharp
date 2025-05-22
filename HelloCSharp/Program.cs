//using Inheritence_Polymorphism;
using IAnimal;

namespace HelloCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*create instances of dog/cat*/
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myDog.MakeSound();
            myCat.MakeSound();


            /*Interface*/
            Dog myDog = new Dog();
            myDog.Eat();
        }

    }
}
