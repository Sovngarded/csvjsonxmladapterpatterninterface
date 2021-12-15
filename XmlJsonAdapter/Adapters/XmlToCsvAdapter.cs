using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Adapters
{
    public class XmlToCsvAdapter : ICsvReadable
    {
        private IXmlReadable _xml;

        public XmlToCsvAdapter(IXmlReadable xml)
        {
            _xml = xml;
        }
        public void LoadCsv(string filename)
        {
            _xml.LoadXml(filename);
        }
        public void ShowData()
        {
           _xml.ShowData();
        }

    }
}
