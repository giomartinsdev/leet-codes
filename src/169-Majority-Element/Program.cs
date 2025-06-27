public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int,int> candidatesWithCount = new();

        foreach (int num in nums)
        {
            if (!candidatesWithCount.ContainsKey(num)) candidatesWithCount[num] = 1;

            if (candidatesWithCount[num] > nums.Length / 2) return num;

            candidatesWithCount[num]++;
        }
        return -1;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        int[] nums = [3,2,3];
        int result = solution.MajorityElement(nums);
        Console.WriteLine(result);
    }
}