using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary
{
    public interface IApiConnection
    {
        /// <summary>
        /// Calls a GET request to the API to return data from the method provided.
        /// </summary>
        /// <typeparam name="T">Type of object for the JSON to convert into</typeparam>
        /// <param name="apiMethodName">Name of the method called in the API</param>
        /// <param name="pathParameters">List of optional path parameters to pass</param>
        /// <returns>An object converted from JSON by the API</returns>
        Task<T> RequestGet<T>(string apiMethodName, params string[] pathParameters);

        /// <summary>
        /// Calls a POST request to the API to send data to the API and return data from the method provided
        /// </summary>
        /// <typeparam name="T">Type of object for the JSON to convert into</typeparam>
        /// <param name="apiMethodName">Name of the method called in the API</param>
        /// <param name="objectToPost">An object that will be converted into JSON to use in the API method</param>
        /// <returns>An object converted from JSON by the API</returns>
        Task<T> RequestPost<T>(string apiMethodName, object objectToPost);

        /// <summary>
        /// Calls a GET request to the API to return a response from the server. Should only be used for quick ping-like requests.
        /// </summary>
        /// <param name="apiMethodName">Name of the method called in the API</param>
        /// <returns>An HTTP request from the API</returns>
        Task<HttpResponseMessage> RequestGetResponse(string apiMethodName);

        /// <summary>
        /// Calls a POST request to the API to return response from the server.
        /// </summary>
        /// <param name="apiMethodName">Name of the method called in the API</param>
        /// <param name="objectToPost">An object that will be converted into JSON to use in the API method</param>
        /// <returns>An HTTP request from the API</returns>
        Task<HttpResponseMessage> RequestPostResponse(string apiMethodName, object objectToPost);
    }
}
