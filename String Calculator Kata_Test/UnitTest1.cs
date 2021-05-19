using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Calculator_Kata;

namespace String_Calculator_Kata_Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("")]
        public void Add_Up_Two_Numbers_Returning_()
        {
            Assert.AreEqual(Program.Add(""), 0);
        }
    }
}
