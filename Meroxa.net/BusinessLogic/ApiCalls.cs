using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Meroxa.net.helpers.BusinessLogic
{
    public class ApiCalls
    {
        public ApiCalls()
        {


        }
        private static string URL = "https://meroxa.domain.com/pipelinURl";


        public static dynamic CallMeroxa(string requestBody, string requestToken)
        {

            try
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                string requestUrl = URL + $"?ActionType=1&RequestBody={requestBody}";
                // Add an token to the header 
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Token", requestToken);

               
                HttpResponseMessage response = client.GetAsync(requestUrl).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var ApiResponse = response.Content;
                    return ApiResponse;

                }
                else
                {
                    //return a Meroxa obj response for the failure scenarios belo
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                client.Dispose();
                return null; 

            }
            catch (Exception ex)
            {
                //log error
                Console.Write(ex.ToString());
                return null;
            }
        }
    }
}
