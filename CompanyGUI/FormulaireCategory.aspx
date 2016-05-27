<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormulaireCategory.aspx.cs" Inherits="CompanyGUI.Formulaire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
            <EditItemTemplate>
                CategoryId:
                <asp:TextBox ID="CategoryIdTextBox" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                CategoryName:
                <asp:TextBox ID="CategoryNameTextBox" runat="server" Text='<%# Bind("CategoryName") %>' />
                <br />
                CategoryDescription:
                <asp:TextBox ID="CategoryDescriptionTextBox" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                <br />
                Products:
                <asp:TextBox ID="ProductsTextBox" runat="server" Text='<%# Bind("Products") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Name:
                <asp:TextBox ID="CategoryNameTextBox" runat="server" Text='<%# Bind("CategoryName") %>' />
                <br />
                Description:
                <asp:TextBox ID="CategoryDescriptionTextBox" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                CategoryId:
                <asp:Label ID="CategoryIdLabel" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                CategoryName:
                <asp:Label ID="CategoryNameLabel" runat="server" Text='<%# Bind("CategoryName") %>' />
                <br />
                CategoryDescription:
                <asp:Label ID="CategoryDescriptionLabel" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                <br />
                Products:
                <asp:Label ID="ProductsLabel" runat="server" Text='<%# Bind("Products") %>' />
                <br />
                <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CompanyDomain.Entities.Category" InsertMethod="AddCategory" SelectMethod="GetAllCategories" TypeName="CompanyService.CompanyService"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:FormView ID="FormView2" runat="server" DataSourceID="ObjectDataSource1">
            
            <InsertItemTemplate>
                CategoryId:
                <asp:TextBox ID="CategoryIdTextBox" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                CategoryName:
                <asp:TextBox ID="CategoryNameTextBox" runat="server" Text='<%# Bind("CategoryName") %>' />
                <br />
                CategoryDescription:
                <asp:TextBox ID="CategoryDescriptionTextBox" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                <br />
                Products:
                <asp:TextBox ID="ProductsTextBox" runat="server" Text='<%# Bind("Products") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                CategoryId:
                <asp:Label ID="CategoryIdLabel" runat="server" Text='<%# Bind("CategoryId") %>' />
                <br />
                CategoryName:
                <asp:Label ID="CategoryNameLabel" runat="server" Text='<%# Bind("CategoryName") %>' />
                <br />
                CategoryDescription:
                <asp:Label ID="CategoryDescriptionLabel" runat="server" Text='<%# Bind("CategoryDescription") %>' />
                <br />
                Products:
                <asp:Label ID="ProductsLabel" runat="server" Text='<%# Bind("Products") %>' />
                <br />
                <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
    </form>

</body>
</html>
