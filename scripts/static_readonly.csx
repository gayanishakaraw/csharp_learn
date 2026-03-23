// Shared, immutable resources
// Expensive objects
private static readonly System.Net.Http.HttpClient _httpClient = new System.Net.Http.HttpClient();

// Better than `public const` for versioning safety
public static readonly string AppName = "MyApp";
public static readonly string Version = "1.2.0";

public class VersionOneInfo
{
    public static readonly string Version = "1.2.1";
}

VersionOneInfo versionInfo = new VersionOneInfo();
System.Console.WriteLine($"Version from VersionOneInfo: {versionInfo.Version}");
System.Console.WriteLine("------------------------------------");
public class VersionTwoInfo
{
    public static readonly string Version = "1.2.2";
}

VersionTwoInfo versionTwoInfo = new VersionTwoInfo();
System.Console.WriteLine($"Version from VersionTwoInfo: {versionTwoInfo.Version}"); 



// Dependency Injection | Immutable instance fields
private readonly ILogger _logger;
