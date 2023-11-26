using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolVA.Sptint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double sumpol = 0;
            double sumotr = 0;
            double n;
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine())!=null)
                {
                    n = Convert.ToDouble(line);
                    if (n % 1 !=0 )
                    {
                        if (n >= 0 )
                        {
                            sumpol += n;
                        }
                        else
                        {
                            sumotr += n;
                        }

                    }
                    res = Math.Abs(sumpol - sumotr);
                }
            }
            return res;
        }
    }
}
