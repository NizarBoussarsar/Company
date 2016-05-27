<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormulaireCustomer.aspx.cs" Inherits="CompanyGUI.FormulaireCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    DayTimePhone :
    <asp:TextBox ID="DayTimePhone" runat="server"></asp:TextBox>
    <br />
    EmailAddress :
    <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailAddress" ErrorMessage="Votre email est invalide." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="VG"></asp:RegularExpressionValidator>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="EmailAddress" ErrorMessage="Le champs EmailAddress est obligatoire." ValidationGroup="VG"></asp:RequiredFieldValidator>
    <br />
    IsPerson ?
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
    <hr />
    FirstName :
    <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstName" ErrorMessage="Le champs FirstName est obligatoire." ValidationGroup="VG"></asp:RequiredFieldValidator>
    <br />
    LastName : 
    <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LastName" ErrorMessage="Le champs LastName est obligatoire." ValidationGroup="VG"></asp:RequiredFieldValidator>
    <br />
    Age :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
    &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Age" ErrorMessage="Veuillez saisir un entier entre 0 et 120." MaximumValue="120" MinimumValue="0" Type="Integer" ValidationGroup="VG"></asp:RangeValidator>
&nbsp;<hr />
    CompanyName :
    <asp:TextBox ID="CompanyName" runat="server"></asp:TextBox>
    <br />
    CompanyManager :
    <asp:TextBox ID="CompanyManager" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
</asp:Content>
