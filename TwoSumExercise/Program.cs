internal class Program
{
    private static void Main(string[] args)
    {
        var twoSum = TwoSumLinq(new[] { 1234, 5678, 9012 }, 14690);
        Console.WriteLine(twoSum[0]);
        Console.WriteLine(twoSum[1]);

    }
    public static int[] TwoSum(int[] numbers, int target)
    {
        for(int i = 0; i< numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                if(numbers[i] + numbers[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return new int[0];
    }
    public static int[] TwoSumLinq(int[] numbers, int target)
    {
        return numbers.Select((x, i) => 
        {
          
            foreach(var nu in numbers.Where((n, j) => x + n == target).ToArray())
            {
                return j;
            }

            return i;
        }).ToArray();
    }
}