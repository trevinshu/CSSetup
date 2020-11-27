<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimplyQuery.aspx.cs" Inherits="WebApp.SamplePages.SimplyQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <br /><br />
    <asp:TextBox ID="RegionArg" runat="server"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="RegionSearch" runat="server" Text="Region Search" OnClick="RegionSearch_Click" />
    <br /><br />

    <asp:DropDownList ID="RegionsDDL" runat="server"></asp:DropDownList>&nbsp;&nbsp;<asp:Button ID="RegionDDLSearch" runat="server" Text="Region Search" OnClick="RegionDDLSearch_Click" />
    <br /><br />

    <asp:Label ID="RegionID" runat="server" ></asp:Label><br />
    <asp:Label ID="RegionDescription" runat="server" ></asp:Label>
    <br /><br />

    <asp:GridView ID="AllRegions" runat="server"></asp:GridView>
   
</asp:Content>
