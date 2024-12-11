use serde_json::Value;
use std::fs;

fn main() {
    let json_file_path = "path/to/your/file.json";
    let json_data = fs::read_to_string(json_file_path).expect("Unable to read file");
    let data: Value = serde_json::from_str(&json_data).expect("Unable to parse JSON");

    println!("{:?}", data);
}
