using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtolVA.Sprint5.Task2.V2.Lib;

namespace Tyuiu.ShtolVA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint5\Tyuiu.ShtolVA.Sprint5.Task2.V2\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
