<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RaceCalendar.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRaceCalendar" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="Today's Races"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvRaces" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow"   OnRowCreated="OnDataBound" >
                    <Columns>
                        <asp:BoundField HeaderText="Track" DataField="Track" >
				            <ItemStyle CssClass="gtsGridLeftLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Laps" DataField="Laps" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Fuel" DataField="Fuel" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Tire Wear" DataField="TireWear" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Qualified" DataField="RegionCount" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>