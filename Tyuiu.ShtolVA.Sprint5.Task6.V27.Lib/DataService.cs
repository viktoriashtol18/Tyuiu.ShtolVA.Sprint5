using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolVA.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadToEnd();
                string[] linestr = line.Split();
                for (int i = 0; i < linestr.Length - 1; i++)
                {
                    if (linestr[i].Length == 3)
                    { count++; }
                }
                if (linestr[linestr.Length - 1].Length == 4)
                { count++; }

                return count;

            }
        }
    }
}
