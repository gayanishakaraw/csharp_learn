// Shared state across all instances
// Utility/helper methods
// Stateless services

// Examples:
//  Caching
//  Counters
//  Singleton-like behavior
//  Utility classes

// ⚠️ Risks
// Thread-safety issues
// Hidden dependencies
// Harder to test (especially in unit tests)

// Best Practice
//  Keep static stateless if possible
//  If stateful → use locking or thread-safe collections
//  Avoid overuse in business logic

public static int TotalRequests;
public static void IncrementRequests()
{
    TotalRequests+=5;
}

System.Console.WriteLine($"Total Requests: {TotalRequests}");
IncrementRequests();
System.Console.WriteLine($"Total Requests after increment: {TotalRequests}");



public void DecrementRequests()
{
    TotalRequests-=2;
}

DecrementRequests();
System.Console.WriteLine($"Total Requests after decrement: {TotalRequests}");

System.Console.WriteLine("------------------------------------");
private class StaticExample
{
    public void DisplayMessage()
    {
        System.Console.WriteLine($"I see the total requests as: {TotalRequests}");
    }
}

StaticExample example = new StaticExample();
example.DisplayMessage();