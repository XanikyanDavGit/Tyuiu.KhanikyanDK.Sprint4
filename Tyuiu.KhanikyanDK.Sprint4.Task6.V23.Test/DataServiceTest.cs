using Tyuiu.KhanikyanDK.Sprint4.Task6.V23.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] companies = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            int res = ds.Calculate(companies);
            int wait = 2; // "Google", "Amazon", имеют длину 6

            Assert.AreEqual(wait, res);
        }
    }
}