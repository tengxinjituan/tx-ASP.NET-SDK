<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>短信发送示例</title>
</head>
<body>
    <form id="form1" runat="server">
   <div>

        <asp:Label ID="Label1" runat="server" Text="用户名:" Width="69px" Height="20px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="密码:" Width="73px"></asp:Label><asp:TextBox
            ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="手机:" Width="73px"></asp:Label><asp:TextBox
            ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="内容:" Width="73px"></asp:Label><asp:TextBox
            ID="TextBox4" runat="server" Height="104px" Width="157px" TextMode="MultiLine"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" Text="发送" OnClick="Button1_Click" />
     
       </div>   
    </form>
</body>
</html>
