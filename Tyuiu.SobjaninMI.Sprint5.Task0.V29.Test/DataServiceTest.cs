using System.IO;
using Tyuiu.SobjaninMI.Sprint5.Task0.V29.Lib;
namespace Tyuiu.SobjaninMI.Sprint5.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekedSaveToFileTextData()
        {
            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(3);
            Assert.AreEqual("169,89", res);
        }
    }
}
