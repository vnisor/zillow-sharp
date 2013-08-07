using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.Domain.Repositories.Exceptions
{
    /// <summary>
    /// Represents a failure the retreive results from 
    /// an API resource.
    /// </summary>
    public class ListingQueryFailure : Exception
    {
        private readonly string _apiResource;
        private readonly string _statusCode;
        
        /// <summary>
        /// Initializes a new instance of the ListingQueryFailure class.
        /// </summary>
        public ListingQueryFailure(string apiResource, string statusCode)
        {    
            _apiResource = apiResource;
            _statusCode = statusCode;
        }

        public override string Message
        {
            get
            {
                return String.Format("Failed to fetch Zillow results using API resource {0}.  The server return status code {1}", 
                                        _apiResource, _statusCode);
            }
        }
    }
}
