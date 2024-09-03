public class Program
{
    public static void Main()
    {
        int[] chalk = new int[] { 5,1,5};
        int k = 22;
        Console.WriteLine(ChalkReplacer(chalk, k));
    }
    public static int ChalkReplacer(int[] chalk, int k)
    {
        int index = 0;
        while (k > 0)
        {
            for (int i = 0; i < chalk.Length; i++)
            {
                k -= chalk[i];
                if (k < 0)
                {
                    index = i;
                    break;
                }
            }

        }
        return index;
    }
}