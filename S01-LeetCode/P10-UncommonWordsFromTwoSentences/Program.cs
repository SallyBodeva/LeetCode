public class Program
{
    static void Main()
    {
        string s1 = "this apple is sweet";
        string s2 = "this apple is sour";

        Console.WriteLine(string.Join(" ",UncommonFromSentences(s1,s2)));
    }
    public static string[] UncommonFromSentences(string s1, string s2)
    {
        string[] firstSentence = s1.Split(" ");
        string[] secondSentence = s2.Split(" ");

        List<string> result = firstSentence.Where(x => !secondSentence.Contains(x) && firstSentence.Count(word => word == x) == 1).ToList();
        result.AddRange(secondSentence.Where(x => !firstSentence.Contains(x) && secondSentence.Count(word => word == x) == 1).ToList());

        return result.ToArray();
    }
}
