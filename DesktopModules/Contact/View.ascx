<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.Contact.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblDriverRatings" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan=" 2">
                <asp:Label runat="server" ID="lblDrHeader" CssClass="gtsHeaderLabel" Text="Contact"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Label runat="server" ID="lblMessage" CssClass="gtsGridLeft" Text="Send us a message and let us know how we're doing!"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell VerticalAlign="Top">
                <asp:Label runat="server" ID="lblText" CssClass="gtsGridRight" Text="Message: " ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="txtMessage" CssClass="gtsTexBox" Width="250px" Height="100px" ></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Button runat="server" ID="btnSend" Text="Send" CssClass="gtsButton" Width="150px" OnClick="SendMessage" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="lblDonate" runat="server" Text="No ads ever, however, servers, hosting and maintenance aren't free." />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="lblDonateB" runat="server" Text="If you'd like to donate so we can cover costs of running this site," />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="lblDonateC" runat="server" Text="it would be very much appreciated if you would please click the link below. " />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <input type="hidden" name="cmd" value="_s-xclick">
                <input type="hidden" name="hosted_button_id" value="5RM28ZXAZ3VC8">
                <input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif" border="0" name="submit" onclick="this.form.action='https://www.paypal.com/cgi-bin/webscr';this.form.submit();" alt="PayPal - The safer, easier way to pay online!">
                <img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>