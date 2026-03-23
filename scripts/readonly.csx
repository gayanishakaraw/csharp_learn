// Value is known only at runtime
// Should not change after initialization
// Instance-specific values
// Dependency injection values
// Configuration per instance
// Immutable object state

readonly int x = 10;
readonly string message = "Hello, World!";

System.Console.WriteLine($"x: {x}");
System.Console.WriteLine($"Message : {message}");

public class ReadOnlyExample
{
    public readonly double Pi;
    public readonly string Message;

        public ReadOnlyExample()
    {
        Pi = 3.14159;
        Message = "From default constructor.";
    }

    public ReadOnlyExample(double pi, string message)
    {
        Pi = pi;
        Message = message;
    }

    public void DisplayValues()
    {
        System.Console.WriteLine($"Pi: {Pi}");
        System.Console.WriteLine($"Message: {Message}");
    }
}

ReadOnlyExample readOnlyExample1 = new ReadOnlyExample(3.14159, "From Constructor");
System.Console.WriteLine($"1. ReadOnlyExample Pi: {readOnlyExample1.Pi}");
System.Console.WriteLine($"1. ReadOnlyExample CompanyName: {readOnlyExample1.Message}");

System.Console.WriteLine("------------------------------------");
ReadOnlyExample readOnlyExample2 = new ReadOnlyExample();
System.Console.WriteLine($"2. ReadOnlyExample Pi: {readOnlyExample2.Pi}");
System.Console.WriteLine($"2. ReadOnlyExample CompanyName: {readOnlyExample2.Message}");


public class SampleService
{
    public readonly string ServiceName;

    public SampleService(string serviceName)
    {
        ServiceName = serviceName;
    }

    public void DisplayService()
    {
        System.Console.WriteLine($"Service Name: {ServiceName}");
    }
}

public class ReadOnlyExampleTwo
{
    public readonly SampleService Service;

    public ReadOnlyExampleTwo(SampleService service)
    {
        Service = service;
    }

    public void DisplayService()
    {
        System.Console.WriteLine($"Service Name: {Service.ServiceName}");
    }
}


System.Console.WriteLine("------------------------------------");
ReadOnlyExampleTwo  readOnlyExample3 = new ReadOnlyExampleTwo(new SampleService("User Management Service"));
System.Console.WriteLine($"3. ReadOnlyExample Service Name: {readOnlyExample3.Service.ServiceName}");
