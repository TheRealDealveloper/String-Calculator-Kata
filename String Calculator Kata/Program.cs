using System;
using System.Collections.Generic;
using System.Linq;

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
            int sum = 0;
            string delimiter;
            string error = "";
            if (!String.IsNullOrWhiteSpace(numbers))
            {
                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                if (subs[0].Contains("//"))
                {
                    if (subs[0][2] == '[')
                    {
                        string[] del = subs[0].Split(new Char[] { '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                        var s = subs[1].Split(del, StringSplitOptions.None);
                        subs = s;
                    }
                    else
                    {
                        delimiter = subs[0][2].ToString();
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
