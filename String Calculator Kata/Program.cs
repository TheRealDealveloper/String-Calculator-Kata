using System;
using System.Linq;

namespace String_Calculator_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers = "//[***]\n1***2***3***11";
            int sum = 0;
            string delimiter;
            string error = "";
            if (String.IsNullOrWhiteSpace(numbers))
            {
            }
            else
            {

                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                if (subs[0].Contains("//"))
                {
                    if (subs[0][2] == '[')
                    {
                        var substemp = subs[0].Split(new Char[] { '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                        delimiter = substemp[0];
                        subs = subs[1].Split(delimiter);
                    }
                    else
                    {
                        delimiter = subs[0][2].ToString();
                        Console.WriteLine("Delimiter... " + delimiter);
                        subs = numbers.Split(delimiter);
                    }
                    
                }
                for (int i = 0; i < subs.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(subs[i]))
                    {
                        throw new Exception("Input is NOT ok!");
                    }
                    int.TryParse(subs[i], out int num);
                    if (num < 0)
                    {
                        error = error + num + ",";
                    }
                    if (num >= 0 && num <= 1000)
                    {
                        sum = sum + num;
                    }

                }

            }
            if (error != "")
            {
                throw new Exception("negatives not allowed: " + error);
            }
            Console.WriteLine(sum);
        }

        public static int Add(string numbers)
        {
            int sum = 0;
            string delimiter;
            string error = "";
            if (String.IsNullOrWhiteSpace(numbers))
            {
            }
            else
            {

                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                if (subs[0].Contains("//"))
                {
                    if (subs[0][2] == '[')
                    {
                        var substemp = subs[0].Split(new Char[] { '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                        delimiter = substemp[0];
                        subs = subs[1].Split(delimiter);
                    }
                    else
                    {
                        delimiter = subs[0][2].ToString();
                        Console.WriteLine("Delimiter... " + delimiter);
                        subs = numbers.Split(delimiter);
                    }

                }
                for (int i = 0; i < subs.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(subs[i]))
                    {
                        throw new Exception("Input is NOT ok!");
                    }
                    int.TryParse(subs[i], out int num);
                    if (num < 0)
                    {
                        error = error + num + ",";
                    }
                    if (num >= 0 && num <= 1000)
                    {
                        sum = sum + num;
                    }

                }

            }
            if (error != "")
            {
                throw new Exception("negatives not allowed: " + error);
            }
            return sum;
        }
    }
}
