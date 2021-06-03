/* Given a rectangular cake with height h and width w, and two arrays of integers horizontalCuts and verticalCuts where horizontalCuts[i]
is the distance from the top of the rectangular cake to the ith horizontal cut and similarly, 
verticalCuts[j] is the distance from the left of the rectangular cake to the jth vertical cut.
Return the maximum area of a piece of cake after you cut at each horizontal and vertical position provided in the arrays horizontalCuts and verticalCuts.
Since the answer can be a huge number, return this modulo 10^9 + 7.
Example 1:
Input: h = 5, w = 4, horizontalCuts = [1,2,4], verticalCuts = [1,3]
Output: 4 
Explanation: The figure above represents the given rectangular cake. Red lines are the horizontal and vertical cuts. After you cut the cake, 
the green piece of cake has the maximum area.
Input: h = 5, w = 4, horizontalCuts = [3,1], verticalCuts = [1]
Output: 6
Explanation: The figure above represents the given rectangular cake. Red lines are the horizontal and vertical cuts.
After you cut the cake, the green and yellow pieces of cake have the maximum area. */

public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        
       if (h == 0 || w == 0){
            return 0;
       }
        
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        long hMax = (long)horizontalCuts[0];
        
        for (int i = 0; i < horizontalCuts.Length - 1; i++){
            hMax = Math.Max((long)horizontalCuts[i + 1] - (long)horizontalCuts[i], hMax);
        }
            
        hMax = Math.Max((long)h - (long)horizontalCuts[horizontalCuts.Length - 1], hMax);
        
        long wMax = (long)verticalCuts[0];
        
        for (int i = 0; i < verticalCuts.Length - 1; i++){
            wMax = Math.Max((long)verticalCuts[i + 1] - (long)verticalCuts[i], wMax);
        }
        wMax = Math.Max((long)w - (long)verticalCuts[verticalCuts.Length - 1], wMax);
        
        return (int)(hMax * wMax % 1000000007);
        
    }
