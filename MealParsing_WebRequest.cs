using HtmlAgilityPack;
using Meal.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Meal
{
    class MealProgram
    {
        const string serverUrl = "https://open.neis.go.kr/hub/mealServiceDietInfo";
        const string API_URL = "https://open.neis.go.kr/hub/mealServiceDietInfo?ATPT_OFCDC_SC_CODE=D10&SD_SCHUL_CODE=7240393";
        
        static Manager manager = new Manager();

        static void Main()
        {
            // string webClientResult = callWebClient();
            string webRequestResult = callWebRequest();
            // DoLoadData();
        }

        public static async void DoLoadData()
        {
            // await LoadMealDataAsync();
        }

        //public static async Task<TResponse<MealServiceDietInfo>> LoadMealDataAsync()
        //{
        //    var resp = await manager.GetResponse<MealServiceDietInfo>(serverUrl, API_URL, RestSharp.Method.GET);
        //    return resp;
        //}
        

        public static string callWebClient()
        {
            string result = string.Empty;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers["Content-Type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;

                using (Stream data = webClient.OpenRead(API_URL))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string json = reader.ReadToEnd();
                        result = json;
                        ReadJson(json);
                    }
                }
                ReadJson(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        static void ReadJson(string jsonStr)
        {
            JObject jObject = JObject.Parse(jsonStr);
            Console.WriteLine(jObject["mealServiceDietInfo"][1]["row"][0]["DDISH_NM"].ToString());

            Debug.WriteLine(jObject["mealServiceDietInfo"].ToString());

            MealInfo  mealInfo = JsonConvert.DeserializeObject<MealInfo>(jObject.ToString());
            Debug.WriteLine(mealInfo);
        }

        public static string callWebRequest()
        {
            string result = string.Empty;

            try
            {

                WebRequest request = WebRequest.Create(API_URL);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    string json = reader.ReadToEnd();
                    result = json;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        }

    }
}
