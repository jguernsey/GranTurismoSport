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
<div class="gtsModuleDiv">
    <atk:TabContainer runat="server" ID="Tabs" OnClientActiveTabChanged="ActiveTabChanged" ActiveTabIndex="0" CssClass="ajaxTabs" EnableTheming="False" Width="100%" >
        <atk:TabPanel runat="server" ID="pnlRaceA" HeaderText="Daily Race A" >
            <ContentTemplate>
                <asp:Table runat="server" CssClass="gtsOuterTable">
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:GridView ID="dgvUserA" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Region Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("Time") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
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
                            <asp:GridView ID="dgvRegionA" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="lblField" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="lblField" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="flagImage" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="lblField" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:GridView ID="dgvWorldA" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="lblField" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="lblField" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="flagImage" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="lblField" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                            <asp:Label runat="server" ID="Label5" CssClass="gtsHeaderLabel" Text="My Qualifying Time"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </atk:TabPanel>
        <atk:TabPanel runat="server" ID="pnlRaceB" HeaderText="Daily Race B"  >
            <ContentTemplate>
                <asp:Table runat="server" CssClass="gtsOuterTable">
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:GridView ID="dgvUserB" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Region Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("Time") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
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
                            <asp:GridView ID="dgvRegionB" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label6" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label7" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="flagImage" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label10" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:GridView ID="dgvWorldB" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label11" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label12" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image1" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label13" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </atk:TabPanel>
        <atk:TabPanel runat="server" ID="pnlRaceC" HeaderText="Daily Race C"  >
            <ContentTemplate>
                <asp:Table runat="server" CssClass="gtsOuterTable">
                    <asp:TableRow>
                        <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                            <asp:Label runat="server" ID="Label3" CssClass="gtsHeaderLabel" Text="My Qualifying Time"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:GridView ID="dgvUserC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Region Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("Time") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("RegionNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="lblField" Text='<%# Eval("WorldNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
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
                            <asp:GridView ID="dgvRegionC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label14" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label15" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image2" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label16" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:GridView ID="dgvWorldC" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label17" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label18" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image3" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label19" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </atk:TabPanel>
        <atk:TabPanel runat="server" ID="pnlNations" HeaderText="Nations"  >
            <ContentTemplate>
                <asp:Table runat="server" CssClass="gtsOuterTable">
                    <asp:TableRow>
                        <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                            <asp:Label runat="server" ID="Label2" CssClass="gtsHeaderLabel" Text="My Qualifying Time"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:GridView ID="dgvUserN" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Region Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label34" Text='<%# Eval("RegionRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label35" Text='<%# Eval("RegionTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label36" Text='<%# Eval("WorldRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label37" Text='<%# Eval("WorldTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label38" Text='<%# Eval("Time") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label39" Text='<%# Eval("RegionGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label40" Text='<%# Eval("WorldGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label41" Text='<%# Eval("RegionNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label42" Text='<%# Eval("WorldNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
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
                            <asp:GridView ID="dgvRegionN" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label20" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label21" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image4" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label22" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:GridView ID="dgvWorldN" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label23" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label24" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image5" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label25" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </atk:TabPanel>
        <atk:TabPanel runat="server" ID="pnlManufacturers" HeaderText="Manufacturers"  >
            <ContentTemplate>
                <asp:Table runat="server" CssClass="gtsOuterTable">
                    <asp:TableRow>
                        <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                            <asp:Label runat="server" ID="Label73" CssClass="gtsHeaderLabel" Text="My Qualifying Time"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:GridView ID="dgvUserM" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Region Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label43" Text='<%# Eval("RegionRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label44" Text='<%# Eval("RegionTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label45" Text='<%# Eval("WorldRank") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Total" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label48" Text='<%# Eval("WorldTotal") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label49" Text='<%# Eval("Time") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label50" Text='<%# Eval("RegionGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Gap" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label51" Text='<%# Eval("WorldGap") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Region Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label52" Text='<%# Eval("RegionNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="World Next" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightTinyiny" id="Label53" Text='<%# Eval("WorldNext") %>' runat="server" ></asp:Label>
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="gtsHeaderCell">
                            <asp:Label runat="server" ID="Label65" CssClass="gtsHeaderLabel" Text="Region" ></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell CssClass="gtsHeaderCell">
                            <asp:Label runat="server" ID="Label66" CssClass="gtsHeaderLabel" Text="World" ></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:GridView ID="dgvRegionM" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label26" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label29" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image6" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label30" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:GridView ID="dgvWorldM" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Rank" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridCenterTiny" id="Label31" Text='<%# Eval("Rank") %>' runat="server"/> 
                                        </itemtemplate>
			                        </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Id" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridLeft" id="Label32" Text='<%# Eval("UserId") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Country">
                                        <ItemTemplate>
                                            <asp:Image ID="Image7" ImageUrl='<%#"ImageHandler.ashx?imgId=" + Eval("CountryName") %>' runat="server" CssClass="gtsCountryImage"/>
                                        </ItemTemplate>
                                    </asp:TemplateField> 
                                    <asp:TemplateField HeaderText="Time" >
                                        <itemtemplate>
                                            <asp:Label CssClass="gtsGridRightSmall" id="Label33" Text='<%# Eval("Score") %>' runat="server"/> 
                                        </itemtemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ContentTemplate>
        </atk:TabPanel>
    </atk:TabContainer>
</div>
<asp:Label runat="server" ID="CurrentTab" Visible="false" />
<asp:Label runat="server" ID="Messages" Visible="false" />