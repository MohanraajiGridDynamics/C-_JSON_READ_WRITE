// See https://aka.ms/new-console-template for more information

using System;
using System.Text.Json;

class Program
{
    public static string filePath =
        "/Users/mmohanraaji/Documents/E/Practise Programs/JSON_Practise_2/JSON_Practise_2/JSON_Practise_2/person.json";
    
    static void Main()
    {
        ReadFile();
        WriteFile();
        ReadFile();
    }

    public static void WriteFile()
    {
        
        Person person = new Person
        {
            FirstName = "Mohan",
            LastName = "Raji",
            Address = "123 Main Street",
            Gender = "Male",
            Age = 22,
        };

        string JsonString = JsonSerializer.Serialize(person);
        File.WriteAllText(filePath, JsonString);
    }

    public static void ReadFile()
    {
        string JsonString = File.ReadAllText(filePath);
        Person person = JsonSerializer.Deserialize<Person>(JsonString);
        Console.WriteLine($"The name is {person.FirstName} {person.LastName} who is a {person.Gender} of age {person.Age} lives in {person.Address}");
    }
}