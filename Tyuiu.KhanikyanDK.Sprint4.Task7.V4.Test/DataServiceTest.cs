using Tyuiu.KhanikyanDK.Sprint4.Task7.V4.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string value = "382976421897";

            int res = ds.Calculate(n, m, value);
            int wait = 36; // сумма всех нечетных чисел

            Assert.AreEqual(wait, res);
        }
    }
}