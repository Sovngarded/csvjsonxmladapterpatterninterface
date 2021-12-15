using System;
using XmlJsonAdapter.Abstractions;
using XmlJsonAdapter.Adapters;
using XmlJsonAdapter.Classes;

namespace XmlJsonAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            BookShop bookShop = new BookShop();
            user.ManageFile(bookShop, "book.csv");



            JsonReader jsonReader = new JsonReader();
            ICsvReadable adapterJson = new JsonToCsvAdapter(jsonReader);
            user.ManageFile(adapterJson, "book.json");

            XmlReader xmlReader = new XmlReader();
            ICsvReadable adapterXml = new XmlToCsvAdapter(xmlReader);
            user.ManageFile(adapterXml, "book.xml");

        }
    }
}
