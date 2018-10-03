using ETH.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;


namespace ETH.Business
{

    public class ConvertService
    {
        public static T GetJsonRequest<T>(string requestUrl)
        {
            try
            {
                WebRequest apiRequest = WebRequest.Create(requestUrl);
                HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponse();

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    string jsonOutput;
                    using (StreamReader sr = new StreamReader(apiResponse.GetResponseStream()))
                        jsonOutput = sr.ReadToEnd();

                    var jsonResult = JsonConvert.DeserializeObject<T>(jsonOutput);


                    if (jsonResult != null)
                        return jsonResult;
                    else
                        return default(T);
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                // Log error here.

                return default(T);
            }
        }

        //public static T GetJsonData<T>(string url) where T : new()
        //{
        //    using (var w = new WebClient())
        //    {
        //        var json_data = string.Empty;

        //        try { json_data = w.DownloadString(url); }

        //        catch (Exception) { }

        //        return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();

        //    }
        //}



    }

}
