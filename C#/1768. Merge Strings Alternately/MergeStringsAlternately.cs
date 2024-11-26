public class Solution {
    public string MergeAlternately(string word1, string word2) {
        

        // step 1 use pointer to go over sting 
        // Initialize pointers for both strings


        int pointer1 = 0; // Pointer for word1
        int pointer2 = 0; // Pointer for word2

        // Step 2: create a stringholder to hold the 2 merged strings 
        System.Text.StringBuilder mergedString = new System.Text.StringBuilder();

        // step3: loop until one of the pointers reaches the end of its string
        while (pointer1 < word1.Length && pointer2 < word2.Length) {
            
            // step 4: add the charector from word1 at pointer 1 to the merged string
            mergedString.Append(word1[pointer1]);

            // step 5: Increment pointer1
            pointer1++;

            // step6: Add the charector from word2 at pointer2 to the merged string 
            mergedString.Append(word2[pointer2]);

            // step 5: Increment pointer2
            pointer2++;
        } 

        // Step 8: Add the remaining characters from word1 if any are left
        while (pointer1 < word1.Length)
        {
            mergedString.Append(word1[pointer1]);
            pointer1++;
        }

       // Step 9: Add the remaining characters from word2 if any are left
        while (pointer2 < word2.Length)
        {
            mergedString.Append(word2[pointer2]);
            pointer2++;
        }

        // Step 10: Convert the StringBuilder to a string and return the result
        return mergedString.ToString();
        
    }
}