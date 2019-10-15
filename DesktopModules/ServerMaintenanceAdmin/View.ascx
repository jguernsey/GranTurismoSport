<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.ServerMaintenanceAdmin.View" %>
<div class="gtsModuleDiv" >
    <asp:Table runat="server" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" >
                <asp:Label runat="server" ID="lblAdminHeader" CssClass="gtsHeaderLabel" Text="Pending Server Maintenance" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="dgvLevels" CssClass="gtsGridView" runat="server" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" CellPadding="2" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="Level"  >
                            <ItemTemplate>
                                <asp:Label ID="level" Text='<%# Eval("PlayerLevel") %>' runat="server" CssClass="gtsGridViewLabel" ></asp:Label>
                            </ItemTemplate>
                            <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" Width="160px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Players"  >
                            <ItemTemplate>
                                <asp:Label ID="playerCount" Text='<%# Eval("PlayerCount") %>' runat="server" CssClass="gtsGridViewLabel" ></asp:Label>
                            </ItemTemplate>
                            <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="160px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="%"  >
                            <ItemTemplate>
                                <asp:Label ID="percent" Text='<%# Eval("PercentageOfTotal") %>' runat="server" CssClass="gtsGridViewLabel" ></asp:Label>
                            </ItemTemplate>
                            <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="160px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>