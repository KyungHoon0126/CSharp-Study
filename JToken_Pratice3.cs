using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;

namespace JToken_Pratice3
{
    class JToken_Pratice3
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
            TestJson testJson = JsonConvert.DeserializeObject<TestJson>(jObject["TestJson"].ToString());

            Debug.WriteLine(testJson.DataStr);
            Debug.WriteLine(testJson.DataInt);
            foreach(var data in testJson.DataArray)
            {
                Debug.WriteLine(data);
            }
        }
    }
}
