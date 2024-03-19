<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RSZIMEDENTSOV.aspx.cs" Inherits="rszi2v2.RSZIMEDENTSOV" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Title</title>
</head>
<body>
    <form runat="server">
           <label>Add new person</label> 
           <asp:TextBox ID="FirstNameBox" runat="server" AutoPostBack="true"></asp:TextBox>
           <asp:TextBox ID="SecondNameBox" runat="server" AutoPostBack="true"></asp:TextBox>
           <asp:Button ID="ButtonPush" runat="server" Text="Push info into the database" OnClick="ButtonPush_Click" />
           <asp:label ID="Label1" runat="server"></asp:label>
</form>
</body>
</html>
