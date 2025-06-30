using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder sb = new();

        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (i < word1.Length) sb.Append(word1[i]);
            if (i < word2.Length) sb.Append(word2[i]);
        }

        return sb.ToString();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        string[] nums = ["abc", "pqr"];
        var a = solution.MergeAlternately(nums[0], nums[1]);
        Console.WriteLine(a);
    }
}