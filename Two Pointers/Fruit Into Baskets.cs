/*
You are visiting a farm that has a single row of fruit trees arranged from left to right. 
The trees are represented by an integer array fruits where fruits[i] is the type of fruit the ith tree produces.
You want to collect as much fruit as possible. However, the owner has some strict rules that you must follow:
You only have two baskets, and each basket can only hold a single type of fruit. There is no limit on the amount of fruit each basket can hold.
Starting from any tree of your choice, you must pick exactly one fruit from every tree (including the start tree) while moving to the right. 
The picked fruits must fit in one of your baskets.
Once you reach a tree with fruit that cannot fit in your baskets, you must stop.
Given the integer array fruits, return the maximum number of fruits you can pick.
Example 1:
Input: fruits = [1,2,1]
Output: 3
Explanation: We can pick from all 3 trees.
Example 2:
Input: fruits = [0,1,2,2]
Output: 3
Explanation: We can pick from trees [1,2,2].
If we had started at the first tree, we would only pick from trees [0,1].
Example 3:
Input: fruits = [1,2,3,2,2]
Output: 4
Explanation: We can pick from trees [2,3,2,2].
If we had started at the first tree, we would only pick from trees [1,2].
*/

public class Solution {
    public int TotalFruit(int[] fruits) {
        var n = fruits.Length;
        if(n < 3){
            return n;
        }
        var type1 = -1;
        var type2 = -1;
        var max = 0;
        var curr = 0;
        for(var i = 0; i < n; i++){
            if(type1 == -1){
                type1 = fruits[i];
                curr++;
            }  
            else if(fruits[i] == type1 || fruits[i] == type2){
                curr++;
            } 
            else if(type2 == -1){
                type2 = fruits[i];
                curr++;
            } 
            else {
                curr = 0;
                type1 = fruits[i -1];
                type2 = fruits[i];
                i--;
                while(type1 == fruits[i]){
                   i--; 
                }
            }
            max = Math.Max(max, curr);
        }
        return max;
    }
}
