using System.IO;
using Tyuiu.SobjaninMI.Sprint5.Task1.V26.Lib;
namespace Tyuiu.SobjaninMI.Sprint5.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekedSaveToFileTextData()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int endValue = 5;
            string path = ds.SaveToFileTextData(startValue, endValue);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
