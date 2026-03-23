// Accessible from anywhere

public int Age;
public string Name;

Age = 25;
Name = "Alice";
System.Console.WriteLine($"Name: {Name}, Age: {Age}");

public class Person
{
    public int Age;
    public string Name;

    // public int Age { get; set; }
    // public string Name { get; set; }
    
    public Person()
    {
        this.Name = "John Doe";
        this.Age = 30;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Person Name: {Name}, Age: {Age}");
    }
}

System.Console.WriteLine("------------------------------------");
Person person = new Person();
person.DisplayInfo();
System.Console.WriteLine("------------------------------------");
System.Console.WriteLine($"Accessing directly: Name: {person.Name}, Age: {person.Age}");


System.Console.WriteLine("------------------------------------");
System.Console.WriteLine("Modifying values...");
person.Name = "Jane Smith";
person.Age = 28;
person.DisplayInfo();
System.Console.WriteLine($"Accessing directly after modification: Name: {person.Name}, Age: {person.Age}");

public class EnhancedPerson
{
    public int Age { get; private set; }
    public string Name { get; private set; }
    
    public EnhancedPerson()
    {
        this.Name = "John Doe";
        this.Age = 30;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Person Name: {Name}, Age: {Age}");
    }
}

System.Console.WriteLine("------------------------------------");
EnhancedPerson enhancedPerson = new EnhancedPerson();
enhancedPerson.DisplayInfo();
System.Console.WriteLine("------------------------------------");
System.Console.WriteLine("Modifying values using methods...");
enhancedPerson.SetName("Jane Smith");
enhancedPerson.SetAge(28);
enhancedPerson.DisplayInfo();
System.Console.WriteLine($"Accessing directly after modification: Name: {enhancedPerson.Name},  Age: {enhancedPerson.Age}");    

//enhancedPerson.Name = "New Name"; // This will cause a compile-time error because the Name property has a private setter and cannot be modified outside of the class.