<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventDetails.aspx.cs" Inherits="Event_OrganiserWebApp.EventDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server" style="background-color:beige">
        <div>
            <center>
            <h1> Event Details</h1>
                <hr />
            <br />
            <asp:GridView ID="GridView1" AutoGenerateColumns="true" runat="server">
                    
            </asp:GridView>
            <asp:GridView ID="gvEventDetails" AutoGenerateColumns="false" runat="server">
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
                </center>
        </div>
    </form>
</body>
</html>
