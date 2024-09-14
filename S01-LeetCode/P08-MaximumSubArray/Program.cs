public class Program
{
    public static void Main()
    {
        int[] array = {311155,311155,311155,311155,311155,311155,311155,311155,201191,311155};

        Console.WriteLine(LongestSubarray(array));
    }
    public static int LongestSubarray(int[] nums)
    {
        int maxVal = nums.Max(); 
        int result = 0;
        int currentLength = 0;


        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == maxVal)
            {
                currentLength++; 
                result = Math.Max(result, currentLength); 
            }
            else
            {
                currentLength = 0; 
            }
        }

        return result;
    }

}