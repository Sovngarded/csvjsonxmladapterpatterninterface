using System;
using System.Collections.Generic;
using System.Text;

namespace XmlJsonAdapter.Abstractions
{
    public interface ICsvReadable
    {
        public void LoadCsv(string filename);
        public void ShowData();
    }
}
