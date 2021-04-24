/*Design and implement a data structure for LRU (Least Recently Used) cache. It should support the following operations: get and set.
get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
set(key, value) - Set or insert the value if the key is not already present. When the cache reaches its capacity, it should invalidate the least recently used item before inserting the new item.
The LRU Cache will be initialized with an integer corresponding to its capacity. Capacity indicates the maximum number of unique keys it can hold at a time.
Definition of “least recently used” : An access to an item is defined as a get or a set operation of the item. “Least recently used” item is the one with the oldest access time.
NOTE: If you are using any global variables, make sure to clear them in the constructor. 
Example :
Input : 
         capacity = 2
         set(1, 10)
         set(5, 12)
         get(5)        returns 12
         get(1)        returns 10
         get(10)       returns -1
         set(6, 14)    this pushes out key = 5 as LRU is full. 
         get(5)        returns -1  */

using System;
using System.Collections.Generic;
public class LRUCache{
	
	     //Doubly LinkedList with datatype of keyvalue pair
		 public class Node
			{
				public KeyValuePair<int, int> Data { get; set; }

				public Node Next { get; set; }

				public Node Previous { get; set; }

				public Node(int key, int value)
				{
					this.Data = new KeyValuePair<int,int>(key, value);
					Next = null;
					Previous = null;
				}
			  }

        private  int capacity;
        private  int count;
        private  Node head;
        private  Dictionary<int, Node> dict;
   
		public LRUCache(int capacity) {
			
				head = new Node(-1, -1);
				head.Next = head;
				head.Previous = head;
				this.capacity = capacity;
			    //dictionary of int key and value Node type
				dict = new Dictionary<int, Node>();
		}

		public int get(int key) {
				Node node;
				dict.TryGetValue(key, out node);
				if (node == null)
				{
					return -1;
				}

				this.MoveItToFirstElementAfterHead(node);

				return node.Data.Value;

		}

		public void set(int key, int value) {
			    Node node;
				dict.TryGetValue(key, out node);
				if (node == null)
				{
					if (this.count == this.capacity)
					{
						// removing the last element int dict when capacity is full
						dict.Remove(head.Previous.Data.Key);
						//removing from list
						head.Previous = head.Previous.Previous;
						head.Previous.Next = head;
						count--;
					}

					// creating new node and adding it to dictionary
					var newNode = new Node(key, value);
					dict[key] = newNode;
					this.InsertAfterTheHead(newNode);
					// increasing count
					count++;
				}
				else
				{   //updating the returned node values with latest
					node.Data = new KeyValuePair<int, int>(key, value);
					this.MoveItToFirstElementAfterHead(node);
				}
		}
		  private void MoveItToFirstElementAfterHead(Node node)
			{
			    //first delinking the node
				RemoveCurrentNode(node);
				//inserting it after head now
				this.InsertAfterTheHead(node);
			}

			private void InsertAfterTheHead(Node node)
			{
				// inserting node after the head
				node.Next = this.head.Next;
				node.Previous = this.head;
				this.head.Next.Previous = node;
				this.head.Next = node;
			}

			private void RemoveCurrentNode(Node node)
			{
				// removing the current node
				node.Previous.Next = node.Next;
				node.Next.Previous = node.Previous;
			}
}

public class LRUImplementation{
  
		public static void Main(){

			Console.WriteLine("Implementation of LRU Cache!");
		}
}

