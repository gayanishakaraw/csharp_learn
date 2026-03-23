// Value is fixed at compile time
// Cannot be changed anywhere
// Implicitly static

public const int MaxUsers = 100;
public const string AppName = "My Application";

// public const Constants AppConstants = new Constants();

System.Console.WriteLine($"Max Users: {MaxUsers}");
System.Console.WriteLine($"Application Name: {AppName}");
// System.Console.WriteLine($"Pi: {AppConstants.Pi}");
// System.Console.WriteLine($"Company Name: {AppConstants.CompanyName}");

public class Constants
{
    public const double Pi = 3.14159;
    public const string CompanyName = "Tech Solutions Inc.";
}

// MaxUsers = 200; // This will cause a compile-time error because MaxUsers is a constant and cannot be modified.  
// System.Console.WriteLine($"Updated Max Users: {MaxUsers}");