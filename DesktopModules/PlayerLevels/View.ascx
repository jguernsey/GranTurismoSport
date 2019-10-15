<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.PlayerLevels.View" %>
<div class="gtsModuleDiv" >
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Players By Level" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvLevels" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Level" DataField="PlayerLevel" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Players" DataField="PlayerCount" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="%" DataField="PercentageOfTotal" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>