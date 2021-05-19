using System;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers = "1, \n3";
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string num = numbers[i].ToString();
                if (int.TryParse(num, out int numtemp))
                {
                    sum = sum + numtemp;
                }
                else
                {
                    string numfuture = numbers[i+1].ToString();
                    if (int.TryParse(numfuture, out int numfuturetemp))
                    {
                        continue;
                    }
                    throw new Exception("Input is NOT ok!");
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
                    int.TryParse(subs[i], out int num);
                    sum = sum + num;
                }
                return sum;
            }
        }
    }
}
