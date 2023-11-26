﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolVA.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Convert.ToDouble(strx);
            double res = Math.Round((Math.Sin(x) + (Math.Pow(x, 2) / 2)), 3);

            return res;
        }   
    }
}
