<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.DriverRating.View" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblDriverRating" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="5">
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Real Time Driver Rating"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblStartDate" runat="server" Text="Start:" Width="50px" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" ID="upStartDate">
                    <ContentTemplate>
                        <asp:TextBox ID="txtStartDate" runat="server" MaxLength="10" TextMode="Date" Width="125px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblEndDate" runat="server" Text="End:" Width="50px" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <asp:TextBox ID="txtEndDate" runat="server" MaxLength="10" TextMode="Date" Width="125px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnReload" runat="server" Text="Update" OnClick="UpdateCharts" Width="100px"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="5">
                <ajaxToolkit:AreaChart ID="chartDr" runat="server" ChartWidth="500" ChartHeight="500">

                </ajaxToolkit:AreaChart>
<%--                <asp:Chart ID="chartDr" runat="server" Width="450px" Height="450px" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2px" BackColor="211,223,240" BorderColor="#1A3B69" >
                    <Titles>
                        <asp:Title Text="Driver Rating"></asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="DriverRating" ChartType="Area" BorderColor="180,26,59,105" ChartArea="caDriverRating">

                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="caDriverRating" BorderColor="64,64,64,64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64,165,191,228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                            <Area3DStyle Rotation="10" Perspective="10" Inclination="15" IsRightAngleAxes="false" WallWidth="0" IsClustered="false" />
                            <AxisY LineColor="64,64,64,64">
                                <LabelStyle Font="Trebuchet MS, 8.25px" />
                                <MajorGrid LineColor="64,64,64,64" />
                            </AxisY>
                            <AxisX LineColor="64,64,64,64">
                                <LabelStyle Font="Trebuchet MS, 8.25" />
                                <MajorGrid LineColor="64,64,64,64" />
                            </AxisX>
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>--%>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="5">
                <ajaxToolkit:BarChart ID="chartChanges" runat="server" ChartWidth="500" ChartHeight="450"></ajaxToolkit:BarChart>
<%--                <asp:Chart ID="chartChanges" runat="server" Width="450px" Height="450px" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2px" BackColor="211,223,240" BorderColor="#1A3B69" >
                    <Titles>
                        <asp:Title Text="Driver Rating Changes"></asp:Title>
                    </Titles>
                    <Series>
                        <asp:Series Name="Changes" BorderColor="180,26,59,105" ChartArea="caChanges" >

                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="caChanges" BorderColor="64,64,64,64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64,165,191,228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                            <Area3DStyle Rotation="10" Perspective="10" Inclination="15" IsRightAngleAxes="false" WallWidth="0" IsClustered="false" />
                            <AxisY LineColor="64,64,64,64">
                                <LabelStyle Font="Trebuchet MS, 8.25px" />
                                <MajorGrid LineColor="64,64,64,64" />
                            </AxisY>
                            <AxisX LineColor="64,64,64,64">
                                <LabelStyle Font="Trebuchet MS, 8.25" />
                                <MajorGrid LineColor="64,64,64,64" />
                            </AxisX>
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>--%>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>