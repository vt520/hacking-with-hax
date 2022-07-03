using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_Expressions {
    internal class WrongWayToMatchStrings {

        /**
         * So, you want to know the Simple way to match a thing in angle brackets?
         * Well, it doesn't get more basic than String.IndexOF, and it's _fast_!
         * 
         * This function will return the next tag surrounded by angle brackets.
         * Due to a flawed assumption, this will not return the last tag in the text
         * If you run and observe how this function operates, the solution should be 
         * obvious.
         * 
         * Usage: WrongWayToMatchStrings.GetTag(...)

            string text = "....";
            (int open, int close) marker = (0, 0);
            while ((marker = GetTag(text, marker.close)).close > 0) {
                int length = (marker.close - marker.open) - 2; // omit the brackets
                // at this point marker.open points to the '<', marker.close points to '>' and length is the count of characters between them
            }

         *  
         */
        public static (int open, int close) GetTag(string text, int start = 0) {
            int first_open = text.IndexOf('<', start);
            int second_open = text.IndexOf('<', first_open);
            int close = text.IndexOf('>', start);
            if (second_open < close) return GetTag(text, second_open); // this is important 
            return (first_open, close);
        }

        public WrongWayToMatchStrings() { }
    }
}
