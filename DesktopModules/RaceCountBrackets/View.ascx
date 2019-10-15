<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RaceCountBrackets.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRaceCountOuter" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Total Number of Races Entered"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvRaces" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Races" DataField="Races" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="Players" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="All Profiles" DataField="PercentageOfTotal" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="At Least 1 Race" DataField="Percentage" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Percentile" DataField="Percentile" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>