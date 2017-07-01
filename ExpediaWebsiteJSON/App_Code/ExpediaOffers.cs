using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// classes that define the flights information found in the API starting from RootBoject
/// </summary>


    public class OfferInfo
    {
        public string siteID { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
}

    public class Persona
    {
        public string personaType { get; set; }
    }

    public class UserInfo
{
    public Persona persona { get; set; }
    public string userId { get; set; }
}

    public class OfferDateRange
    {
        public List<int> travelStartDate { get; set; }
        public List<int> travelEndDate { get; set; }
        public int lengthOfStay { get; set; }
    }

    public class Destination
    {
        public string regionID { get; set; }
        public string longName { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
    }

    public class HotelInfo
    {
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public string hotelDestination { get; set; }
        public string hotelDestinationRegionID { get; set; }
        public string hotelLongDestination { get; set; }
        public string hotelStreetAddress { get; set; }
        public string hotelCity { get; set; }
        public string hotelProvince { get; set; }
        public string hotelCountryCode { get; set; }
        public string hotelLocation { get; set; }
        public double hotelLatitude { get; set; }
        public double hotelLongitude { get; set; }
        public string hotelStarRating { get; set; }
        public double hotelGuestReviewRating { get; set; }
        public string travelStartDate { get; set; }
        public string travelEndDate { get; set; }
        public string hotelImageUrl { get; set; }
        public double carPackageScore { get; set; }
        public string description { get; set; }
        public double distanceFromUser { get; set; }
        public string language { get; set; }
        public double movingAverageScore { get; set; }
        public double promotionAmount { get; set; }
        public string promotionDescription { get; set; }
        public string promotionTag { get; set; }
        public double rawAppealScore { get; set; }
        public double relevanceScore { get; set; }
        public string statusCode { get; set; }
        public string statusDescription { get; set; }
        public bool carPackage { get; set; }
        public bool allInclusive { get; set; }
    }

    public class HotelUrgencyInfo
    {
        public int airAttachRemainingTime { get; set; }
        public int numberOfPeopleViewing { get; set; }
        public int numberOfPeopleBooked { get; set; }
        public int numberOfRoomsLeft { get; set; }
        public object lastBookedTime { get; set; }
        public string almostSoldStatus { get; set; }
        public string link { get; set; }
        public List<object> almostSoldOutRoomTypeInfoCollection { get; set; }
        public bool airAttachEnabled { get; set; }
    }

    public class HotelPricingInfo
    {
        public double averagePriceValue { get; set; }
        public double totalPriceValue { get; set; }
        public string originalPricePerNight { get; set; }
        public double hotelTotalBaseRate { get; set; }
        public double hotelTotalTaxesAndFees { get; set; }
        public string currency { get; set; }
        public double hotelTotalMandatoryTaxesAndFees { get; set; }
        public double percentSavings { get; set; }
        public bool drr { get; set; }
    }

    public class HotelUrls
    {
        public string hotelInfositeUrl { get; set; }
        public string hotelSearchResultUrl { get; set; }
    }

    public class HotelScores
    {
        public double rawAppealScore { get; set; }
        public double movingAverageScore { get; set; }
    }

    public class Hotel
    {
        public OfferDateRange offerDateRange { get; set; }
        public Destination destination { get; set; }
        public HotelInfo hotelInfo { get; set; }
        public HotelUrgencyInfo hotelUrgencyInfo { get; set; }
        public HotelPricingInfo hotelPricingInfo { get; set; }
        public HotelUrls hotelUrls { get; set; }
        public HotelScores hotelScores { get; set; }
    }

    public class Offers
    {
        public List<Hotel> Hotel { get; set; }
    }

    public class RootObject
    {
        public OfferInfo offerInfo { get;set; }
        public UserInfo userInfo { get; set; }
        public Offers offers { get; set; }
    }

