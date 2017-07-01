using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// UnitTest Class used to test the API data returned when calling it 
/// 1. test the grid view data 
/// 2. test the drop down list - list of regions 
/// </summary>
public class UnitTest
{
    #region PublicMethods
    public UnitTest()
    {
        string GridViewResult = TestGridView();
        string DropDownListResult = TestDDLRegions();
        if (!(string.IsNullOrEmpty(GridViewResult)) || !(string.IsNullOrEmpty(DropDownListResult)))
        {
            MessageBox.Show(GridViewResult + " " + DropDownListResult);
        }
    }

    public string TestGridView()
    {
        List<Hotel> Hotels = GetOffers();

        if (Hotels.Count == 0)
            return "No offers exist";
        else
            return "";
    }

    public string TestDDLRegions()
    {
        List<Hotel> Hotels = GetOffers();
        List<Destination> Destinations = new List<Destination>();

        for (int i = 0; i < Hotels.Count; i++)
        {
            Destinations.Add(Hotels[i].destination);
        }
        var Result = Destinations.GroupBy(p => p.country).Select(g => g.First());

        if (Result.ToList().Count == 0)
            return "Empty drop down list";
        else
            return "";

    }
    #endregion

    #region PrivateMethods
    private List<Hotel> GetOffers()
    {
        WebClient Client = new WebClient();
        string Value = Client.DownloadString("https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel");
        RootObject Offers = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<RootObject>(Value);
        List<Hotel> Hotels = Offers.offers.Hotel;

        return Hotels;
    }
    #endregion
}