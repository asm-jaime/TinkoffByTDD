﻿using System.Linq;

namespace numberpersistent;

public class Persist
{
    private static long MultipleDigits(long number) =>
      number
      .ToString()
      .Select(digit => digit - '0')
      .Aggregate((first, second) => first * second);

    public static int Persistence(long n)
    {
        int result = 0;

        while(n / 10 > 0)
        {
            n = MultipleDigits(n);
            result++;
        }

        return result;
    }
}
