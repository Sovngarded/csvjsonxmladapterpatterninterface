using System;
using System.Xml;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Classes
{
    public class XmlReader : IXmlReadable
    {
        private XmlTextReader xmlTextReader;

        private  string text="";
        public void LoadXml(string filename)
        {
            try
            {
                xmlTextReader = new XmlTextReader(filename);
                
                while (xmlTextReader.Read())
                {
                    switch (xmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            text+=" <" + xmlTextReader.Name + ">\n";
                            break;

                        case XmlNodeType.Text:
                            text+="\t"+ xmlTextReader.Value+"\n";
                            break;

                        case XmlNodeType.EndElement:
                            text+=" <"+ xmlTextReader.Name+"/>\n";
                            break;

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ShowData()
        {
            Console.WriteLine(text);
        }

    }
}
