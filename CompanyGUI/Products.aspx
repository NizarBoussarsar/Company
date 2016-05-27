<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="CompanyGUI.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
        </Columns>
    </asp:GridView>

    <br />

    Description :
    <asp:DropDownList ID="minProducts" runat="server" AutoPostBack="true">
        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
        <asp:ListItem Value="3"></asp:ListItem>
        <asp:ListItem Value="5"></asp:ListItem>
        <asp:ListItem Value="10"></asp:ListItem>
    </asp:DropDownList>

    <br />

    <br />

    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" SelectMethod="GetCategories" >
        <Columns>
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
            <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
            <asp:BoundField DataField="CategoryDescription" HeaderText="CategoryDescription" SortExpression="CategoryDescription" />
            <asp:BoundField DataField="Products.Count" HeaderText="Products" SortExpression="Products" />
            <asp:HyperLinkField HeaderText="Links" DataTextField="CategoryName" DataNavigateUrlFields="CategoryId" DataNavigateUrlFormatString="~/Products.aspx?id={0}" NavigateUrl="~/Products.aspx" />
        </Columns>
        <EmptyDataTemplate>
            No categories found with a product count of <%#: minProducts.SelectedValue %>
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CompanyDomain.Entities.Product" InsertMethod="AddProoduct" SelectMethod="GetAllProducts" TypeName="CompanyService.CompanyService"></asp:ObjectDataSource>
    <br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" SelectMethod="GetProductsByCategory">
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="ProductId" SortExpression="ProductId" />
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
        </Columns>
    </asp:GridView>
    <br />
</asp:Content>
