//using Inheritence_Polymorphism;
//using IAnimal;
//using Inheritence_Polymorphism;
//using PersonObject;
using Async_Await;

namespace HelloCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*create instances of dog/cat*/
            //Dog myDog = new Dog();
            //Cat myCat = new Cat();

            //myDog.MakeSound();
            //myCat.MakeSound();


            /////*Interface*/
            //Dog myDog = new Dog();
            //myDog.Eat();

            ///*Polymorphism w/ List of Animals*/
            //List<Inheritence_Polymorphism.Animal> animals = new List<Inheritence_Polymorphism.Animal>();
            //animals.Add(new Inheritence_Polymorphism.Dog());
            //animals.Add(new Inheritence_Polymorphism.Cat());

            //foreach (var animal in animals)
            //{
            //    animal.MakeSound();
            //}


            //Person_Object 
            //Person personOne = new Person("Miguel", 32);
            //Person personTwo = new Person("Hannah", 28);

            //personOne.Greeting(); // "Miguel says hello"


            //Async/Await
        public async Task SimulateDelay(int secondUnit)
        {
            await Task.Delay(secondUnit);

            Console.WriteLine("Message appearing after " + secondUnit + " time.");

        }

    }
}
