<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Visitor.aspx.cs" Inherits="Visitor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
        <div>
            <asp:Image ID="img" runat="server" />
        </div>
    </form>
</body>
</html>
