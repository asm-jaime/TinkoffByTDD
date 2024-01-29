using System;
using System.Linq;

namespace tinkoffds1;

public class Solution
{
    public (string, int) Calculate(string[] words)
    {
        var max = words.Max(word => word.Length);
        var word = words.Where(word => word.Length == max).First();
        return (word, max);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();

        Solution solution = new Solution();
        var (word, len) = solution.Calculate(words);

        Console.WriteLine(word);
        Console.WriteLine(len);
    }
}