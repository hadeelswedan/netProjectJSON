<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="jumbotron">
        <h1>Expedia</h1>

        <h2>Search for your flight:</h2>
        <p>Destination Country:</p>

        <div>

        <asp:DropDownList runat="server" ID="ddlRegions" Width="100px"
            AutoPostBack="True" OnSelectedIndexChanged="ddlRegions_SelectedIndexChanged">
        </asp:DropDownList>

        </div>
        <asp:Button ID="searchFlights" OnClick="searchFlights_Click" runat="server" Text="Search" Width="100px"></asp:Button>
        <asp:Button ID="ShowAll" runat="server" OnClick="ShowAll_Click" Text="Show all" Width="100px" />

    </div>

    <div class="row" aria-sort="ascending" aria-setsize="10" style="list-style-type: disc">
        <div class="col-md-4">
            <asp:Label Text="Flight schedule list:" runat="server" ForeColor="Black">
            </asp:Label>
        </div>
    </div>

    <asp:GridView ID="gvFlights" runat="server" AutoGenerateColumns="false" ShowHeader="False">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table>
                        <tr style="color: darkgray">
                            <th>Destination:</th>
                            <th>Hotel Photo:</th>
                            <th>HotelInfo:</th>
                            <th>Hotel Pricing Info:</th>
                        </tr>
                        <tr>
                            <td width="200px">
                                <table>
                                    <tr>
                                        <td>
                                            <b>country:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblCountry" runat="server" Text='<%#Eval("destination.country") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>City:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblCity" runat="server" Text='<%#Eval("destination.city") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="200px">
                                <image src='<%#Eval("hotelInfo.hotelImageUrl") %>' style="width: 100px; height: 100px;"></image>
                            </td>
                            <td width="400px">
                                <table>
                                    <tr>
                                        <td>
                                            <b>Hotel Name:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblHotelName" runat="server" Text='<%#Eval("hotelInfo.hotelName") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Hotel City:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblHotelCity" runat="server" Text='<%#Eval("hotelInfo.hotelCity") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Hotel Location:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblHotelLocation" runat="server" Text='<%#Eval("hotelInfo.hotelLocation") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Travel Start Date:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblTravelStartDate" runat="server" Text='<%#Eval("hotelInfo.travelStartDate") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Travel End Date:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblTravelEndDate" runat="server" Text='<%#Eval("hotelInfo.travelEndDate") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="400px">
                                <table>
                                    <tr>
                                        <td>
                                            <b>Total Price Value:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblTotalPriceValue" runat="server" Text='<%#Eval("hotelPricingInfo.totalPriceValue") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Original Price Per Night:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblOriginalPricePerNight" runat="server" Text='<%#Eval("hotelPricingInfo.originalPricePerNight") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Hotel Total Taxes And Fees:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblHotelTotalTaxesAndFees" runat="server" Text='<%#Eval("hotelPricingInfo.hotelTotalTaxesAndFees") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <b>Currency:</b>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblCurrency" runat="server" Text='<%#Eval("hotelPricingInfo.currency") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

