csharp
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var builder = new StringBuilder();
        int len1 = word1.Length;
        int len2 = word2.Length;
        int maxLength = Math.Max(len1, len2);

        for (int i = 0; i < maxLength; i++) {
            if (i < len1)
                builder.Append(word1[i]);
            if (i < len2)
                builder.Append(word2[i]);
        }

        return builder.ToString();
    }
}