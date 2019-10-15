<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.NationsCupSummary.View" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>
<div class="gtsModuleDiv" >
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2">
                <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="FIA Nations Cup" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="lblSeason" Text="Season:" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="cboSeasons" OnSelectedIndexChanged="SeasonChanged" CssClass="gtsDropDownList" Width="300px" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="Label1" Text="Country:" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="cboCountry" OnSelectedIndexChanged="CountryChanged" CssClass="gtsDropDownList" Width="300px" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:GridView ID="dgvSummary" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" OnSelectedIndexChanged="SelectedRowChanged" OnRowDataBound="GridDataBound"  PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" OnPageIndexChanging="StatIndexChanging" AllowPaging="true" PageSize="100" AllowCustomPaging="true">
                            <Columns>
                                <asp:BoundField HeaderText="World" DataField="WorldRank" >
				                    <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                    </asp:BoundField>
                                <asp:BoundField HeaderText="Country" DataField="CountryRank" >
				                    <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                    </asp:BoundField>
                                <asp:BoundField HeaderText="Driver" DataField="Driver" >
				                    <ItemStyle CssClass="gtsGridLeft" />
			                    </asp:BoundField>
                                <asp:ImageField HeaderText="Country" DataImageUrlField="CountryName" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" >
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:ImageField>
                                <asp:BoundField HeaderText="DR" DataField="DR" >
				                    <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                    </asp:BoundField>
                                <asp:BoundField HeaderText="SR" DataField="SR" >
				                    <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                    </asp:BoundField>
                                <asp:BoundField HeaderText="Points" DataField="TotalPoints" >
				                    <ItemStyle CssClass="gtsGridRightTinyiny" />
			                    </asp:BoundField>
                            </Columns>
                            <PagerSettings Position="TopAndBottom" Mode="NextPreviousFirstLast" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="modalPopup" runat="server" style="display:none" />
    <atk:ModalPopupExtender runat="server" ID="mpeManufacturers" TargetControlID="modalPopup" PopupControlID="updatePanel" CancelControlID="btnClose" BackgroundCssClass="gtsModalBackground">
    </atk:ModalPopupExtender>
    <asp:Panel ID="updatePanel" runat="server" CssClass="gtsModalPopup" Style="display:none">
        <div class="gtsModalHeader">
            <asp:Label runat="server" ID="lblHeader" CssClass="gtsModalHeaderText" Text="Championship Race History"></asp:Label>
        </div>
        <div class="gtsModalBody">
            <table>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Always">
                            <ContentTemplate>
                                <asp:Image ID="imgDriverCountry" runat="server" CssClass="gtsCountryImage" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td>
                        <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Always">
                            <ContentTemplate>
                                <asp:Label ID="lblDriverName" runat="server" Text="" CssClass="gtsGridLeft"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr >
                    <td>
                        &nbsp;
                    </td>
                    <td colspan="2">
                        <asp:UpdatePanel runat="server" ID="detailUp" UpdateMode="Always" >
                            <ContentTemplate>
                                <asp:GridView ID="dgvDetail" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                    <Columns>
                                        <asp:BoundField HeaderText="Round" DataField="Round" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Track" DataField="Track" >
				                            <ItemStyle CssClass="gtsGridLeftLarge" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Category" DataField="Category" >
				                            <ItemStyle CssClass="gtsGridCenterTiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Laps" DataField="Laps" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Led" DataField="LapsLEd" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="SR" DataField="RaceSR" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Qualified" DataField="Qualified" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Finished" DataField="Finished" >
				                            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			                            </asp:BoundField>
                                        <asp:BoundField HeaderText="Points" DataField="RacePoints" >
				                            <ItemStyle CssClass="gtsGridRightTinyiny" />
			                            </asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
        <div class="gtsModalFooter" >
            <asp:Button runat="server" ID="btnClose" Text="Close" CssClass="gtsButton" />
        </div>
    </asp:Panel>
</div>