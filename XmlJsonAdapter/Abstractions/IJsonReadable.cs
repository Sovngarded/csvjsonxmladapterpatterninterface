using System;
using System.Collections.Generic;
using System.Text;

namespace XmlJsonAdapter.Abstractions
{
    public interface IJsonReadable
    {
        public void LoadJson(string filename);
        public void ShowData();
    }
}
