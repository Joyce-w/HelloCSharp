namespace IAnimal
{
    public interface IAnimal
    {
        void Eat();
    }

    //Add interface to animal class
    public class Animal : IAnimal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }

        public void Eat()
        {
            Console.WriteLine("Generic animal food");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public void Eat()
        {
            Console.WriteLine("Kibble");
        }
    }

}