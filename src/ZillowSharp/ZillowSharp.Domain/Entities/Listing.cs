using System;
using System.Collections.Generic;
using System.Linq;

namespace ZillowSharp.Domain.Entities
{
    public class Listing : IEntity
    {
        #region ctor

        private Listing() { }

        #endregion

        #region Properties

        public string AccessInfo { get; private set; }

        public string Address { get; private set; }

        public string AgentEmail { get; private set; }

        public string AgentName { get; private set; }

        public string AgentPhone { get; private set; }

        public string Attribution { get; private set; }

        public double? Bathrooms { get; private set; }

        public double? Bedrooms { get; private set; }

        public string BedroomsDisplay { get; private set; }

        public string BuildingName { get; private set; }

        public string City { get; private set; }

        public IList<Contact> Contacts { get; private set; }

        public string CrossStreet { get; private set; }

        public string CurrentTenant { get; private set; }

        public DateTime? DateAvailable { get; private set; }

        public DateTime? DateCreated { get; private set; }

        public int? Deposit { get; private set; }

        public string Description { get; private set; }

        public string DisplayAddress { get; private set; }

        public string Featured { get; private set; }

        public string Features { get; private set; }

        public string FeeDisplay { get; private set; }

        public string FeeDisplayAmount { get; private set; }

        public string FeeMode { get; private set; }

        public string FloorNumber { get; private set; }

        public DateTime? LastUpdated { get; private set; }

        public double? Latitude { get; private set; }

        public string ListingType { get; private set; }

        public double? Longitude { get; private set; }

        public string MlsNumber { get; private set; }

        public IList<Neighborhood> Neighborhoods { get; private set; }

        public IList<OpenHouse> OpenHouses { get; private set; }

        public int? ParkingSpaces { get; private set; }

        public string ParkingSpaceType { get; private set; }

        public IList<Photo> Photos { get; private set; }

        public string PropertyType { get; private set; }

        public string ReceivedDescription { get; private set; }

        public int? Rent { get; private set; }

        public string RentalTerms { get; private set; }

        public string RentJuiceId { get; private set; }

        public string SharedNotes { get; private set; }

        public string SourceName { get; private set; }

        public string SourceType { get; private set; }

        public int? SquareFootage { get; private set; }

        public string State { get; private set; }

        public string Status { get; private set; }

        public string Street { get; private set; }

        public string StreetNumber { get; private set; }

        public string TenantFee { get; private set; }

        public string TenantFeeDisplayAmount { get; private set; }

        public string TenantFeeMode { get; private set; }

        public string Title { get; private set; }

        public string UnitNumber { get; private set; }

        public string Url { get; private set; }

        public string ZipCode { get; private set; }

        #endregion

        public sealed class Builder
        {
            private Listing listing = new Listing();

            public string AccessInfo 
            {
                get { return listing.AccessInfo; }
                set { listing.AccessInfo = value; }
            }

            public string Address 
            {
                get { return listing.Address; }
                set { listing.Address = value; } 
            }

            public string AgentEmail 
            {
                get { return listing.AgentEmail; }
                set { listing.AgentEmail = value; }
            }

            public string AgentName 
            {
                get { return listing.AgentName; }
                set { listing.AgentName = value; }
            }

            public string AgentPhone 
            {
                get { return listing.AgentPhone; }
                set { listing.AgentPhone = value; }
            }

            public string Attribution 
            {
                get { return listing.Attribution; }
                set { listing.Attribution = value; }
            }

            public double? Bathrooms 
            {
                get { return listing.Bathrooms; }
                set { listing.Bathrooms = value; }
            }

            public double? Bedrooms
            {
                get { return listing.Bedrooms; }
                set { listing.Bedrooms = value; }
            }

            public string BedroomsDisplay
            {
                get { return listing.BedroomsDisplay; }
                set { listing.BedroomsDisplay = value; }
            }

            public string BuildingName 
            {
                get { return listing.BuildingName; }
                set { listing.BuildingName = value; }
            }

            public string City 
            {
                get { return listing.City; }
                set { listing.City = value; }
            }

            public IList<Contact> Contacts 
            {
                get { return listing.Contacts; }
                set { listing.Contacts = value; }
            }

            public string CrossStreet 
            {
                get { return listing.CrossStreet; }
                set { listing.CrossStreet = value; }
            }

            public string CurrentTenant 
            {
                get { return listing.CurrentTenant; }
                set { listing.CurrentTenant = value; }
            }

            public DateTime? DateAvailable 
            {
                get { return listing.DateAvailable; }
                set { listing.DateAvailable = value; }
            }

            public DateTime? DateCreated 
            {
                get { return listing.DateCreated; }
                set { listing.DateCreated = value; }
            }

            public int? Deposit 
            {
                get { return listing.Deposit; }
                set { listing.Deposit = value; }
            }

