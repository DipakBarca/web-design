using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Alex", 20);

        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Name: " + person1.Age);
    }
}