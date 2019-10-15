<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RaceAverages.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRecordTimes" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Track Averages" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvTrackAverages" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow"  OnRowCreated="OnDataBound" >
                    <Columns>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Races" DataField="Races" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Most Led" DataField="MaxLed" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Avg. SR" DataField="AvgSR" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Min. SR" DataField="MinSR" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Max. SR" DataField="MaxSR" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Avg. Start" DataField="AvgQ" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Worst Start" DataField="BestQ" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Best Start" DataField="WorstQ" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Avg. Finish" DataField="AvgF" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Worst Finish" DataField="WorstF" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Best Finish" DataField="BestF" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>