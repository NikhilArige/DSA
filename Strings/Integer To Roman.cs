/*Given an integer A, convert it to a roman numeral, and return a string corresponding to its roman numeral version
1 <= A <= 3999
For Example
Input 1:
    A = 5
Output 1:
    "V"
Input 2:
    A = 14
Output 2:
    "XIV" */
    
    
class Solution {
    public string intToRoman(int A) {
        
        string[] m = {"", "M", "MM", "MMM"};
        string[] c = {"", "C", "CC", "CCC", "CD", "D",
                            "DC", "DCC", "DCCC", "CM"};
        string[] x = {"", "X", "XX", "XXX", "XL", "L",
                            "LX", "LXX", "LXXX", "XC"};
        string[] i = {"", "I", "II", "III", "IV", "V",
                            "VI", "VII", "VIII", "IX"};
        string thousands = m[A/1000];
        string hundereds = c[(A%1000)/100];
        string tens = x[(A%100)/10];
        string ones = i[A%10];            
        string ans = thousands + hundereds + tens + ones;     
        return ans;
    } 
}

//or



class Solution {
    public string intToRoman(int A) {
        
        string s = "";
        int m = A / 1000;
        for(int i = 1;i<=m;i++)
        s += "M";
        A %= 1000;
        if(A >= 900)
        {
            s += "CM";
            A -= 900;
        }
        if(A >= 500)
        {
            s += "D";
            A -= 500;
        }
        if(A >= 400)
        {
            s += "CD";
            A -= 400;
        }
        if(A >= 100)
        {
            m = A/100;
            for(int i=1;i<=m;i++)
            s += "C";
            A %= 100;
        }
        if(A >= 90)
        {
            s += "XC";
            A -= 90;
        }
        if(A >= 50)
        {
            s += "L";
            A -= 50;
        }
        if(A >= 40)
        {
            s += "XL";
            A -= 40;
        }
        if(A >= 10)
        {
            m = A/10;
            for(int i=1;i<=m;i++)
            s += "X";
            A %= 10;
        }
        if(A == 9)
        {
            s += "IX";
            A -= 9;
        }
        if(A >= 5)
        {    
            s += "V";
            A -= 5;
        }
        if(A == 4)
        s += "IV";
        else if(A > 0)
        {
            for(int i=1;i<=A;i++)
            s += "I";
        }
        return s;
    } 
}

    
var symList = new List<KeyValuePair<int, string>>()
		{
			 new KeyValuePair<int, string>(1000, "M"),
			 new KeyValuePair<int, string>(900, "CM"),
			 new KeyValuePair<int, string>(500, "D"),
			 new KeyValuePair<int, string>(400, "CD"),
			 new KeyValuePair<int, string>(100, "C"),
			 new KeyValuePair<int, string>(90, "XC"),
			 new KeyValuePair<int, string>(50, "L"),
			 new KeyValuePair<int, string>(40, "XL"),
			 new KeyValuePair<int, string>(10, "X"),
			 new KeyValuePair<int, string>(9, "IX"),
			 new KeyValuePair<int, string>(5, "V"),
			 new KeyValuePair<int, string>(4, "IV"),
			 new KeyValuePair<int, string>(1, "I")
		};

		string result = "";

		foreach (var item in symList)
		{
			while (num>=item.Key)
			{
				result += item.Value;
				num -= item.Key;
			}
		}

		return result;
