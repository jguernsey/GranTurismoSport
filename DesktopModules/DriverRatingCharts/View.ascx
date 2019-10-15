<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.DriverRatingCharts.View" %>
<script src="js/chart.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        LoadChart();
        $("[id*=btnUpdate]").bind("click", function () {
            LoadChart();
        });
    });
    function LoadChart() {
        var obj = {};
        var uname = document.getElementById('<%=hfUsername.ClientID%>').value;
        var sdate = document.getElementById('<%=txtStartDate.ClientID%>').value;
        var edate = document.getElementById('<%=txtEndDate.ClientID%>').value;

        var jsonData = JSON.stringify({
            username: uname,
            sd: sdate,
            ed: edate
        });
        $.ajax({
            type: "POST",
            url: '<%=ResolveUrl("GetDriverRatingData.asmx/GetChartData")%>',
            contentType: "application/json; charset=utf=8",
            data: jsonData,
            dataType: "json",
            success: function (r) {
                var data = eval(r.d);
                var el = document.createElement('canvas');
                $("#dvChart")[0].appendChild(el);
                var ctx = el.getContext('2d');
                var totalChart = new Chart(ctx, {
                    type: 'bar',
                    data: data,
                    backgroundColor: "rgba(0,135,255,1)",
                    borderColor: "rgba(0,85,255,1)",
                    borderWidth: 2
                });
            },
            failure: function (response) {
                alert('There was an error.');
            }
        });
    }
</script>
<div class="gtsModuleDiv">
    <table border="0">
        <tr>
            <td colspan="5">
                 <asp:Label runat="server" ID="lblHomeHeader" CssClass="gtsHeaderLabel" Text="Real Time Driver Rating"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblStartDate" runat="server" Text="Start:" Width="50px" />
            </td>
            <td>
                <asp:UpdatePanel runat="server" ID="upStartDate">
                    <ContentTemplate>
                        <asp:TextBox ID="txtStartDate" runat="server" MaxLength="10" TextMode="Date" Width="125px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                <asp:Label ID="lblEndDate" runat="server" Text="End:" Width="50px" />
            </td>
            <td>
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <asp:TextBox ID="txtEndDate" runat="server" MaxLength="10" TextMode="Date" Width="125px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <div id="dvChart">
                </div>
            </td>
        </tr>
    </table>
</div>
<asp:HiddenField ID="hfUsername" runat="server" />