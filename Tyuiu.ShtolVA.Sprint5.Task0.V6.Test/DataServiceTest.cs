using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShtolVA.Sprint5.Task0.V6.Lib;

namespace Tyuiu.ShtolVA.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint5\Tyuiu.ShtolVA.Sprint5.Task0.V6\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
