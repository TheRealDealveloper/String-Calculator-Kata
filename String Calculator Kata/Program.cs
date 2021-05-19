using System;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static int Add(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            else
            {

                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                int sum = 0;
                for (int i = 0; i < subs.Length; i++)
                {
                    int.TryParse(subs[i], out int num);
                    sum = sum + num;
                }
                return sum;
            }
        }
    }
}
