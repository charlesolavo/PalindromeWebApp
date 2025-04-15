<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verificador de Palíndromos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Type a number:
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnCheck" Text="Verificar" runat="server" OnClick="btnCheck_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" />
        </div>
    </form>
</body>
</html>
