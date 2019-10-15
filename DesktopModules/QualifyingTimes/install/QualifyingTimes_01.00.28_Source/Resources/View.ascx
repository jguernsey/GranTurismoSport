<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.QualifyingTimes.View" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>
    <script type="text/javascript">
        function PanelClick(sender, e) {
            var Messages = $get('<%=Messages.ClientID%>');
            Highlight(Messages);
        }

        function ActiveTabChanged(sender, e) {
            var CurrentTab = $get('<%=CurrentTab.ClientID%>');
            CurrentTab.innerHTML = sender.get_activeTab().get_headerText();
            Highlight(CurrentTab);
        }

        var HighlightAnimations = {};
        function Highlight(el) {
            if (HighlightAnimations[el.uniqueID] == null) {
                HighlightAnimations[el.uniqueID] = AjaxControlToolkit.Animation.createAnimation({
                    AnimationName: "color",
                    duration: 0.5,
                    property: "style",
                    propertyKey: "backgroundColor",
                    startValue: "#FFFF90",
                    endValue: "#FFFFFF"
                }, el);
            }
            HighlightAnimations[el.uniqueID].stop();
            HighlightAnimations[el.uniqueID].play();
        }

        function ToggleHidden(value) {
            $find('<%=Tabs.ClientID%>').get_tabs()[2].set_enabled(value);
        }
    </script>
<asp:Table runat="server" HorizontalAlign="Center" CssClass="gtsOuterTable" >
    <asp:TableRow>
        <asp:TableCell CssClass="gtsHeaderCell" >
            <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="Today's Races"></asp:Label>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell >
            <asp:GridView ID="dgvRaces" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                <Columns>
                    <asp:BoundField HeaderText="Race" DataField="Title" />
                    <asp:BoundField HeaderText="Category" DataField="CarCategory" />
                    <asp:BoundField HeaderText="Track" DataField="Track" />
                    <asp:BoundField HeaderText="Laps" DataField="Laps" />
                    <asp:BoundField HeaderText="No. Of Cars" DataField="NoOfCars" />
                    <asp:BoundField HeaderText="BOP" DataField="BalanceOfPower" />
                    <asp:BoundField HeaderText="Settings" DataField="CarSettings" />
                    <asp:BoundField HeaderText="Fuel" DataField="FuelConsumption" />
                    <asp:BoundField HeaderText="Tire Wear" DataField="TireWear" />
                    <asp:BoundField HeaderText="Lap (Km)" DataField="LapDistanceKm" />
                    <asp:BoundField HeaderText="Total (Km)" DataField="TotalDistanceKm" />
                    <asp:BoundField HeaderText="Tires" DataField="LimitTire" />
                    <asp:BoundField HeaderText="EventDetailId" Visible="false" DataField="EventDetailId" />
                    <asp:BoundField HeaderText="EventId" Visible="false" DataField="EventId" />
                    <asp:BoundField HeaderText="BoardId" Visible="false" DataField="BoardId" />
                </Columns>
            </asp:GridView>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <atk:TabContainer runat="server" ID="Tabs" OnClientActiveTabChanged="ActiveTabChanged" ActiveTabIndex="0" CssClass="ajaxTabs" EnableTheming="False" Width="100%" >
                <atk:TabPanel runat="server" ID="pnlRaceA" HeaderText="Daily Race A" >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="lblA" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label1" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionA" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldA" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlRaceB" HeaderText="Daily Race B"  >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label8" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label9" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionB" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldB" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlRaceC" HeaderText="Daily Race C"  >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label27" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label28" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlNations" HeaderText="Nations"  >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label46" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label47" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionN" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldN" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlManufacturers" HeaderText="Manufacturers"  >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label65" CssClass="gtsHeaderLabel" Text="Region" ></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label66" CssClass="gtsHeaderLabel" Text="World" ></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionM" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldM" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Rank" DataField="Rank" />
                                            <asp:BoundField HeaderText="Id" DataField="UserId" />
                                            <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                            <asp:BoundField HeaderText="Time" DataField="Score" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlMyTimes" HeaderText="Qualifying" >
                    <ContentTemplate>
                        <asp:Table runat="server" CssClass="gtsOuterTable">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label73" CssClass="gtsHeaderLabel" Text="Qualifying Times"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvTimes" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                        <Columns>
                                            <asp:BoundField HeaderText="Race" DataField="Race" />
                                            <asp:BoundField HeaderText="Region Rank" DataField="RegionRank" />
                                            <asp:BoundField HeaderText="Region Total" DataField="RegionTotal" />
                                            <asp:BoundField HeaderText="World Rank" DataField="WorldRank" />
                                            <asp:BoundField HeaderText="World Total" DataField="WorldTotal" />
                                            <asp:BoundField HeaderText="Time" DataField="Time" />
                                            <asp:BoundField HeaderText="Region Gap" DataField="RegionGap" />
                                            <asp:BoundField HeaderText="World Gap" DataField="WorldGap" />
                                            <asp:BoundField HeaderText="Region Next" DataField="RegionNext" />
                                            <asp:BoundField HeaderText="World Next" DataField="WorldNext" />
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
            </atk:TabContainer>
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<asp:Label runat="server" ID="CurrentTab" Visible="false" />
<asp:Label runat="server" ID="Messages" Visible="false" />