/*
Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
Implement the MyStack class:
void push(int x) Pushes element x to the top of the stack.
int pop() Removes the element on the top of the stack and returns it.
int top() Returns the element on the top of the stack.
boolean empty() Returns true if the stack is empty, false otherwise.
*/

public class MyStack {

    Queue<int> que;
    public MyStack() {
        que = new Queue<int>();
    }
    
    public void Push(int x) {
        que.Enqueue(x);
        for(int i=0;i<que.Count-1;i++)
        {
            var cur = que.Dequeue();
            que.Enqueue(cur);
        }
    }
    
    public int Pop() {
        return que.Dequeue();
    }
    
    public int Top() {
        return que.Peek();
    }
    
    public bool Empty() {
        return que.Count==0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
