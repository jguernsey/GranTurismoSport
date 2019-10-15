<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RecordTimes.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRecordTimes" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Track Records" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvTrackRecords" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" OnRowCreated="OnDataBound" >
                    <Columns>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Driver" DataField="Driver" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:ImageField HeaderText="Country" DataImageUrlField="Country" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                        <asp:BoundField HeaderText="Time" DataField="Time" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
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