using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;

namespace JToken_Pratice2
{
    class JTokenPratice2
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("TestJson.json"))
            {
                string json = r.ReadToEnd();
                ReadJson(json);
            }
        }

        static void ReadJson(string jsonStr)
        {
            JObject jObject = JObject.Parse(jsonStr);

            foreach (var data in jObject["TestJson"])
            {
                JProperty jProperty = data.ToObject<JProperty>();

                switch(jProperty.Name)
                {
                    case "DataStr":
                        Debug.WriteLine(jProperty.Value); // Data
                        break;

                    case "DataInt":
                        Debug.WriteLine(jProperty.Value);
                        break;

                    case "DataArray":
                        foreach(var array in jProperty.Value)
                        {
                            Debug.WriteLine(array);
                        }
                        break;
                }
            }
        }
    }
}
