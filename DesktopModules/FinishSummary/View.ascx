<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.FinishSummary.View" %>
<div class="gtsModuleDiv" >
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Overall Summary" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvSummary" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Total" DataField="Total" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="1st" DataField="First" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="2nd" DataField="Second" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="3rd" DataField="Third" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Top 5" DataField="TopFive" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Top 10" DataField="TopTen" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Other" DataField="Other" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="Label1" CssClass="gtsHeaderLabel" Text="Summary By Track" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvSummaryByTrack" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Track" DataField="Track" >
				            <ItemStyle CssClass="gtsGridLeftLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Total" DataField="Total" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="1st" DataField="First" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="2nd" DataField="Second" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="3rd" DataField="Third" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Top 5" DataField="TopFive" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Top 10" DataField="TopTen" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Other" DataField="Other" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblNotice" CssClass="gtsTextNotice" Text="Summary by track is for race results after March 1st, 2018, data prior to this date is not available."></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>