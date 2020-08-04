<%@ Page Title="Event Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Event_OrganiserWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <div style="background-color:beige">
    <h2 style="background-color:beige"><%: Title %> - Event organizer website</h2>
    <p>Welcome.... This is Event organizer website.</p>
    <p>The web application has various features like </p>
    <p><a runat="server" href="AddEvent.aspx" > Creating an event.</a></p>
    <p><a runat="server" href="EventInfo.aspx" > Edit or delete active events.</a></p>
    <p><a runat="server" href="ArchiveEventData.aspx" >Archive old events.</a></p>
    <p><a runat="server" href="EventDetails.aspx" > View events. </a></p>
    <p><a runat="server" href="ViewArchiveEvents.aspx" > View Archive events. </a></p>
    <p><a runat="server" href="SearchEvent.aspx" > Search for events. </a></p>
    <p><a runat="server" href="ShareEvent.aspx" > Share an event or a set of events.</a></p>
    <p><a runat="server" href="LoginPage.aspx" > User login and browse shared event.</a></p>
        <br />
        </div>
</asp:Content>
