using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using XmlJsonAdapter.Abstractions;
using XmlJsonAdapter.Classes;

namespace XmlJsonAdapter.Adapters
{
    public class JsonToCsvAdapter : ICsvReadable
    {
        private IJsonReadable _json;
        public JsonToCsvAdapter(IJsonReadable json)
        {
           _json = json;
        }


        public void LoadCsv(string filename)
        {
            _json.LoadJson(filename);
        }
        public void ShowData()
        {
            _json.ShowData();
        }
    }
}
