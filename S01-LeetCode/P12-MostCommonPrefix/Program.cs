public class Program
{
    public static void Main()
    {
        int[] arr1 = { 1,2,3};
        int[] arr2 = { 4,4,4};

        Console.WriteLine(LongestCommonPrefix(arr1,arr2));
    }
    public static int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        HashSet<string> set = new HashSet<string>();
        HashSet<string> set2 = new HashSet<string>();


        for (int i = 0; i < arr1.Length; i++)
        {
            set.Add(arr1[i].ToString());
            while (arr1[i] > 0 && arr1[i] > 9)
            {
                set.Add((arr1[i] / 10).ToString());
                arr1[i] /= 10;
            }
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            set2.Add(arr2[i].ToString());
            while (arr2[i] > 0 && arr2[i] > 9)
            {
                set2.Add((arr2[i] / 10).ToString());
                arr2[i] /= 10;
            }
        }
        set.IntersectWith(set2);
        if (set.Count == 0)
        {
            return 0;
        }
        return set.OrderByDescending(x=>x.Length).FirstOrDefault().Length;

    }
}