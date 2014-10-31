using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CMWork.Tests
{
    [TestClass()]
    public class CMWorkTests
    {
        [TestMethod()]
        public void Should_Do_Work_One_To_Hundred_DevideByThree_DevideByFive()
        {
            var dict = new Dictionary<int, string> {{3, "devidebythree"}, {5, "devidebyfive"}};
            var completed = CMWork.DevideAndPrint(1,100, dict);
            Assert.IsTrue(completed);
        }
        [TestMethod()]
        public void Should_Not_Do_Work_Hundread_To_One_DevideByThree_DevideByFive()
        {
            var dict = new Dictionary<int, string> { { 3, "devidebythree" }, { 5, "devidebyfive" } };
            var completed = CMWork.DevideAndPrint(100, 1, dict);
            Assert.IsTrue(!completed);
        }
        [TestMethod()]
        public void Should_Do_Work_NegativeHundread_To_Hundread_With_Skip_For_DevideByZero()
        {
            var dict = new Dictionary<int, string> { { 3, "devidebythree" }, { 5, "devidebyfive" }, { 0, "devidebyzero" } };
            var completed = CMWork.DevideAndPrint(-100, 100, dict);
            Assert.IsTrue(completed);
        }
        [TestMethod()]
        public void Should_Do_Work_Zero_To_Ten_With_Division_Greater_Than_Number()
        {
            var dict = new Dictionary<int, string> { { 3, "devidebythree" }, { 5, "devidebyfive" }, { 15, "devidebyfifteen" } };
            var completed = CMWork.DevideAndPrint(0, 10, dict);
            Assert.IsTrue(completed);
        }
    }
}
