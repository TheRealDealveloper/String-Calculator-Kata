using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Calculator_Kata;
using System;

namespace String_Calculator_Kata_Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("")]
        public void Add_Empty_String_Returning_Zero(string number)
        {
            Assert.AreEqual(Program.Add(number), 0);
        }
        [DataTestMethod]
        [DataRow("19")]
        public void Add_A_Single_Number_As_String_Returning_Number(string number)
        {
            int.TryParse(number, out int num);
            Assert.AreEqual(Program.Add(number), num);
        }
        [DataTestMethod]
        [DataRow("19,1\n10,10")]
        public void Add_A_Two_Number_As_String_Returning_Sum(string number)
        {
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
            Assert.AreEqual(Program.Add(number), sum);
        }

        [DataTestMethod]
        [DataRow("//;\n1;2;3;5")]
        public void Add_A_Two_Number_As_String_Returning_Sum_With_Custom_Delimiter(string numbers)
        {
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
            Assert.AreEqual(Program.Add(numbers), sum);
        }
        [DataTestMethod]
        [DataRow("1,2,3,4,-5,2,-2,-100")]
        [ExpectedException(typeof(Exception))]
        public void Add_A_Numbers_As_String_Returning_Sum_Checking_For_Negative_Numbers(string numbers)
        {
            int sum = 0;
            char delimiter;
            string error = "";
            if (String.IsNullOrWhiteSpace(numbers))
            {
            }
            else
            {

                string[] subs = numbers.Split(new Char[] { ',', '\n' });
                if (subs[0].Contains("//"))
                {
                    delimiter = subs[0][2];
                    subs = numbers.Split(delimiter);
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
                    sum = sum + num;
                }

            }
            if (error != "")
            {
                throw new Exception("negatives not allowed: " + error);
            }
            Assert.AreEqual(Program.Add(numbers), sum);
        }

        [DataTestMethod]
        [DataRow("2,1001")]
        public void Add_Two_Numbers_As_String_Returning_Sum_Ignoring_Num_Greater_Than_1000(string numbers)
        {
            Assert.AreEqual(Program.Add(numbers), 2);
        }
    }
}
