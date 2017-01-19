using ClassLibrary2.ProminenteTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2UnitTest.PromintenteTests
{
    [TestClass]
    public class ProminenteTestTests
    {
        ProminenteClass prominente = new ProminenteClass();
            [TestMethod]
            public void getProminenteTest_Test0()
            {
                prominente.solution2(24);
            }
            [TestMethod]
            public void getProminenteTest_Test1()
            {
                int result = prominente.solution(191919); ;
                int expectedResult = 999111;
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void getProminenteTest_Test2()
            {
                int result = prominente.solution(213); ;
                int expectedResult = 321;
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void getProminenteTest_Test3()
            {
                int result = prominente.solution(1006); ;
                int expectedResult = 6100;
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void getProminenteTest_Test4()
            {
                int result = prominente.solution(0); ;
                int expectedResult = 0;
                Assert.AreEqual(result, expectedResult);
            }
            [TestMethod]
            public void getProminenteTest_Test5()
            {
                int result = prominente.solution(7); ;
                int expectedResult = 7;
                Assert.AreEqual(result, expectedResult);
            }
    }
}
