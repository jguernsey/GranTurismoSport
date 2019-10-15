<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.HomePageInfo.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblHomePage" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Player Summary"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblNoStats" runat="server" Text="" Visible="false" CssClass="gtsLabelInfo" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvPlayerStats" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Value" DataField="Value" >
				            <ItemStyle CssClass="gtsGridRightMedium" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Country" DataField="CountryRank" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Region" DataField="RegionRank" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="World" DataField="WorldRank" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblLastUpdate" runat="server" Text="" CssClass="gtsLabelInfo" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>
