using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolVA.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != 'П') && (line[i] != 'р') && (line[i] != 'и') && (line[i] != 'в') && (line[i] != 'е') && (line[i] != 'т') && (line[i] != 'м') && (line[i] != 'о') && (line[i] != 'я') && (line[i] != 'а') && (line[i] != 'п') && (line[i] != 'г'))
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;

        }
    }
}
        
    


