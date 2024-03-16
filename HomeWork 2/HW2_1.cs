using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] bars = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int fakeBar = FindFakeBar(bars);
        Console.WriteLine("The fake gold bar is: " + fakeBar);
    }
    public static int FindFakeBar(int[] bars)
    {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> remaining = new List<int>();

        while (remaining.Count != 1)
        {
            left.Clear();
            right.Clear();
            remaining.Clear();
            //startiong from 0 index and ending with 3 index
            left.AddRange(bars[0..3]);
            right.AddRange(bars[3..6]);
            remaining.AddRange(bars[6..]);
            int result = Weigh(left.ToArray(), right.ToArray());

            if (result < 0)
            {
                bars = left.ToArray();
            }
            else if (result > 0)
            {
                bars = right.ToArray();
            }
            else
            {
                bars = remaining.ToArray();
            }
        }
        return bars[0];
    }
    public static int Weigh(int[] left, int[] right)
    {
        return 0;
    }
}
