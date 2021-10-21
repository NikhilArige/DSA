/*
Convert a non-negative integer num to its English words representation.
Example 1:
Input: num = 123
Output: "One Hundred Twenty Three"
Example 2:
Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"
Example 3:
Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
Example 4:
Input: num = 1234567891
Output: "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"
*/

public class Solution {
    private static Dictionary<int, string> map = new Dictionary<int, string> {
            {1000000000, "{0} Billion {1}"},
            {1000000, "{0} Million {1}"},
            {1000, "{0} Thousand {1}"},
            {100, "{0} Hundred {1}"},
            {90, "Ninety {1}"},
            {80, "Eighty {1}"},
            {70, "Seventy {1}"},
            {60, "Sixty {1}"},
            {50, "Fifty {1}"},
            {40, "Forty {1}"},
            {30, "Thirty {1}"},
            {20, "Twenty {1}"},
            {19, "Nineteen"},
            {18, "Eighteen"},
            {17, "Seventeen"},
            {16, "Sixteen"},
            {15, "Fifteen"},
            {14, "Fourteen"},
            {13, "Thirteen"},            
            {12, "Twelve"},
            {11, "Eleven"},
            {10, "Ten"},
            {9, "Nine"},
            {8, "Eight"},
            {7, "Seven"},
            {6, "Six"},
            {5, "Five"},
            {4, "Four"},
            {3, "Three"},
            {2, "Two"},
            {1, "One"},
            {0, "Zero"}
        };
    public string NumberToWords(int num) {
        foreach (var pair in map) {
            if (num <= 10 && num == pair.Key) {
                return pair.Value;
            }
            
            int n = num / pair.Key;
            num = num % pair.Key;
            if (n >= 1) {
                if (num == 0) {
                    return string.Format(pair.Value, NumberToWords(n), "").Trim();
                } else {
                    return string.Format(pair.Value, NumberToWords(n), NumberToWords(num));
                }
            }
        }
        
        return "";
    }
}
