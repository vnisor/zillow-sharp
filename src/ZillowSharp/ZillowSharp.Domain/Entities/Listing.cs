using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.Domain.Entities
{
    public class Listing
    {
        public string RentJuiceId { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AgentName { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhone { get; set; }
        public bool Featured { get; set; }
        public string Address { get; set; }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string UnitNumber { get; set; }
        public bool DisplayAddress { get; set; }
        public string CrossStreet { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Neighborhoods { get; set; }
        public string FloorNumber { get; set; }
        public string PropertyType { get; set; }
        public int Rent { get; set; }
        public int Deposit { get; set; }
        public string FeeMode { get; set; }
        public string FeeDisplay { get; set; }
        public string FeeDisplayAmount { get; set; }
        public string TenantFee { get; set; }
        public string TenantFeeDisplayAmount { get; set; }
        public string TenantFeeMode { get; set; }
        public int Bedrooms { get; set; }
        public string BedroomsDisplay { get; set; }
        public int Bathrooms { get; set; }
        public int SquareFootage { get; set; }
        public string Features { get; set; }
        public string RentalTerms { get; set; }
        public DateTime DateAvailable { get; set; }
        public DateTime DateCreated { get; set; }
        public int ParkingSpaces { get; set; }
        public string ParkingSpaceType { get; set; }
        public string AccessInfo { get; set; }
        public string CurrentTenant { get; set; }
        public string BuildingName { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ListingType { get; set; }
        public string ReceivedDescription { get; set; }
        public string SourceType { get; set; }
        public string SourceName { get; set; }
        public string Attribution { get; set; }
        public string MlsNumber { get; set; }
        public IList<Photo> Photos { get; set; }
        public IList<OpenHouse> OpenHouses { get; set; }
        public string Url { get; set; }
        public string SharedNotes { get; set; }
        public IList<Contact> Contacts { get; set; }
    }
}
