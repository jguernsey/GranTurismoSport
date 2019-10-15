<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Jjg.GtsStats.RequestBoard.View" %>
<div class="gtsModuleDiv">
    <asp:Table runat="server" ID="tblRecordTimes" CssClass="gtsOuterTable">
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                <asp:Label runat="server" ID="lblRaceHeader" CssClass="gtsHeaderLabel" Text="Feature Requests" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan =" 2">
                <asp:GridView ID="dgvRequests" runat="server" AutoGenerateColumns="False" GridLines="None" CssClass="gtsGridView" PagerStyle-CssClass="gtsPager" AlternatingRowStyle-CssClass="gtsAlternateRow" OnRowCommand="FeatureRowCommand" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnVote" runat="server" CommandName="VoteFeature" CommandArgument='<%# Eval("Id") %>' Text="Vote" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Id" DataField="Id" Visible="false" />
                        <asp:BoundField HeaderText="Votes" DataField="Votes" >
				            <ItemStyle CssClass="gtsGridCenterTinyiny" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Date" DataField="Date" >
				            <ItemStyle CssClass="gtsGridRightLarge" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Title" DataField="Title" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Description" DataField="Description" >
				            <ItemStyle CssClass="gtsGridLeft" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Type" DataField="RequestType" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                        <asp:BoundField HeaderText="Status" DataField="RequestStatus" >
				            <ItemStyle CssClass="gtsGridCenter" />
			            </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="gtsHeaderCell" ColumnSpan="2" >
                <asp:Label runat="server" ID="Label1" CssClass="gtsHeaderLabel" Text="Submit New Request" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblRequestType" runat="server" Text="Request Type: " Width="100px" CssClass="gtsGridRight"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:UpdatePanel runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <asp:DropDownList runat="server" ID="cboRequestType" CssClass="gtsGridLeft" Width="150px" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblRequestTitle" runat="server" Text="Title: " Width="100px"  CssClass="gtsGridRight"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtRequestTitle" runat="server" CssClass="gtsGridLeft" Width="500px"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblRequestDescription" runat="server" Text="Description: " Width="100px"  CssClass="gtsGridRight"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="gtsGridLeft" Width="500px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="ClickedCancel" CssClass="gtsGridLeft" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit Request" OnClick="ClickedSubmit" CssClass="gtsGridRight" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>