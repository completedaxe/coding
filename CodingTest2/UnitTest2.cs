using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest2
{
    [TestClass]
    public class CodingTest2
    {
        [TestMethod]
        public void DecodeTest2()
        {
            //arrange
            int number = 133;
            string Decode = "Это не буква, а символ " + $"{(char)number}";
            //act
            coding.Numbers numbers = new coding.Numbers();
            numbers.Number = number;
            string actual = numbers.Decode();
            //assert
            Assert.AreEqual(Decode, actual);
        }
    }
}
