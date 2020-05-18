using System.Linq;
using System;

class Solution
{

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        int count = prices.Length;
        int sum = prices.Sum();
        while (sum > k)
        {
            for (int i = 0; i < count - 1; i++)
            {
                if (prices[i] > prices[i + 1])
                {
                    int temp = prices[i];
                    prices[i] = prices[i + 1];
                    prices[i + 1] = temp;
                }
            }
            sum = sum - prices[count - 1];
            count = count - 1;
        }
        return count;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);
        Console.WriteLine(result);
    }
}
