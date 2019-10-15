<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.Wins.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="cboStatTypes" OnSelectedIndexChanged="SelectedStatTypeChanged" CssClass="gtsDropDownList" Width="125px" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:RadioButton runat="server" ID="radWorld" Text="World" OnCheckedChanged="WorldRankingChanged" CssClass="gtsRadioButton" Width="75px" AutoPostBack="true" Checked="True" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:RadioButton runat="server" ID="radCountry" Text="Country" OnCheckedChanged="CountryRankingChanged" CssClass="gtsRadioButton" Width="75px" AutoPostBack="true"/>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:RadioButton runat="server" ID="radRegion" Text="Region" OnCheckedChanged="RegionRankingChanged" CssClass="gtsRadioButton" Width="75px" AutoPostBack="true"/>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="4" >
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Label runat="server" ID="lblGridHeader" CssClass="gtsHeaderLabel" Text="" ></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:GridView ID="dgvStats" runat="server" AutoGenerateColumns="False" GridLines="None" AllowPaging="true" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" PageSize="100" OnPageIndexChanging="StatIndexChanging" AllowCustomPaging="true" >
                            <Columns>
                                <asp:BoundField HeaderText="Rank" DataField="Rank" ControlStyle-CssClass="gtsGridCenter" />
                                <asp:BoundField HeaderText="Player" DataField="Player" ControlStyle-CssClass="gtsGridLeft" />
                                <asp:ImageField HeaderText="Country" DataImageUrlField="Country" DataImageUrlFormatString="ImageHandler.ashx?imgId={0}" ControlStyle-CssClass="gtsCountryImage" />
                                <asp:BoundField HeaderText="" DataField="Value" ControlStyle-CssClass="gtsGridRight" />
                                <asp:BoundField HeaderText="Wins" Visible="false" DataField="Wins" ControlStyle-CssClass="gtsGridRight" />
                                <asp:BoundField HeaderText="Races" Visible="false" DataField="Races" ControlStyle-CssClass="gtsGridRight" />
                                <asp:BoundField HeaderText="Last Update" DataField="EntryDate" ControlStyle-CssClass="gtsGridRight" />
                            </Columns>
                            <PagerSettings Mode="NextPreviousFirstLast" Position="TopAndBottom" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>