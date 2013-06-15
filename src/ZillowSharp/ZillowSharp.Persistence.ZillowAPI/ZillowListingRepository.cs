using System;
using System.Collections.Generic;
using System.Linq;
using ZillowSharp.Domain.Repositories;
using ZillowSharp.Domain.Entities;
using RestSharp;

namespace ZillowSharp.Persistence.ZillowAPI
{
    public class ZillowListingRepository : IListingRepository
    {
        private readonly string _apiKey;
        /// <summary>
        /// Initializes a new instance of the ZillowListingRepository class.
        /// </summary>
        public ZillowListingRepository(string apiKey)
        {
            _apiKey = apiKey;       
        }

        public IList<Listing> FindAll()
        {
            var client = new RestClient();

            client.BaseUrl = "http://http://api.rentalapp.zillow.com";
            

            var request = new RestRequest();
            request.Resource = String.Format("{0}/listing.json", _apiKey);

            var response = client.Execute<List<Listing>>(request);

            return response.Data;
        }
    }
}
