using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] a = { 4, 8, 2, 10 };
        int[][] b = [[2, 3], [1, 3], [0, 0], [0, 3]];
        
        Console.WriteLine(string.Join(" ",XorQueries(a, b)));
    }
    public static  int[] XorQueries(int[] arr, int[][] queries)
    {
        int[] result = new int[queries.GetLength(0)];
        

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            for (int j = 0; j < queries[i].Length; j++)
            {
                int fromIndex = queries[i][0];
                int toIndex = queries[i][1];

                int toAdd = arr[fromIndex];
                for (int k = fromIndex+1; k <= toIndex; k++)
                {
                    toAdd ^= arr[k];
                }
                result[i] = toAdd;
            }
        }

        return result;
    }
}
