<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.UpdateUserName.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblUserName" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblUserName" runat="server" Text="PSN Name:" CssClass="gtsLabel"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtUserName" runat="server" Width="150px" CssClass="gtsTextBox"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="ClickedSave" CssClass="gtsButton" ></asp:Button>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>