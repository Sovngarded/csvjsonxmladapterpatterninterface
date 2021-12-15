using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Classes
{
    public class JsonReader : IJsonReadable
    {
        private string array;
        public void LoadJson(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();

                array = JsonConvert.DeserializeObject(json).ToString();
             
            }
        }


        public void ShowData()
        {
            Console.WriteLine(array);
        }
    }
}
