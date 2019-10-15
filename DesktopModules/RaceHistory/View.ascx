<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RaceHistory.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRecordTimes" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Race History" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvRaceHistory" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" OnRowCreated="OnDataBound">
                    <Columns>
                        <asp:BoundField HeaderText="Start Time" DataField="Time" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Type" DataField="Type" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Track" DataField="Track" >
				            <ItemStyle CssClass="gtsGridLeftLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Qualified" DataField="Qualified" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="SR +/-" DataField="SR" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Finished" DataField="Finish" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Change" DataField="Change" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>