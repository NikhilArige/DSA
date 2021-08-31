/*
Suppose you are given the following code:
class FooBar {
  public void foo() {
    for (int i = 0; i < n; i++) {
      print("foo");
    }
  }
  public void bar() {
    for (int i = 0; i < n; i++) {
      print("bar");
    }
  }
}
The same instance of FooBar will be passed to two different threads:

thread A will call foo(), while
thread B will call bar().
Modify the given program to output "foobar" n times.
Example 1:
Input: n = 1
Output: "foobar"
Explanation: There are two threads being fired asynchronously. One of them calls foo(), while the other calls bar().
"foobar" is being output 1 time.
Example 2:
Input: n = 2
Output: "foobarfoobar"
Explanation: "foobar" is being output 2 times.
*/

using System.Threading;

public class FooBar {
    private int n;
    private readonly AutoResetEvent _fooHandle;
    private readonly AutoResetEvent _barHandle;
    public FooBar(int n) {
        this.n = n;
        _fooHandle = new AutoResetEvent(true);
        _barHandle = new AutoResetEvent(false);
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            
        	_fooHandle.WaitOne();
        	printFoo();
            _barHandle.Set();
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            
            _barHandle.WaitOne();
        	printBar();
            _fooHandle.Set();
        }
    }
}

