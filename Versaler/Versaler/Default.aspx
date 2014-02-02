<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
    
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextArea" runat="server" ViewStateMode="Disabled" TextMode="MultiLine"></asp:TextBox>
          
            <asp:Button ID="Button" runat="server" Text="Bestäm antalet versaler" OnClick="Button_Click" Visible="True" ViewStateMode="Inherit" />
            
                <asp:Label ID="Label" runat="server" Text="" ViewStateMode="Disabled"></asp:Label>
           
        </div>
    </form>
</body>
</html>
