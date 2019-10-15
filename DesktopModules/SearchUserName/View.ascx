<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.SearchUserName.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblSearchOuter" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblSearch" CssClass="gtsTextLabel" Text="PSN Username: " Width="160px" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="txtUsername" Width="150px" CssClass="gtsTextBox" ></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnSearch" Width="150px" Text="Search" CssClass="gtsButton" OnClick="ClickedSearch" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="3" >
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Player Summary" Width="480px"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">
                <asp:Label ID="lblNotFound" runat="server" Visible="false" CssClass="gtsLabelInfo" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">
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
            <asp:TableCell ColumnSpan="3">
                <asp:Label ID="lblLastUpdate" runat="server" Text="" CssClass="gtsLabelInfo" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">
                <asp:Label ID="lblRemove" runat="server" Text="Exclude my name from search results."></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblExclude" runat="server" Text="PSN Username:" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtExclude" runat="server" Width="150px" CssClass="gtsTextBox" ></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnExclude" Width="150px" Text="Exclude" CssClass="gtsButton" OnClick="ClickedExclude" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>