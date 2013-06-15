using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ZillowSharp.DTOs
{
    public class ListingJsonDTO
    {
        #region Properties

        [DataMember(Name = "access_info")]
        public string AccessInfo { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "agent_email")]
        public string AgentEmail { get; set; }

        [DataMember(Name = "agent_name")]
        public string AgentName { get; set; }

        [DataMember(Name = "agent_phone")]
        public string AgentPhone { get; set; }

        [DataMember(Name = "attribution")]
        public string Attribution { get; set; }

        [DataMember(Name = "bathrooms")]
        public int Bathrooms { get; set; }

        [DataMember(Name = "bedrooms")]
        public int Bedrooms { get; set; }

        [DataMember(Name = "bedrooms_display")]
        public string BedroomsDisplay { get; set; }

        [DataMember(Name = "building_name")]
        public string BuildingName { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "contacts")]
        public IList<ContactJsonDTO> Contacts { get; set; }

        [DataMember(Name = "cross_street")]
        public string CrossStreet { get; set; }

        [DataMember(Name = "current_tenant")]
        public string CurrentTenant { get; set; }

        [DataMember(Name = "date_available")]
        public DateTime DateAvailable { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "deposit")]
        public int Deposit { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "agent_email")]
        public bool DisplayAddress { get; set; }

        [DataMember(Name = "featured")]
        public bool Featured { get; set; }

        [DataMember(Name = "features")]
        public string Features { get; set; }

        [DataMember(Name = "fee_display_amount")]
        public string FeeDisplayAmount { get; set; }

        [DataMember(Name = "fee_display")]
        public string FeeDisplay { get; set; }

        [DataMember(Name = "fee_mode")]
        public string FeeMode { get; set; }

        [DataMember(Name = "floor_number")]
        public string FloorNumber { get; set; }

        [DataMember(Name = "last_updated")]
        public DateTime LastUpdated { get; set; }

        [DataMember(Name = "latitue")]
        public double Latitude { get; set; }

        [DataMember(Name = "listing_type")]
        public string ListingType { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        [DataMember(Name = "mls_number")]
        public string MlsNumber { get; set; }

        [DataMember(Name = "neighborhoods")]
        public IList<NeighborhoodJsonDTO> Neighborhoods { get; set; }

        [DataMember(Name = "open_houses")]
        public IList<OpenHouseJsonDTO> OpenHouses { get; set; }

        [DataMember(Name = "parking_spaces")]
        public int ParkingSpaces { get; set; }

        [DataMember(Name = "parking_space_type")]
        public string ParkingSpaceType { get; set; }

        [DataMember(Name = "photos")]
        public IList<PhotoJsonDTO> Photos { get; set; }

        [DataMember(Name = "property_type")]
        public string PropertyType { get; set; }

        [DataMember(Name = "received_description")]
        public string ReceivedDescription { get; set; }

        [DataMember(Name = "rent")]
        public int Rent { get; set; }

        [DataMember(Name = "rental_terms")]
        public string RentalTerms { get; set; }

        [DataMember(Name = "rentjuice_id")]
        public string RentJuiceId { get; set; }

        [DataMember(Name = "shared_notes")]
        public string SharedNotes { get; set; }

        [DataMember(Name = "source_name")]
        public string SourceName { get; set; }

        [DataMember(Name = "source_type")]
        public string SourceType { get; set; }

        [DataMember(Name = "square_footage")]
        public int SquareFootage { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "street")]
        public string Street { get; set; }

        [DataMember(Name = "street_number")]
        public string StreetNumber { get; set; }

        [DataMember(Name = "tenant_fee")]
        public string TenantFee { get; set; }

        [DataMember(Name = "tenant_fee_display_amount")]
        public string TenantFeeDisplayAmount { get; set; }

        [DataMember(Name = "tenant_fee_mode")]
        public string TenantFeeMode { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "unit_number")]
        public string UnitNumber { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "zip_code")]
        public string ZipCode { get; set; }

        #endregion

    }
}
