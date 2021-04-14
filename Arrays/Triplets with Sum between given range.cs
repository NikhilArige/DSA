//Given an array of real numbers greater than zero in form of strings.
//Find if there exists a triplet (a,b,c) such that 1 < a+b+c < 2 . Return 1 for true or 0 for false.
//Given [0.6, 0.7, 0.8, 1.2, 0.4] , You should return 1 as 0.6+0.7+0.4=1.7 and 1<1.7<2
//O(n) solution is expected.
//Note: You can assume the numbers in strings don’t overflow the primitive data type and there are no leading zeroes in numbers. Extra memory usage is allowed.



class Solution {
    public int solve(List<string> A) {
        List<double> res = new List<double>();
        foreach(var item in A){
            res.Add(Convert.ToDouble(item));
        }
        double a,b,c;
         a= res[0];b=res[1];c=res[2];
         
         for(int i=3;i<res.Count;i++){
             if (a + b + c > 1 && a + b + c < 2) {
			return 1;
		} 
		//replacing max with ith 
		else if (a + b + c > 2) {
			if (a > b && a > c) {
				a = res[i];
			}
			else if (b > a && b > c) {
				b = res[i];
			}
			else if (c > a && c > b) {
				c = res[i];
			}
		} 
		//replacing min with ith
		else {
			if (a < b && a < c) {
				a = res[i];
			}
			else if (b < a && b < c) {
				b = res[i];
			}
			else if (c < a && c < b) {
				c = res[i];
			}
		 }     
        }
         if (a + b + c > 1 && a + b + c < 2) {
			return 1;
		} 
		else{
		    return 0;
		}     
    }
}
