using Tyuiu.KhanikyanDK.Sprint4.Task5.V19.Lib;

namespace Tyuiu.KhanikyanDK.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1() 
        {
            DataService ds = new DataService();
             
            int[,] array =
            {
                { -2, -1,  0,  1,  2 }, 
                { -2,  3,  1,  0, -1 }, 
                { -2,  3,  1,  0, -1 }, 
                {  2,  2, -2,  1,  0 },
                {  3, -1, -2,  1,  2 },
                {  0, -2,  3,  1, -1 }
            };

            int res = ds.Calculate(array);
            int wait = 12; 
            Assert.AreEqual(wait, res);
        }
    }
}