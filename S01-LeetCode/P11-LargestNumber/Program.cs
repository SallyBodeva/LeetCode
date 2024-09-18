using System.Text;

public class Program
{
    public static void Main()
    {
        int[] nums = { 3, 30, 34, 5, 9 };
        Console.WriteLine(LargestNumber(nums));
    }
    public static string LargestNumber(int[] nums)
    {
        string[] elements = nums.Select(x => x.ToString()).ToArray();
        Array.Sort(elements,PersonalComparison);

        StringBuilder result = new StringBuilder();
        foreach (var num in elements)
        {
            result.Append(num);
        }
        return result.ToString();
    }
    private static int PersonalComparison(string a, string b)
    {
        return (b+a).CompareTo(a + b);
    }
}

