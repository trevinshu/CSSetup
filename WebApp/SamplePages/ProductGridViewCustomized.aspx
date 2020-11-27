<%@ Page Title="Customized Grid View" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductGridViewCustomized.aspx.cs" Inherits="WebApp.SamplePages.ProductGridViewCustomized" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <asp:GridView ID="ProductGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="ProductGrid_PageIndexChanging" PageSize="5">
        <Columns>
            <asp:TemplateField HeaderText="Product ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Product Name">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Supplier ID">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("SupplierID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Category ID">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("CategoryID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Quantity/Unit">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("QuantityPerUnit") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Unit Price">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("UnitPrice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Discontinued">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("Discontinued") %>' Enabled="<%# false %>" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Crazy Price">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# "Wow! Crazy Price is: "+ Eval("UnitPrice") %>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Formatted Unit Price">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("UnitPrice") + "Formatted is " + string.Format("{0:0.00}",Eval("UnitPrice")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
