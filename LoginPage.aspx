<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Event_OrganiserWebApp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server">
    <div>
        <center>
    <table style="margin:auto;border:5px solid white">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials" ForeColor="Red"></asp:Label></td>
        </tr>
    </table>
            </center>
    </div>
        <h1> Event Details</h1>
                <hr />
            <br />
        <asp:GridView ID="gvSearch" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No such event found!!">

        </asp:GridView>
            
            <%--<asp:GridView ID="GridView1" AutoGenerateColumns="true" runat="server">
                    
            </asp:GridView>--%>
            <%--<asp:GridView ID="gvEventDetails" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField DataField="EventID" HeaderText="EventID"/>
                    <asp:BoundField DataField="EventName" HeaderText="EventName" />
                    <asp:BoundField DataField="EventType" HeaderText="EventType" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="Time" HeaderText="Time" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("EventID") %>' OnClick ="lnk_Onclick">
                                View
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                    
            </asp:GridView>
            --%>
    </form>
</body>

</html>
