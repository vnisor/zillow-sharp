using System;
using System.Collections.Generic;
using System.Linq;
using ZillowSharp.Domain.Services;
using ZillowSharp.Domain.Factories;
using ZillowSharp.Core;

namespace ZillowSharp.Infrastructure
{
    public class JsonZillowService : IZillowService
    {

        private readonly bool ssl;
        private readonly string key;

        public IHttpWebRequestFactory HttpWebRequestFactory { get; set; }

        public string BuildUrl(string action, params object[] args)
        {
            Validate.NotNull(action);

            String searchCriteria;

            if (args != null && args.Length > 0)
                searchCriteria = string.Format(action, args);
            else
                searchCriteria = string.Empty;

            string protocol = ssl ? "https" : "http";

            return string.Format("{0}://api.rentallapp.zillow.com/{1}/{2}.json?{3}",
                    protocol,
                    key,
                    action,
                    searchCriteria
                    );
        }

        public T InvokeRequest<T>(string url) where T : class, Domain.Entities.IEntity
        {
            throw new NotImplementedException();
        }

        public T InvokeRequest<T>(string url, System.Net.Http.HttpMethod httpMethod, T entityToSend) where T : class, Domain.Entities.IEntity
        {
            throw new NotImplementedException();
        }

        public T Execute<T>(Domain.Commands.IZillowFindCommand<T> command)
        {
            throw new NotImplementedException();
        }

        public void Execute(Domain.Commands.IZillowChangeCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
