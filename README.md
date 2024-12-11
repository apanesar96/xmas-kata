# xmas-kata
## Gifts and People
```json
{
  "Bicycle": ["Sarah", "Bob", "Ed", "Lily", "Henry"],
  "Gameboy": ["Gary", "Ed", "Lily"],
  "Socks": ["Sarah", "Elliot", "Bob", "Harriet", "Lily", "Henry"],
  "Santa’s Autobiography": ["Fran", "Ed", "Elliot", "Bob"],
  "Lego Set": ["Sarah", "Gary", "Lily", "Harriet"],
  "Teddy Bear": ["Bob", "Ed", "Harriet"],
  "Drone": ["Henry", "Gary", "Fran"],
  "Puzzle": ["Elliot", "Lily", "Fran", "Henry"],
  "Skateboard": ["Sarah", "Bob", "Gary"],
  "Board Game": ["Fran", "Harriet", "Lily", "Henry"]
}
```

## Java
```java
import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.File;
import java.util.Map;
import java.util.List;

public class DeserializeJsonFromFile {
    public static void main(String[] args) throws Exception {
        ObjectMapper mapper = new ObjectMapper();
        File jsonFile = new File("path/to/your/file.json");
        Map<String, List<String>> data = mapper.readValue(jsonFile, Map.class);

        System.out.println(data);
    }
}
```


## C#
```C#
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
```


## Python
```python
import json

with open("path/to/your/file.json", "r") as file:
    data = json.load(file)

print(data)


##Javascript
const fs = require('fs');

fs.readFile('path/to/your/file.json', 'utf8', (err, jsonString) => {
    if (err) {
        console.log("Error reading file:", err);
        return;
    }
    try {
        const data = JSON.parse(jsonString);
        console.log(data);
    } catch (err) {
        console.log("Error parsing JSON:", err);
    }
});
```


## Rust
```rust
use serde_json::Value;
use std::fs;

fn main() {
    let json_file_path = "path/to/your/file.json";
    let json_data = fs::read_to_string(json_file_path).expect("Unable to read file");
    let data: Value = serde_json::from_str(&json_data).expect("Unable to parse JSON");

    println!("{:?}", data);
}
```


