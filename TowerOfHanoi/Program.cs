using System;

public class TowerOfHanoi
{
    public static void Main()
    {
        Console.Write("Please enter number of disks: ");
        int disks = int.Parse(Console.ReadLine());

        MovesToH(disks, "Start", "Middle", "End");
    }

    public static void MovesToH(int n, string start, string middle, string end)
    {
        if (n > 0)
        {
            MovesToH(n - 1, start, end, middle);
            Console.WriteLine($"Move disk from {start} to {end}");
            MovesToH(n - 1, middle, start, end);
        }
    }
}