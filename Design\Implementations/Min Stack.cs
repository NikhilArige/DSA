/* Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
push(x) – Push element x onto stack.
pop() – Removes the element on top of the stack.
top() – Get the top element.
getMin() – Retrieve the minimum element in the stack.
Note that all the operations have to be constant time operations. */


using System;
using System.Collections.Generic;					
public class Program
{
	class Solution {
    
    public Stack<int> s = new Stack<int>();
    public int min;
    public void push(int x) {
        
        if (s.Count==0)
        {
            min = x;
            s.Push(x); 
            return;
        }
        
        if(x<min){ 
            s.Push(2*x-min);
            min = x;
        }
        else{
          s.Push(x);
        }

        }

    public void pop() {
        
        if (s.Count==0)
        {
            return;
        }
 
        int val = s.Peek();
  
        // if the top is less the current min value
        if (val < min)
        {
            min = 2*min - val;
        }
 		
		    s.Pop();
		
    }

    public int top() {
        
        if (s.Count==0)
        {
            return -1;
        }
 
        int val = s.Peek();
  
        // if the top is less the current min value
        if (val < min)
        {
            return min;
        }
        else{
            return val;
        }
    }
    public int getMin() {
        
        if(s.Count == 0){
            return -1;
        }
        else{
            return min;
        }  
    }
}

	public static void Main()
	{
		Console.WriteLine("Implementation of Min Stack");
	}
}

//or
 public class MinStack : Stack where T : IComparable
    {
        private Stack minStack;

        public MinStack()
        {
            minStack = new Stack();
        }

        public T GetMin()
        {
            return (T)minStack.Peek();
        }

        public void Pop()
        {
            var popvalue = base.Pop();
            var minvalue = this.GetMin();

            if (popvalue.CompareTo(minvalue) == 0)
            {
                minStack.Pop();
            }
        }

        public void Push(T data)
        {
            base.Push(data);
            var minvalue = this.GetMin();
            if (data.CompareTo(minvalue) <= 0) minStack.Push(data);
        }
    }










