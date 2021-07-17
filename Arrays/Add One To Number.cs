//Given a non-negative number represented as an array of digits,add 1 to the number ( increment the number represented by the digits ).
//The digits are stored such that the most significant digit is at the head of the list.
//Example:If the vector has [1, 2, 3] the returned vector should be [1, 2, 4] as 123 + 1 = 124.



class Solution {
    public List<int> plusOne(List<int> array) {
        int n = array.Count;
        
       
       int carry = 0;  
            // Add 1 to the last digit and find carry 
            array[n - 1] += 1;
            carry = array[n - 1] / 10;
            array[n - 1] = array[n - 1] % 10;
  
            // Traverse from second last digit 
            for(int i = n - 2; i >= 0; i--)
            {
                if(carry == 1)
                {
                    array[i] += 1;
                    carry = array[i] / 10;
                    array[i] = array[i] % 10;
                }
            }
  
            // If the carry is 1, we need to add
            // a 1 at the beginning of the array
            if(carry == 1)
            {
                array.Insert(0,1);
            }
   
              if(array[0]==0){
                   array.RemoveAt(0);    //removing 0s at beginning 
              } 
          } 
        return array;
    }
}
