/*
In a party of N people(named 0 to n-1), only one person is known to everyone. Such a person may be present in the party, if yes, (s)he doesn’t know anyone in the party.
We can only ask questions like “does A know B? “. Find the stranger (celebrity) in the minimum number of questions.
We can describe the problem input as an array of numbers/characters representing persons in the party. We also have a hypothetical function knows(A, B) 
which returns true if A knows B, false otherwise. How can we solve the problem. 
*/


  
/* The knows API is defined in the parent class Relation.
      boolean knows(int a, int b); */

public class Solution : Relation {
  public int findCelebrity(int n) {
    int assumedcelebrity = 0;
    for (int i = 1; i < n; i++) {
      if (knows(assumedcelebrity, i)) {
        assumedcelebrity = i;
      }
    }
    for (int i = 0; i < n; i++) { 
      if (i != assumedcelebrity && (knows(assumedcelebrity, i) || !knows(i, assumedcelebrity))) {
        return -1;
      }
    }
    return assumedcelebrity;
  }
}


