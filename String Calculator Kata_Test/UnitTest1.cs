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
        [DataRow("19,1,\n10,10")]
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
    }
}
