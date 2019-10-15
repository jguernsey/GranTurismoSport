<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.CountryStats.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblCountryStats" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblDateInfo" runat="server" Text=""  CssClass="gtsLabelInfo"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblCountInfo" runat="server" Text=""  CssClass="gtsLabelInfo"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Players By Country" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvCountries" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Rank" DataField="Rank" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                        <asp:ImageField HeaderText="Country" DataImageUrlField="Country" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                        <asp:BoundField HeaderText="Players" DataField="Total" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="TotalPercent" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>