<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="Event_OrganiserWebApp.AddEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server">
        <div>
            <center>
            <h1>Creating an event!!</h1>
            <hr />
            <br />
            <asp:HiddenField ID="hfvalue" runat="server" />
            <table class="auto-style1">
                <tr>  
                    <td>Event ID :</td>  
                    <td><asp:TextBox ID="txtEventID" runat="server"></asp:TextBox></td>  
                </tr>
                <tr>  
                    <td>Event Name :</td>  
                    <td><asp:TextBox ID="txtEventName" runat="server"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Event Type :</td>  
                    <td><asp:TextBox ID="txtEventType" runat="server"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Description :</td>  
                    <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>  
                </tr> 
                <tr>  
                    <td>Time :</td>  
                    <td><asp:TextBox ID="txtTime" runat="server"></asp:TextBox></td>  
                </tr>
                <tr >  
                    <td ><asp:Button ID="Button1"  runat="server" Text="Submit" OnClick="Button1_Click" /></td>  
                    
                </tr> 
                <tr>  
                    <td>
                        <asp:Label ID="lblSuccessMessage" runat="server" Text=""></asp:Label>
                    </td>  
                    <td>
                        <asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
                    </td>  
                
                </tr> 
               </table>  
                </center>
        </div>
    </form>
</body>
</html>
