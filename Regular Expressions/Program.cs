using System.Text.RegularExpressions;

namespace Regular_Expressions {
    internal class Program {
        static void Main(string[] args) {
            List<string> word_list = new() {
                "get", "set", "while"
            };
            Regex tag_matcher = new(@"[<]([^<>]+)[>]"); // Use _Verbatim Strings_ for Regular expressions
            List<Regex> expressions = new() { tag_matcher };
            foreach (string word in word_list) {
                expressions.Add(new($@"\b({word})\b"));
            }
            
        }
    }
}