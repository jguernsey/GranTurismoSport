<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.TrackRatingByTime.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRaceCalendar" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="SR +/- By Time"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvSummary" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Track" DataField="Track" >
				            <ItemStyle CssClass="gtsGridLeftLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
                            <ItemStyle CssClass="gtsGridCenterTiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Time" DataField="Time" >
                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Entries" DataField="Entries" >
				            <ItemStyle CssClass="gtsGridRightTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Most SR +" DataField="MostGained" >
				            <ItemStyle CssClass="gtsGridRightTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Most SR -" DataField="MostLost" >
				            <ItemStyle CssClass="gtsGridRightTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Average SR +/-" DataField="Average" >
				            <ItemStyle CssClass="gtsGridRightTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Total SR +/-" DataField="Total" >
				            <ItemStyle CssClass="gtsGridRightTinyiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>