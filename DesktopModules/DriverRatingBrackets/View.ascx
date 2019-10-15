<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.DriverRatingBrackets.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblDriverRatings" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="Driver Rating"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvDriverRating" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="DR" DataField="Driver Rating" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="Players" >
				            <ItemStyle CssClass="gtsGridRightTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="Percentage" >
				            <ItemStyle CssClass="gtsGridRightTiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                &nbsp;
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblSrHeader" CssClass="gtsHeaderLabel" Text="Sportsmanship Rating"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvSportsmanship" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="SR" DataField="SR" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="Players" >
				            <ItemStyle CssClass="gtsGridRightTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="Percentage" >
				            <ItemStyle CssClass="gtsGridRightTiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                &nbsp;
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblCombinedHeader" CssClass="gtsHeaderLabel" Text="Combined DR and SR"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvCombined" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="DR" DataField="DR" >
				            <ItemStyle CssClass="gtsGridCenterSmall" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="SR" DataField="SR" >
				            <ItemStyle CssClass="gtsGridCenterSmall" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="Players" >
				            <ItemStyle CssClass="gtsGridRightLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="Percentage" >
				            <ItemStyle CssClass="gtsGridRightLarge" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>