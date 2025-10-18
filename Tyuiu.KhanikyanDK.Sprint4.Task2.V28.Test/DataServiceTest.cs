using Tyuiu.KhanikyanDK.Sprint4.Task2.V28.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 7, 9, 4, 5, 6, 3, 7, 2 };
            int res = ds.Calculate(array);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}