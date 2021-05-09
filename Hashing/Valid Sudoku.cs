/* Determine if a Sudoku is valid, according to: http://sudoku.com.au/TheRules.aspx
The Sudoku board could be partially filled, where empty cells are filled with the character ‘.’.
The input corresponding to the above configuration :
["53..7....", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79"]
A partially filled sudoku which is valid.
 Note:
A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated.
Return 0 / 1 ( 0 for false, 1 for true ) for this problem */


class Solution {
    public int isValidSudoku(List<string> A) {
        
        HashSet<string> set = new HashSet<string>();
        
        for(int i=0;i<A.Count;i++){ 
            for(int j=0;j<A[0].Length;j++){
                
                char ch = A[i][j];
                if(ch !='.'){ 
                    string s1 = "Found " +ch+" in row "+ Convert.ToString(i);
                    string s2 = "Found " +ch+" in col "+ Convert.ToString(j);
                    string s3 = "Found " +ch+" in box "+ Convert.ToString(i/3) + "and "+
                    Convert.ToString(j/3);
                    
                    if(set.Contains(s1) || set.Contains(s2) || set.Contains(s3)){
                        return 0;
                    }
                    else{
                        set.Add(s1);
                        set.Add(s2);
                        set.Add(s3);
                    } 
                } 
            } 
        }
        return 1; 
    }
}
