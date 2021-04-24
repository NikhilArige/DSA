/* Implementation of Heap using array */

using System;
public class Heap
    {
		private int[] heaparray {get; set;}
	
		private  int length {get; set;}
	
		private int currentsize {get;set;}
		
		public Heap(int n){
		  
			heaparray = new int[n];
			length = n;
			currentsize = 0;
		}
		public int[] GetHeapArray(){
		  
			return heaparray;
		}
	
		private int GetParent(int index){
			if (index <= 0)
            {
                return -1;
            }
			return (index-1)/2;
		}
		
		public int GetSize(){
		  
			return currentsize;
		}
	
		private int GetLeftChild(int index){
				return (2*index) + 1;
		}
	
	    private int GetRightChild(int index){
			return (2*index) + 2;
		}
		
		public int GetMin()
		{
			if(currentsize>0){
			return heaparray[0];
			}
			else{
				return -1;
			}
		}

		public void Add(int value){
			
			if(currentsize>=length){
				Console.WriteLine("Size exceeded!");
			} 
			heaparray[currentsize] = value;
			currentsize++;
			this.HeapifyUp(currentsize-1);
		}
		
       
        public void PopMin()
        {
            if (currentsize > 0)
            {
                var item = heaparray[0];
                heaparray[0] = heaparray[currentsize- 1];
				heaparray[currentsize- 1] = item;
				currentsize--;
                this.HeapifyDown(0);
            }
			else{
            Console.WriteLine("No element to pop in heaparray!");
			}
        }

        private void HeapifyUp(int index)
        {
            var parent = this.GetParent(index);
            if (parent >= 0 && heaparray[index]<heaparray[parent])
            {
                var temp = heaparray[index];
                heaparray[index] = heaparray[parent];
                heaparray[parent] = temp;

                this.HeapifyUp(parent);
            }
        }

        private void HeapifyDown(int index)
        {
            var smallest = index;

            var left = this.GetLeftChild(index);
            var right = this.GetRightChild(index);

            if (left < currentsize && heaparray[left]<heaparray[index])
            {
                smallest = left;
            }
															//comparing with latest as we need to take min of left and right
            if (right < currentsize && heaparray[right]<heaparray[smallest])
            {
                smallest = right;
            }

            if (smallest != index)
            {
                var temp = heaparray[index];
                heaparray[index] = heaparray[smallest];
                heaparray[smallest] = temp;

                this.HeapifyDown(smallest);
            }

            }

           }

public class MinHeapImplementation
{
	public static void Main()
	{
		Heap heap = new Heap(6);
		heap.Add(6);
		heap.Add(3);
		heap.Add(5);
		heap.Add(4);
		heap.Add(1);
		heap.Add(2);
		Console.WriteLine($"Minimum element is { heap.GetMin()}");
		Console.Write($"Normal Array: ");
		foreach(var item in heap.GetHeapArray()){
		Console.Write(item);
		}
		while(heap.GetSize()>0){
			heap.PopMin();
		}
		Console.WriteLine();
		Console.Write($"Array after removing all elements: ");
		foreach(var item in heap.GetHeapArray()){
		Console.Write(item);
		}
	}
}     
   
