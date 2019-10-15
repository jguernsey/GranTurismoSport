<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.WinsBrackets.View" %>
<div class="modDiv">
    <asp:GridView ID="dgvWins" CssClass="dataGrid" runat="server" HeaderStyle-Wrap="False" GridLines="Both" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" Caption="Wins" CaptionAlign="Top" CellPadding="5" ShowHeaderWhenEmpty="True" SortedAscendingCellStyle-BorderStyle="NotSet" AutoGenerateColumns="False" CellSpacing="5" >
        <Columns>
            <asp:TemplateField HeaderText="Wins" >
                <ItemTemplate>
                    <asp:Label ID="Rank" Text='<%# Eval("Wins") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                </ItemTemplate>
                <ItemStyle BorderColor="Black" VerticalAlign="Middle"  HorizontalAlign="Center" Wrap="false" Width="150px"/>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Players"  >
                <ItemTemplate>
                    <asp:Label ID="country" Text='<%# Eval("Players") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                </ItemTemplate>
                <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="%">
                <ItemTemplate>
                    <asp:Label ID="total" Text='<%# Eval("Percentage") %>' runat="server" CssClass="dgvLabel"></asp:Label>
                </ItemTemplate>
                <ItemStyle BorderColor="Black" VerticalAlign="Middle" HorizontalAlign="Right" Wrap="false" Width="150px"/>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>