<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.WinsBrackets.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblWinsBrackets" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblWinsHeader" CssClass="gtsHeaderLabel" Text="Total Races Won"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvWins" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Wins" DataField="Wins" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="Players"  >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="Percentage"  >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>