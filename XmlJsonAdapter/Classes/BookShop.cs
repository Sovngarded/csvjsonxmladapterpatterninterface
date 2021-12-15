using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XmlJsonAdapter.Abstractions;
using Microsoft.VisualBasic.FileIO;

namespace XmlJsonAdapter.Classes
{
    class BookShop : ICsvReadable
    {
        private string line;
        private StreamReader sr;
        public void LoadCsv(string fileName) {

            sr = new StreamReader(fileName);
            

        }
        public void ShowData(){
{
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] strCols = line.Split(';');
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            

        }

    }
}
