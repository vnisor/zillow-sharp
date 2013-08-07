using System;
using System.Collections.Generic;
using System.Linq;
using ZillowSharp.Domain.Repositories;
using ZillowSharp.Domain.Entities;
using RestSharp;
using ZillowSharp.DTOs;
using ZillowSharp.Domain.Repositories.Exceptions;

namespace ZillowSharp.Persistence.ZillowAPI
{
    public class ZillowListingRepository : IListingRepository
    {
        private const string QUERY_STRING_FORMAT = "/{0}/listings.json?page={1}&limit={2}";
        private readonly string _apiKey;
        /// <summary>
        /// Initializes a new instance of the ZillowListingRepository class.
        /// </summary>
        public ZillowListingRepository(string apiKey)
        {
            _apiKey = apiKey;

            //TODO: move mappings out of ctor
            //Mapper.CreateMap<List<ListingJsonDTO>, List<Listing>>();
        }

        public IList<Listing> FindAll(int page, int limit)
        {
            var client = new RestClient() 
            { 
                BaseUrl = "https://api.rentalapp.zillow.com" 
            };

            var request = new RestRequest() 
            { 
                Resource = String.Format(QUERY_STRING_FORMAT, _apiKey, page, limit) 
            };

            var listingJsonResponse = client.Execute<ListingsJsonResponse>(request);

            if (listingJsonResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new ListingQueryFailure(request.Resource, listingJsonResponse.StatusCode.ToString());
            }

            if (listingJsonResponse.ErrorException != null)
            {
                throw new ListingQueryFailure(request.Resource, listingJsonResponse.StatusCode.ToString());
            }

            var listings = new List<Listing>();

            BindJsonResponse(listingJsonResponse, listings);

            return listings;
        }

        /// <summary>
        /// Binds the Json response to a List<Listing>
        /// </summary>
        /// <param name="listingJsonResponse"></param>
        /// <param name="listings"></param>
        private static void BindJsonResponse(IRestResponse<ListingsJsonResponse> listingJsonResponse, List<Listing> listings)
        {
            foreach (var item in listingJsonResponse.Data.Listings as List<ListingJsonDTO>)
            {
                listings.Add(new Listing.Builder()
                                {
                                    AccessInfo = item.AccessInfo,
                                    Address = item.Address,
                                    AgentEmail = item.AgentEmail,
                                    AgentName = item.AgentName,
                                    AgentPhone = item.AgentPhone,
                                    Attribution = item.Attribution,
                                    Bathrooms = item.Bathrooms,
                                    Bedrooms = item.Bedrooms,
                                    BedroomsDisplay = item.BedroomsDisplay,
                                    BuildingName = item.BuildingName,
                                    City = item.City,
                                    Contacts = item.Contacts.Select(x => new Contact()
                                                                    {
                                                                        Company = x.Company,
                                                                        Email = x.Email,
                                                                        Name = x.Name,
                                                                        Phone = x.Phone
                                                                    }).ToList<Contact>(),
                                    CrossStreet = item.CrossStreet,
                                    CurrentTenant = item.CurrentTenant,
                                    DateAvailable = item.DateAvailable,
                                    DateCreated = item.DateCreated,
                                    Deposit = item.Deposit,
                                    Description = item.Description,
                                    DisplayAddress = item.DisplayAddress,
                                    Featured = item.Featured,
                                    Features = item.Features,
                                    FeeDisplay = item.FeeDisplay,
                                    FeeDisplayAmount = item.FeeDisplayAmount,
                                    FeeMode = item.FeeMode,
                                    FloorNumber = item.FloorNumber,
                                    LastUpdated = item.LastUpdated,
                                    Latitude = item.Latitude,
                                    ListingType = item.ListingType,
                                    Longitude = item.Longitude,
                                    MlsNumber = item.MlsNumber,
                                    Neighborhoods = item.Neighborhoods.Select(x => new Neighborhood()
                                    {
                                        Name = x.ToString()
                                    }).ToList<Neighborhood>(),
                                    OpenHouses = item.OpenHouses.Select(x => new OpenHouse()
                                    {
                                        Agent = x.Agent,
                                        Date = x.Date,
                                        Email = x.Email,
                                        EndTime = x.EndTime,
                                        MobilePhone = x.MobilePhone,
                                        Notes = x.Notes,
                                        OfficePhone = x.OfficePhone,
                                        StartTime = x.StartTime
                                    }).ToList<OpenHouse>(),
                                    ParkingSpaces = item.ParkingSpaces,
                                    ParkingSpaceType = item.ParkingSpaceType,
                                    Photos = item.Photos.Select(x => new Photo()
                                    {
                                        FullSizeUrl = x.FullSizeUrl,
                                        MainPhoto = x.MainPhoto,
                                        SortOrder = x.SortOrder,
                                        ThumbnailUrl = x.ThumbnailUrl
                                    }).ToList<Photo>(),
                                    PropertyType = item.PropertyType,
                                    ReceivedDescription = item.ReceivedDescription,
                                    Rent = item.Rent,
                                    RentalTerms = item.RentalTerms,
                                    RentJuiceId = item.RentJuiceId,
                                    SharedNotes = item.SharedNotes,
                                    SourceName = item.SourceName,
                                    SourceType = item.SourceType,
                                    SquareFootage = item.SquareFootage,
                                    State = item.State,
                                    Status = item.Status,
                                    Street = item.Street,
                                    StreetNumber = item.StreetNumber,
                                    TenantFee = item.TenantFee,
                                    TenantFeeDisplayAmount = item.TenantFeeDisplayAmount,
                                    TenantFeeMode = item.TenantFeeMode,
                                    Title = item.Title,
                                    UnitNumber = item.UnitNumber,
                                    Url = item.Url,
                                    ZipCode = item.ZipCode
                                }.Build());
            }
        }
    }
}
