using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Calculator_Kata;

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
        [DataRow("1")]
        public void Add_A_Single_Number_As_String_Returning_Number(string number)
        {
            int.TryParse(number, out int num);
            Assert.AreEqual(Program.Add(number), num);
        }
    }
}
