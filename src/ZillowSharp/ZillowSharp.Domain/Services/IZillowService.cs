using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZillowSharp.Domain.Entities;
using ZillowSharp.Domain.Factories;
using System.Net;
using System.Net.Http;
using ZillowSharp.Domain.Commands;

namespace ZillowSharp.Domain.Services
{
    public interface IZillowService
    {
        /// <summary>
        /// Allows the caller to change the default HttpWebRequestFactory if required
        /// </summary>
        IHttpWebRequestFactory HttpWebRequestFactory { get; set; }

        /// <summary>
        /// Creates a Zillow resource url for a particular action
        /// </summary>
        /// <param name="action"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        string BuildUrl(string action, params object[] args);

        /// <summary>
        /// Makes the http request for the given url and deserializes the response.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        T InvokeRequest<T>(string url) where T : class, IEntity;

        /// <summary>
        /// Makes the http request for the given url and uses the method passed in.  Also
        /// deserializes the response.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="httpMethod"></param>
        /// <param name="entityToSend"></param>
        /// <returns></returns>
        T InvokeRequest<T>(string url, HttpMethod httpMethod, T entityToSend) where T : class, IEntity;

        /// <summary>
        /// Executes a Zillow find command on this service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        T Execute<T>(IZillowFindCommand<T> command);

        /// <summary>
        /// Executes a Zillow change command on this service.
        /// </summary>
        /// <param name="command"></param>
        void Execute(IZillowChangeCommand command);
    }
}
