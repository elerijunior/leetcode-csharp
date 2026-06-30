namespace _001_FizzBuzz;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        FizzBuzz(num);
    }

    public static void FizzBuzz(int target)
    {
        for (int i = 1; i <= target; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}