using System;
using System.Collections.Generic;
using System.Linq;
using ZillowSharp.Domain.Repositories;
using ZillowSharp.Domain.Entities;
using RestSharp;
using ZillowSharp.DTOs;
using AutoMapper;

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

        public IList<Listing> FindAll(int page, int limit)
        {
            var client = new RestClient();

            client.BaseUrl = "http://http://api.rentalapp.zillow.com";
            

            var request = new RestRequest();
            request.Resource = String.Format("{0}/listing.json?page={1}&limit={2}", _apiKey, page, limit);

            var listingJsonResponse = client.Execute<List<ListingJsonDTO>>(request);

            if (listingJsonResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //TODO: throw some sort of exception...
            }



            Mapper.CreateMap<List<Listing>, List<ListingJsonDTO>>();

            var listings = Mapper.Map<List<ListingJsonDTO>, List<Listing>>(listingJsonResponse.Data);

            return listings; //response.Data;
        }
    }
}
