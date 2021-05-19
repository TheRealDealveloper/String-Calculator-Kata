using System;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Add(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
