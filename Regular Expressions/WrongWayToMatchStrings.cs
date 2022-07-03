using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_Expressions {
    internal class WrongWayToMatchStrings {
        public (long open, long close) GetTag(string text, int start = 0) {
            int first_open = text.IndexOf('<', start);
            int second_open = text.IndexOf('<', first_open);
            int close = text.IndexOf('>', start);
            if (second_open > close) return GetTag(text, second_open);
            return (first_open, close);
        }
    }
}
