<%@ Page Title="ODS Example" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObjectDataSourceExample.aspx.cs" Inherits="WebApp.SamplePages.ObjectDataSourceExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br />
    <asp:GridView ID="ProductList" runat="server" AutoGenerateColumns="False" DataSourceID="ProductDataSource">
        <Columns>
            <asp:TemplateField HeaderText="ProductID" SortExpression="ProductID">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProductID") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName"></asp:BoundField>
            <asp:TemplateField HeaderText="SupplierID" SortExpression="SupplierID">
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID"></asp:BoundField>
            <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit"></asp:BoundField>
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice"></asp:BoundField>
            <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock"></asp:BoundField>
            <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder"></asp:BoundField>
            <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" SortExpression="ReorderLevel"></asp:BoundField>
            <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued"></asp:CheckBoxField>
            <asp:BoundField DataField="ProductNameScream" HeaderText="ProductNameScream" ReadOnly="True" SortExpression="ProductNameScream"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <br /><br /><br />
    <asp:DropDownList ID="RegionDDL" runat="server" DataSourceID="RegionDataSource" DataTextField="RegionDescription" DataValueField="RegionID"></asp:DropDownList>

    <asp:ObjectDataSource ID="RegionDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllRegions" TypeName="NorthwindSystem.BLL.RegionController"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="ProductDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllProducts" TypeName="NorthwindSystem.BLL.ProductController"></asp:ObjectDataSource>
</asp:Content>
