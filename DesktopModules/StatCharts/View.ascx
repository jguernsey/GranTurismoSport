<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.StatCharts.View" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="3" >
                <asp:Label runat="server" ID="lblDailyKm" CssClass="gtsHeaderLabel" Text="Kilometers By Date" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Chart ID="chtDailyMeter" runat="server" Width="600px">
                    <Titles>
                        <asp:Title Text="Daily Kilometers"></asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="Kilometers" ChartType="Column" ChartArea="MainChartArea" BorderWidth="5" Color="#499BBE"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="MainChartArea"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDistanceChart" CssClass="gtsHeaderLabel" Text="Total Kilometers By Date" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Chart ID="chtTotalMeters" runat="server" Width="600px">
                    <Titles>
                        <asp:Title Text="Total Distance"></asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="RunningTotal" ChartType="Line" ChartArea="MainChartArea" BorderWidth="5" Color="#808080"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="MainChartArea"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDrChart" CssClass="gtsHeaderLabel" Text="Driver Rating By Date" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Chart ID="chtDriverPoints" runat="server" Width="600px">
                    <Titles>
                        <asp:Title Text="Driver Rating Points"></asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="DriverRating" ChartType="Area" ChartArea="MainChartArea" BorderWidth="5" Color="#5C5AEE"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="MainChartArea"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>