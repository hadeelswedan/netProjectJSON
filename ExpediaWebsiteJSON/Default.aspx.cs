using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OnPageLoad();
        }
    }

    //get all offers filtered by destination country
    protected void searchFlights_Click(object sender, EventArgs e)
    {
        string DestinationSelected = ddlRegions.SelectedValue;
        List<Hotel> Hotels = GetOffers();

        gvFlights.DataSource = Hotels.Where(h => h.destination.country == DestinationSelected);
        gvFlights.DataBind();
    }

    //when selecting new value from the drop down list
    protected void ddlRegions_SelectedIndexChanged(object sender, EventArgs e)
    {
        string DestinationSelected = ddlRegions.SelectedValue;
    }

    //To show all offers available
    protected void ShowAll_Click(object sender, EventArgs e)
    {
        gvFlights.DataSource = GetOffers();
        gvFlights.DataBind();
    }

    #region PrivateMethods
    //Get all offers from the API and return them
    private List<Hotel> GetOffers()
    {
        WebClient Client = new WebClient();
        string Value = Client.DownloadString("https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel");
        RootObject Offers = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<RootObject>(Value);
        List<Hotel> Hotels = Offers.offers.Hotel;

        return Hotels;
    }

    //OnPageLoad :1.get all offers 2.fill drop down list
    private void OnPageLoad()
    {
        UnitTest _UnitTest = new UnitTest();

        List<Hotel> Hotels = GetOffers();
        List<Destination> Destinations = new List<Destination>();

        for (int i = 0; i < Hotels.Count; i++)
        {
            Destinations.Add(Hotels[i].destination);
        }
        var Result = Destinations.GroupBy(p => p.country).Select(g => g.First());

        foreach (var destination in Result)
        {
            ddlRegions.Items.Add(destination.country);
        }
        gvFlights.DataSource = Hotels;
        gvFlights.DataBind();
    }
    #endregion

}