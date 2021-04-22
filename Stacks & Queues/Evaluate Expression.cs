/*Evaluate the value of an arithmetic expression in Reverse Polish Notation.
Valid operators are +, -, *, /. Each operand may be an integer or another expression.
Input 1:
    A =   ["2", "1", "+", "3", "*"]
Output 1:
    9
Explaination 1:
    starting from backside:
    *: ( )*( )
    3: ()*(3)
    +: ( () + () )*(3)
    1: ( () + (1) )*(3)
    2: ( (2) + (1) )*(3)
    ((2)+(1))*(3) = 9
    
Input 2:
    A = ["4", "13", "5", "/", "+"]
Output 2:
    6
Explaination 2:
    +: ()+()
    /: ()+(() / ())
    5: ()+(() / (5))
    1: ()+((13) / (5))
    4: (4)+((13) / (5))
    (4)+((13) / (5)) = 6 */
    
class Solution {
    public int evalRPN(List<string> A) {
        
        Stack<int> st = new Stack<int>();
        int n = A.Count;
        if(n==0){return 0;}
        for(int i=0;i<n;i++){ 
            string val = A[i];
            if(val=="+" || val=="-" || val=="*" || val=="/" ){
                
                int b = st.Peek();
                st.Pop();
                int a = st.Peek();
                st.Pop();
                int res = value(A[i],a,b);
                st.Push(res);
            } 
            else{ 
                st.Push(Convert.ToInt32(A[i])); 
            }   
        }  
        return st.Peek(); 
    } 
    private int value(string operand, int a, int b){
        
        if(operand == "+"){
            return a + b;
        }
        else if(operand == "-"){
            return a - b;
        }
        else if(operand == "*"){
            return a * b;
        }
        else{
            return a / b;
        } 
    } 
}

