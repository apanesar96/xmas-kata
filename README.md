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
## Points to Consider with TDD
1. Start with a minimal, testable aspect of the problem. For example:
- Does the function correctly parse the JSON input?
- Can the function map one gift to one person?
- Does it handle multiple people receiving the same gift?

2. Implement Just Enough Code to Pass the Test
Write the simplest implementation that passes the test.

3. Refactor
After passing the test, clean up your code to ensure it's readable and efficient.
Refactor without changing functionality to improve clarity or performance. Ideally, use the rule of 3 as a guide. If the same block of code shows repetition, it's time to refactor.
Refactor when you're in a Green state and comitted, giving you the ability to rollback changes 

4. Write the Next Test
Incrementally add more complex cases:
Case 1: Multiple gifts for one person.
Case 2: Multiple people sharing the same gift.
Case 3: Edge cases like an empty JSON or missing data.
