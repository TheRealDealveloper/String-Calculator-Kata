using System;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string number = "19";
            string[] subs = number.Split(new Char[] { ',', '\n' });
            
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
                        string numfuture = numbers[i + 1].ToString();
                        if (int.TryParse(numfuture, out int numfuturetemp))
                        {
                            continue;
                        }
                        throw new Exception("Input is NOT ok!");
                    }

                }
                return sum;
            }
        }
    }
}
