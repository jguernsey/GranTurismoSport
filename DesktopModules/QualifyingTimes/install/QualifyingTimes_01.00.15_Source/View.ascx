<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.QualifyingTimes.View" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atk" %>
    <script type="text/javascript">
        function PanelClick(sender, e) {
            var Messages = $get('<%=Messages.ClientID%>');
            Highlight(Messages);
        }

        function ActiveTabChanged(sender, e) {
            var CurrentTab = $get('<%=CurrentTab.ClientID%>');
            CurrentTab.innerHTML = sender.get_activeTab().get_headerText();
            Highlight(CurrentTab);
        }

        var HighlightAnimations = {};
        function Highlight(el) {
            if (HighlightAnimations[el.uniqueID] == null) {
                HighlightAnimations[el.uniqueID] = AjaxControlToolkit.Animation.createAnimation({
                    AnimationName: "color",
                    duration: 0.5,
                    property: "style",
                    propertyKey: "backgroundColor",
                    startValue: "#FFFF90",
                    endValue: "#FFFFFF"
                }, el);
            }
            HighlightAnimations[el.uniqueID].stop();
            HighlightAnimations[el.uniqueID].play();
        }

        function ToggleHidden(value) {
            $find('<%=Tabs.ClientID%>').get_tabs()[2].set_enabled(value);
        }
    </script>
<asp:Table runat="server" HorizontalAlign="Center" Width="80%" >
    <asp:TableRow>
        <asp:TableCell>
            <atk:TabContainer runat="server" ID="Tabs" OnClientActiveTabChanged="ActiveTabChanged" ActiveTabIndex="0" CssClass="ajaxTabs" EnableTheming="False" Width="100%" >
                <atk:TabPanel runat="server" ID="pnlRaceA" HeaderText="Race A" >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="lblA" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label1" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionA" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="lblRank" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="lblId" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="flagImage" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="lblTime" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldA" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label2" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label3" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image1" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label4" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlRaceB" HeaderText="Race B"  >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label8" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label9" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionB" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label10" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label11" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image2" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label12" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldB" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label13" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label14" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image3" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label15" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlRaceC" HeaderText="Race C"  >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label27" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label28" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionC" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label29" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label30" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image4" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label31" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldC" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label32" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label33" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image5" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label34" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlNations" HeaderText="Nations Cup"  >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label46" CssClass="gtsHeaderLabel" Text="Region"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell CssClass="gtsHeaderCell">
                                    <asp:Label runat="server" ID="Label47" CssClass="gtsHeaderLabel" Text="World"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionN" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label48" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label49" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image6" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label50" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldN" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label51" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label52" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image7" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label53" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlManufacturers" HeaderText="Manufacturers Series"  >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:Label runat="server" ID="Label65" CssClass="gtsHeaderLabel" Text="Region" Width="250px"></asp:Label>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:Label runat="server" ID="Label66" CssClass="gtsHeaderLabel" Text="World" Width="250px"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvRegionM" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label67" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel" Width="50px"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label68" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel" Width="78px"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image8" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label69" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel" Width="77px"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvWorldM" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="250px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label70" Text='<%# Eval("Rank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Id" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label71" Text='<%# Eval("UserId") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Image ID="Image9" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" Height="30px" Width="45px"  CssClass="gtsGridViewImage"/>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label72" Text='<%# Eval("Score") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
                <atk:TabPanel runat="server" ID="pnlMyTimes" HeaderText="Qualifying" >
                    <ContentTemplate>
                        <asp:Table runat="server">
                            <asp:TableRow>
                                <asp:TableCell >
                                    <asp:Label runat="server" ID="Label73" CssClass="gtsHeaderLabel" Text="Qualifying"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <asp:GridView ID="dgvTimes" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" Width="500px">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Race" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label55" Text='<%# Eval("Race") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Left" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Region Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label56" Text='<%# Eval("RegionRank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Region Total" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label57" Text='<%# Eval("RegionTotal") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="World Rank" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label58" Text='<%# Eval("WorldRank") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="World Total" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label59" Text='<%# Eval("WorldTotal") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false"/>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Time" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label60" Text='<%# Eval("Time") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Region Gap" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label61" Text='<%# Eval("RegionGap") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="World Gap" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label62" Text='<%# Eval("WorldGap") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Region Next" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label63" Text='<%# Eval("RegionNext") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="World Next" >
	                                            <ItemTemplate>
		                                            <asp:Label ID="Label64" Text='<%# Eval("WorldNext") %>' runat="server" CssClass="gtsGridViewLabel"></asp:Label>
	                                            </ItemTemplate>
	                                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Right" Wrap="false" />
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </ContentTemplate>
                </atk:TabPanel>
            </atk:TabContainer>
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<asp:Label runat="server" ID="CurrentTab" Visible="false" />
<asp:Label runat="server" ID="Messages" Visible="false" />