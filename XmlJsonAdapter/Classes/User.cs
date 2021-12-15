using System;
using System.Collections.Generic;
using System.Text;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Classes
{
    public class User
    {
        public void ManageFile(ICsvReadable reader,string filename)
        {
            reader.LoadCsv(filename);
            reader.ShowData();
        }
    }
}
