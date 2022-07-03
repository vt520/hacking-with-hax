using System.Text.RegularExpressions;

namespace Regular_Expressions {
    internal class Program {
        const string TestText = 
@"this is come <test> text
I also included a set of keywords while making sure
that words only whole words get selected";

        public enum Colours {
            Black,
            Green,
            Navy_Pink,
            Courdoroy
        }
        static void Main(string[] args) {
            // Example Section

            // Dots and Groups
            _ = new Regex(@"."); // matches any one char
            _ = new Regex(@"[.]"); // matches one "."
            _ = new Regex(@"[^.]"); // matches one not "."
            _ = new Regex(@"^."); // matches the first char of a line



            // Algo Section
            List<string> word_list = new() {
                "get", "set", "while", "select"
            };

            Dictionary<Regex, Colours> color_map = new() {
                // for later
            };

            Regex tag_matcher = new(@"[<]([^<>]+)[>]"); // Use _Verbatim Strings_ for Regular expressions
            List<Regex> expressions = new() { tag_matcher };
            foreach (string word in word_list) {
                expressions.Add(new($@"\b({word})\b"));
            }
            foreach (Regex expression in expressions) {
                MatchCollection matched = expression.Matches(TestText);
                foreach (Match match in matched) {
                    // try watching what happens here
                }
            }
        }
    }
}