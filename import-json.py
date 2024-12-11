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
