using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> middleElements = FindMiddleElements(numbers);
        Console.WriteLine("Middle element(s): ");
        foreach (int num in middleElements) {
            Console.Write(num + " ");
        }
    }

    public static List<int> FindMiddleElements(List<int> numbers) {
        List<int> middleElements = new List<int>();
        int length = numbers.Count;

        if (length == 0) {
            return middleElements;
        }

        if (length % 2 == 1) {
            middleElements.Add(numbers[length / 2]);
        } else {
            middleElements.Add(numbers[length / 2 - 1]);
            middleElements.Add(numbers[length / 2]);
        }

        return middleElements;
    }
}
