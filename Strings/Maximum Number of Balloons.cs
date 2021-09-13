/* Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
You can use each character in text at most once. Return the maximum number of instances that can be formed.
Example 1:
Input: text = "nlaebolko"
Output: 1
Example 2:
Input: text = "loonbalxballpoon"
Output: 2 */

public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var cnt = new int[26];
        foreach(var ch in text){
            cnt[ch-'a']++;
        }
        cnt['l'-'a'] /= 2;
        cnt['o'-'a'] /= 2;
        int min = int.MaxValue;
        foreach(var item in "balloon"){ 
            min = Math.Min(min,cnt[item-'a']);
        }
        return min;
    }
}
