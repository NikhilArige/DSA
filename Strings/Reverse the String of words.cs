//Given a string A.Return the string A after reversing the string word by word.
//Input:"the sky is blue"  Output:"blue is sky the"


class Solution {
    public string solve(string A) {
        A=A.Trim();
        string[] str = A.Split(' ');
        string result = "";
        for(int i=str.Length-1;i>=0;i--){
            result+=(str[i]);
            result = result.Trim(); //if more spaces are there
            if(i!=0)
           { result+=' ';}
        }
        return result;
    }
}
