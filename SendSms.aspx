<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendSms.aspx.cs" Inherits="SendSms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Mobile
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password" style="margin-bottom: 0px"></asp:TextBox>
             </div>
                To Mobile<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
              <p>
              Msg
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

