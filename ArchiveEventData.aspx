<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArchiveEventData.aspx.cs" Inherits="Event_OrganiserWebApp.ArchiveEventData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server">
    <div>
        <center>
        <asp:HiddenField ID="hfContactID" runat="server" />
        <h1>Select event to Archive </h1>
            <hr />
            <br />
            <table>
            <tr>
                <td>
                    <asp:Label ID="lblEventID" runat="server" Text="Event ID"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtEventID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEventName" runat="server" Text="Event Name"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtEventName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEventType" runat="server" Text="Event Type"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtEventType" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtDescription" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTime" runat="server" Text="Time"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtTime" runat="server" ></asp:TextBox>
                </td>
            </tr>
            
            
            <tr>
                <td>
                    
                </td>
                <td colspan="2">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Archive Event" OnClick="btnArchive_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td colspan="2">
                    <asp:Label ID="lblSuccessMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
                </td>
                <tr>
                <td>
                    
                </td>
                <td >
                    <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            </tr>
        </table>
        <br />
            <hr />
            <br />
        <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="EventID" HeaderText="EventID" />
                <asp:BoundField DataField="EventName" HeaderText="EventName" />
                <asp:BoundField DataField="EventType" HeaderText="EventType" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Time" HeaderText="Time" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("EventID") %>' OnClick="lnk_OnClick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </center>
    </div>
    </form>
</body>

</html>