            public string Description 
            {
                get { return listing.Description; }
                set { listing.Description = value; }
            }

            public string DisplayAddress
            {
                get { return listing.DisplayAddress; }
                set { listing.DisplayAddress = value; }
            }

            public string Featured 
            {
                get { return listing.Featured; }
                set { listing.Featured = value; }
            }

            public string Features 
            {
                get { return listing.Features; }
                set { listing.Features = value; }
            }

            public string FeeDisplay 
            {
                get { return listing.FeeDisplay; }
                set { listing.FeeDisplay = value; }
            }

            public string FeeDisplayAmount 
            {
                get { return listing.FeeDisplayAmount; }
                set { listing.FeeDisplay = value; }
            }

            public string FeeMode 
            {
                get { return listing.FeeMode; }
                set { listing.FeeMode = value; }
            }

            public string FloorNumber 
            {
                get { return listing.FloorNumber; }
                set { listing.FloorNumber = value; }
            }

            public DateTime? LastUpdated 
            {
                get { return listing.LastUpdated; }
                set { listing.LastUpdated = value; }
            }

            public double? Latitude 
            {
                get { return listing.Latitude; }
                set { listing.Latitude = value; }
            }

            public string ListingType 
            {
                get { return listing.ListingType; }
                set { listing.ListingType = value; }
            }

            public double? Longitude 
            {
                get { return listing.Longitude; }
                set { listing.Longitude = value; }
            }

            public string MlsNumber 
            {
                get { return listing.MlsNumber; }
                set { listing.MlsNumber = value; }
            }

            public IList<Neighborhood> Neighborhoods 
            {
                get { return listing.Neighborhoods; }
                set { listing.Neighborhoods = Neighborhoods; }
            }

            public IList<OpenHouse> OpenHouses 
            {
                get { return listing.OpenHouses; }
                set { listing.OpenHouses = value; }
            }

            public int? ParkingSpaces 
            {
                get { return listing.ParkingSpaces; }
                set { listing.ParkingSpaces = value; }
            }

            public string ParkingSpaceType 
            {
                get { return listing.ParkingSpaceType; }
                set { listing.ParkingSpaceType = value; }
            }

            public IList<Photo> Photos
            {
                get { return listing.Photos; }
                set { listing.Photos = value; }
            }

            public string PropertyType 
            {
                get { return listing.PropertyType; }
                set { listing.PropertyType = value; }
            }

            public string ReceivedDescription
            {
                get { return listing.ReceivedDescription; }
                set { listing.ReceivedDescription = value; }
            }

            public int? Rent 
            {
                get { return listing.Rent; }
                set { listing.Rent = value; }
            }

            public string RentalTerms 
            {
                get { return listing.RentalTerms; }
                set { listing.RentalTerms = value; }
            }

            public string RentJuiceId 
            {
                get { return listing.RentJuiceId; }
                set { listing.RentJuiceId = value; }
            }

            public string SharedNotes 
            {
                get { return listing.SharedNotes; }
                set { listing.SharedNotes = value; }
            }

            public string SourceName
            {
                get { return listing.SourceName; }
                set { listing.SourceName = value; }
            }

            public string SourceType
            {
                get { return listing.SourceType; }
                set { listing.SourceType = value; }

            }

            public int? SquareFootage
            {
                get { return listing.SquareFootage; }
                set { listing.SquareFootage = value; }
            }

            public string State
            {
                get { return listing.State; }
                set { listing.State = value; }
            }

            public string Status
            {
                get { return listing.Status; }
                set { listing.Status = value; }
            }

            public string Street 
            {
                get { return listing.Street; }
                set { listing.Street = value; }
            }

            public string StreetNumber
            {
                get { return listing.StreetNumber; }
                set { listing.StreetNumber = value; }
            }

            public string TenantFee
            {
                get { return listing.TenantFee; }
                set { listing.TenantFee = value; }
            }

            public string TenantFeeDisplayAmount
            {
                get { return listing.TenantFeeDisplayAmount; }
                set { listing.TenantFeeDisplayAmount = value; }
            }

            public string TenantFeeMode
            {
                get { return listing.TenantFeeMode; }
                set { listing.TenantFeeMode = value; }
            }

            public string Title 
            {
                get { return listing.Title; }
                set { listing.Title = value; }
            }

            public string UnitNumber 
            {
                get { return listing.UnitNumber; }
                set { listing.UnitNumber = value; }
            }

            public string Url
            {
                get { return listing.Url; }
                set { listing.Url = value; }
            }

            public string ZipCode
            {
                get { return listing.ZipCode; }
                set { listing.ZipCode = value; }
            }

            public Listing Build()
            {
                Listing ret = listing;
                listing = null;
                return ret;
            }
        }
    }
}
