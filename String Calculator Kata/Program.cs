using System;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers = "//;\n1;2;3;5";
            int sum = 0;
            char delimiter;
            if (String.IsNullOrWhiteSpace(numbers))
            {
                
            }
            else
            {

                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                if (subs[0].Contains("//"))
                {
                    delimiter = subs[0][2];
                    Console.WriteLine("Delimiter "+delimiter);
                    subs = numbers.Split(delimiter);
                }
                for (int i = 0; i < subs.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(subs[i]))
                    {
                        throw new Exception("Input is NOT ok!");
                    }
                    int.TryParse(subs[i], out int num);
                    sum = sum + num;
                }

            }
            Console.WriteLine(sum);
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
                    if (String.IsNullOrWhiteSpace(subs[i]))
                    {
                        throw new Exception("Input is NOT ok!");
                    }
                    int.TryParse(subs[i], out int num);
                    sum = sum + num;
                }
                return sum;
            }
        }
    }
}
