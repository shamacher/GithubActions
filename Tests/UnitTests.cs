using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        public void Subtract_Valid()
        {
            Assert.AreEqual(5, Program.Subtract("10", "5"));
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(2, Program.Subtract("2", "0"));
        }

        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
        }

        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
        }

        public void Multiply_Valid()
        {
            Assert.AreEqual(16, Program.Multiply("4", "4"));
            Assert.AreEqual(8, Program.Multiply("4", "2"));
            Assert.AreEqual(90, Program.Multiply("9", "10"));
        }

        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
        }

        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
        }

        public void Divide_Valid()
        {
            Assert.AreEqual(10, Program.Divide("100", "10"));
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(1, Program.Divide("1", "1"));
        }

        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
        }

        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
        }

        public void Power_Valid()
        {
            Assert.AreEqual(16, Program.power("4", "4"));
            Assert.AreEqual(4, Program.power("2", "2"));
            Assert.AreEqual(100, Program.power("5", "20"));
        }

        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
        }

        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
        }
    }
}
