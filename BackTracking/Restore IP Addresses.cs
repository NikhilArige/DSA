/*
A valid IP address consists of exactly four integers separated by single dots. Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.
For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s. 
You are not allowed to reorder or remove any digits in s. You may return the valid IP addresses in any order.
Example 1:
Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]
Example 2:
Input: s = "0000"
Output: ["0.0.0.0"]
Example 3:
Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]
*/

public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        
        var list = new List<string>();
        if(s.Length > 12){
            return list;
        }
        GetAddresses(list,new List<int>(),0,s);
        return list;
    }
    
    void GetAddresses(List<string> res,List<int> nums,int ind,string s){
        if(ind==s.Length && nums.Count == 4){
            res.Add(String.Join(".",nums));
            return;
        }
        int val = 0;
        for(int i=ind;i<s.Length;i++){
            val = val*10 + s[i]-'0';
            if (val > 255 || nums.Count == 4 || (i > ind && val < 10)) { 
                return; 
            }
            nums.Add (val);
            GetAddresses(res, nums, i + 1, s);
            nums.RemoveAt(nums.Count - 1);
        }
    }
}
