public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int position = int.MaxValue;
        int maxProfit = 0;
        
        foreach (int price in prices)
        {
            int net = price - position;
            if (net > maxProfit) maxProfit = net;

            if (price < position) position = price;
        }
        return maxProfit;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        int[] nums = [2, 4, 1];
        int result = solution.MaxProfit(nums);
        Console.WriteLine(result);
    }
}