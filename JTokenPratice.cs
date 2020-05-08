using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JToken_Pratice1
{
    class JTokenPratice
    {
        static void Main()
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
            JToken jToken = jObject["TestJson"];

            string dataStr = jToken.Value<string>("DataStr");
            // dataStr = "Data"
            Debug.WriteLine(dataStr);

            int? dataInt = jToken.Value<int?>("DataInt");
            // dataInt = 100;
            Debug.WriteLine(dataInt);

            string[] dataArray = jToken.Value<JArray>("DataArray").Values<string>().ToArray();
            // dataArray[0] = "Array1", dataArray[1] = "Array2", dataArray[2] = "Array3"
            foreach (var data in dataArray)
            {
                Debug.WriteLine(data);
            }
        }
    }
}
