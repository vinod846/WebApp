<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchEvent.aspx.cs" Inherits="Event_OrganiserWebApp.SearchEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server">
        
        <div>
            <center>
                <h1>Search Event details</h1>
            Search : 
            <asp:TextBox ID="txtSearchBox" runat="server">

            </asp:TextBox><asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" />
                <br />
                <br />
            <hr />
            <br />
            <asp:GridView ID="gvSearch" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No such event found!!"></asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>
