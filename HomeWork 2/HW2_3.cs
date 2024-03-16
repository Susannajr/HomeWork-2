using System;
using System.Collections.Generic;

internal class MainClass
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 7, 3, 9, 5 };
        int largestNumber = FindLargestNumber(numbers);
        Console.WriteLine("The largest number is: " + largestNumber);
    }

    public static int FindLargestNumber(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("The list is null or empty.");
        }
        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        return largest;
    }
}