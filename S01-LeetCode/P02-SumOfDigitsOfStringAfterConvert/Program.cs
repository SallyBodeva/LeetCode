public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetLucky("leetcode", 2));
    }
    public static int GetLucky(string s, int k)
    {
        s = new string(s.ToLower());
        string result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            result += (int)s[i] - 96;
        }

        int sum = 0;
        int total = 0;

        for (int i = 1; i <= k; i++)
        {
            foreach (var item in result)
            {
                sum += int.Parse(item.ToString());
            }
            result = sum.ToString();
            if (i != k)
            {
                sum = 0;
            }
        }
        return sum;
    }
}

