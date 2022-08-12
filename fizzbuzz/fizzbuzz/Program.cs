using System;

namespace Fizzbuzz { 
class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        double x = Math.Pow(2, 5);

        if ((n > 0) && (n < x))
        {
            for (int i = 1; i <= n; i++)
            {
                if ((n % 3 != 0) || (n % 5 != 0))
                {
                    Console.WriteLine(i);
                }
                else if ((n % 3 == 0) && (n % 5 != 0))
                    {
                        Console.WriteLine("Fizz");
                    }
                else if ((n % 5 == 0) && (n % 3 != 0))
                    {
                        Console.WriteLine("Buzz");
                    }
                else if ((n % 3 == 0) || (n % 5 == 0))
                    {
                        Console.WriteLine("FizzBuzz");
                    }

                }

            }

        }
    }

}


class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
}