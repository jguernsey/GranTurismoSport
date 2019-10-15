<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.Wins.View" %>
<div class="modDiv">
    <asp:Table runat="server" CssClass="baseTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="cboStatTypes" OnSelectedIndexChanged="SelectedStatTypeChanged" CssClass="lblInfo" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:RadioButton runat="server" ID="radWorld" Text="World Rankings" OnCheckedChanged="WorldRankingChanged" CssClass="lblInfo" AutoPostBack="true" Checked="True" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:RadioButton runat="server" ID="radCountry" Text="Country Rankings" OnCheckedChanged="CountryRankingChanged" CssClass="lblInfo" AutoPostBack="true"/>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
<%--            <asp:TableCell>
                <asp:Button runat="server" ID="btnDriverRating" Text="Driver Rating" Width="150px" OnClick="ClickedDriverRating" CssClass="button"  />
            </asp:TableCell>--%>
            <asp:TableCell ColumnSpan="3">
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:GridView ID="dgvStats" CssClass="dataGrid" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" Caption="" CaptionAlign="Top" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" OnPageIndexChanging="StatIndexChanging" AllowPaging="true" AllowCustomPaging="True"  PageSize="100">
                            <Columns>
                                <asp:TemplateField HeaderText="Rank"  >
                                    <ItemTemplate>
                                        <asp:Label ID="Rank" Text='<%# Eval("Rank") %>' runat="server" CssClass="dgvLabel" Width="100px"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Player"  >
                                    <ItemTemplate>
                                        <asp:Label ID="country" Text='<%# Eval("Player") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Left" Wrap="false" Width="175px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <asp:Image ID="flagImage" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("Country") %>' runat="server"  CssClass="dgvFlag"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Country"  >
                                    <ItemTemplate>
                                        <asp:Label ID="total" Text='<%# Eval("Country") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Left" Wrap="false" Width="175px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText=""  >
                                    <ItemTemplate>
                                        <asp:Label ID="lblValue" Text='<%# Eval("Value") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Wins" Visible="false"  >
                                    <ItemTemplate>
                                        <asp:Label ID="lblWins" Text='<%# Eval("Wins") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Races" Visible="false" >
                                    <ItemTemplate>
                                        <asp:Label ID="lblRaces" Text='<%# Eval("Races") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Last Update"  >
                                    <ItemTemplate>
                                        <asp:Label ID="lblEntryDate" Text='<%# Eval("EntryDate") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px" />
                                </asp:TemplateField>
                            </Columns>
                            <PagerSettings Mode="NextPreviousFirstLast" Position="TopAndBottom" />
                            <PagerStyle CssClass="dgvPager" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <%--<asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnWins" Text="Wins" Width="150px" OnClick="ClickedWins" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnWinsPerEntry" Text="Wins Per Entry" Width="150px" OnClick="ClickedWinsPerEntry" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
 
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnRaceCount" Text="Race Count" Width="150px" OnClick="ClickedRaceCount" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnRaces" Text="Races Finished" Width="150px" OnClick="ClickedRaces" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnTotalDistance" Text="Total Distance" Width="150px" OnClick="ClickedTotalDistance" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnCreditEarned" Text="Credit Earned" Width="150px" OnClick="ClickedCreditEarned" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnCars" Text="Cars Purchased" Width="150px" OnClick="ClickedCarsPurchased"  CssClass="button" />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnCarCount" Text="Car Count" Width="150px" OnClick="ClickedCarCount" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnTimePlayed" Text="Time Played" Width="150px" OnClick="ClickedTimePlayed" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnPoles" Text="Pole Positions" Width="150px" OnClick="ClickedPolePositions" CssClass="button"  />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btnFastestLaps" Text="Fastest Laps" Width="150px" OnClick="ClickedFastestLaps"  CssClass="button" />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="baseTableCell">
                <asp:Button runat="server" ID="btnExperience" Text="Experience" Width="150px" OnClick="ClickedExperience"  CssClass="button" />
            </asp:TableCell>
            <asp:TableCell>

            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow CssClass="baseTableRow">
            <asp:TableCell>
                <asp:Button runat="server" ID="Button1" Text="Level" Width="150px" OnClick="ClickedLevel" CssClass="button" />
            </asp:TableCell>
            <asp:TableCell>
                
            </asp:TableCell>
        </asp:TableRow>--%>
    </asp:Table>
</div>