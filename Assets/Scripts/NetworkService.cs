using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NetworkService{
//     private const string xmlApi = "http://api.openweathermap.org/data/2.5/weather?q=Chicago,us&mode=xml&APPID=c786416c5c8473cebeddee63c3c461a0";

//     private IEnumerator CallAPI(string url, Action<string> callback) {
//         using (UnityWebRequest request = UnityWebRequest.Get(url)) {
//             yield return request.Send();

//             if(request.isNetworkError) {
//                 Debug.LogError("network problem: " + request.error);
//             }

//             else if (request.responseCode != (long)System.Net.HttpStatusCode.OK) {
//                 Debug.LogError("response error: " + request.responseCode);
//             }

//             else {
//                 callback(request.downloadHandler.text);
//             }

//             IEnumerator GetWeatherXML(Action<string> callback) {
//                 return CallAPI(xmlApi, callback);
//             }
//         }
//     }
}
