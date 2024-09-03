public class Program
{
    public static void Main()
    {
        //
    }
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        int[][] result = new int[n][];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i][j] = original[i];
            }
        }
        return result;
    }
}