<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.UserBestLaps.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRecordTimes" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="My Track Records" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvTrackRecords" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" OnDataBound="OnDataBound">
                    <Columns>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Time" DataField="Score" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="World" DataField="World" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Region" DataField="Region" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Country" DataField="Country" >
				            <ItemStyle CssClass="gtsGridRight" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Date" DataField="Date" >
				            <ItemStyle CssClass="gtsGridRightLarge" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>