using System;
					
public class Program
{
	public static void Main()
	{  
		int s = 4,h=3;
		int c= 0;
			c = (s+1)*2;
 			for(int j=1;j<=h;j++){
        			square(s,((h-j)*c),c,j);
        			Console.WriteLine();
		    }
		
	}
	
	public static void space(int n){
			for(int i=1;i<=n;i++){
			Console.Write(" ");
		}
	}
	
	public static void square(int n,int max,int s,int a){
		space(max);
		
		for(int i=0;i<=n;i++){
			for(int m=0;m<a;m++){
				for(int j=0;j<=n;j++){
				if(i==0 || j==0 || j==n || i==n){
					Console.Write("*");
				}
				else{
				Console.Write(" ");
				}
				Console.Write(" ");	
			}
				space(s);
		  }
			
			if(i!=n){
				Console.WriteLine();
					space(max);
			}
		}	
	}
}
