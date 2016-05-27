<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormulaireProduct.aspx.cs" Inherits="CompanyGUI.FormulaireProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
        Name : <input type="text" id="ProductName" name="ProductName" runat="server" />
        Description : <input type="text" id="Description" name="Description" runat="server" />
        UnitPrice : <input type="number" id="UnitPrice" name="UnitPrice" runat="server" />
        File : <input type="file" id="File1" name="File1" runat="server" />
        <br />
        <input type="submit" id="Submit1" value="Upload" runat="server" name="Submit1" />
    </form>
</body>
</html>
