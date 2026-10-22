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
            string path = @"C:\APP\VSCOM\source\repos\Tyuiu.SobjaninMI.Sprint5\Tyuiu.SobjaninMI.Sprint5.Task0.V29\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
