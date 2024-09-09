using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {

    }
    public static  List<int> ModifiedList(int[] nums, ListNode head)
    {
        List<int> list = new List<int>();
        list.Add(head.val);

        while (true)
        {
            if (head.next == null)
            {
                break;
            }
            list.Add(head.next.val);
        }
        list = list.Where(x => !nums.Contains(x)).ToList();
        return list;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}