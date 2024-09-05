public class Program
{
    public static void Main()
    {
        int[] rolls = {1,5,6};
        Console.WriteLine(string.Join(" ", MissingRolls(rolls, 3, 4)));
    }
    public static int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int sumOfNotObserved = mean * (rolls.Length + n) - rolls.Sum();

        List<int> result = new List<int>();
        
        while (true)
        {
            if (result.Sum() + 6 <= sumOfNotObserved)
            {
                result.Add(6);
            }
            else if (result.Sum() + 5 <= sumOfNotObserved)
            {
                result.Add(5);
            }
            else if (result.Sum() + 4 <= sumOfNotObserved)
            {
                result.Add(4);
            }
            else if (result.Sum() + 3 <= sumOfNotObserved)
            {
                result.Add(3);
            }
            else if (result.Sum() + 2 <= sumOfNotObserved)
            {
                result.Add(2);
            }
            else if (result.Sum() + 1 <= sumOfNotObserved)
            {
                result.Add(1);
            }

            if (result.Count == n)
            {
                break;
            }
        }
        return result.ToArray();
    }
}