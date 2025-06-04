namespace PersonObject;

public class Person
{
    string Name { get; set; }
    int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greeting()
    {
        Console.WriteLine(Name + " says hello!");
    }

}

////create 2 objects of person class and assign different values to 

//Person personOne = new Person("Miguel", 32);
//    Person personTwo = new Person("Hannah", 28);
//}
