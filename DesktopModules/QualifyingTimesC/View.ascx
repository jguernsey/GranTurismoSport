<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.QualifyingTimesC.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="Today's Race"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvRaces" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Track" DataField="Track" >
				            <ItemStyle CssClass="gtsGridLeftLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Category" DataField="Category" >
				            <ItemStyle CssClass="gtsGridCenterTiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Laps" DataField="Laps" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Fuel" DataField="Fuel" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Tire Wear" DataField="TireWear" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Qualified" DataField="RegionCount" >
				            <ItemStyle CssClass="gtsGridRightSmall" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell">
                <asp:Label runat="server" ID="Label5" CssClass="gtsHeaderLabel" Text="My Time"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell >
                <asp:GridView ID="dgvUserC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Region" DataField="Region" >
                            <ItemStyle CssClass="gtsGridRight" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="World"  DataField="World" >
                            <ItemStyle CssClass="gtsGridRight" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Time"  DataField="Time" >
                            <ItemStyle CssClass="gtsGridRightTinyiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Region Gap" DataField="RegionGap"  >
                            <ItemStyle CssClass="gtsGridRightTinyiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="World Gap"  DataField="WorldGap" >
                            <ItemStyle CssClass="gtsGridRightTinyiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Region Next"  DataField="RegionNext" >
                            <ItemStyle CssClass="gtsGridRightTinyiny" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="World Next"  DataField="WorldNext" >
                            <ItemStyle CssClass="gtsGridRightTinyiny" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell">
                <asp:Label runat="server" ID="lblA" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvRegionC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Rank"  DataField="Rank" >
                            <ItemStyle CssClass="gtsGridCenterTiny" /> 
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Id"  DataField="UserId" >
                            <ItemStyle CssClass="gtsGridLeft" /> 
                        </asp:BoundField>
                        <asp:ImageField HeaderText="Country" DataImageUrlField="ImagePath" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" >
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:ImageField>
                        <asp:BoundField HeaderText="Time"  DataField="Score" >
                            <ItemStyle CssClass="gtsGridRightSmall" /> 
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell">
                <asp:Label runat="server" ID="Label1" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvWorldC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                    <Columns>
                        <asp:BoundField HeaderText="Rank"  DataField="Rank" >
                            <ItemStyle CssClass="gtsGridCenterTiny" /> 
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Id"  DataField="UserId" >
                            <ItemStyle CssClass="gtsGridLeft" /> 
                        </asp:BoundField>
                        <asp:ImageField HeaderText="Country" DataImageUrlField="ImagePath" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" >
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:ImageField>
                        <asp:BoundField HeaderText="Time"  DataField="Score" >
                            <ItemStyle CssClass="gtsGridRightSmall" /> 
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>