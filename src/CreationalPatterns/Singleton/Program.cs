// Get a reference to the singleton instance
Singleton.Singleton singleton = Singleton.Singleton.GetInstance();

// Use the singleton
List<string> values = singleton.GetValues();
foreach (string value in values)
{
    Console.WriteLine(value);
}