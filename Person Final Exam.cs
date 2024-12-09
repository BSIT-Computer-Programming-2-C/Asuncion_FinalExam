// See https://aka.ms/new-console-template for more information
public class Person
{
    private string name;
    private int age;
    private string address;
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Address
    {
        get { return this.address; }
        set { this.address = value; }
    }
    static void Main(string[] args)
    {
        Person person0 = new Person("Edison", 19, "Irisan, Baguio City");
        Console.WriteLine($"Name:{person0.Name}, Age:{person0.Age}, Address:{person0.Address}");

        person0.Name = "Edison";
        person0.Age = 19;
        person0.Address = "Irisan, Baguio City";

        Console.WriteLine($"Updated Name: {person0.Name}, Age: {person0.Age}, Address: {person0}");
    }
}

