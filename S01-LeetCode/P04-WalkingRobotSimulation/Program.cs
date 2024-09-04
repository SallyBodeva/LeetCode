public class Program
{
    public static void Main()
    {
        int[] position = new int[] { 0, 0 };
        int[] commands = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        // int[] obstacles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int direction = 0;
        int maxPoint = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            int movement = commands[i];

            if (movement > maxPoint)
            {
                maxPoint = movement;
            }

            if (movement == -1)
            {
                direction++;
                continue;
            }
            else if (movement == -2)
            {
                direction--;
                continue;
            }
            if (direction == 2)
            {
                position[1] -= movement;
            }
            else if (direction == 3)
            {
                position[0] -= movement;
            }
            else
            {
                position[direction] += movement;
            }
        }
        Console.WriteLine(Math.Pow(maxPoint,2));
    }
}
