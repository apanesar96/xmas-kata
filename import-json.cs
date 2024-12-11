using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class DeserializeJsonFromFile
{
    public static void Main()
    {
        string jsonFilePath = "path/to/your/file.json";
        string json = File.ReadAllText(jsonFilePath);
        var data = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
        }
    }
}
