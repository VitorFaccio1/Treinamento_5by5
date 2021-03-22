<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercicio1_PooWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100px;
        }
        .auto-style3 {
            width: 480px;
        }
        .auto-style4 {
            width: 100%;
            height: 288px;
        }
        .auto-style5 {
            margin-right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Pizza hut</h1>
        </div>
        <table class="auto-style4">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Pizzas" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    <asp:BulletedList ID="BulletedList1" runat="server" Height="169px" OnClick="BulletedList1_Click">
                        <asp:ListItem>1)Quatro queijos</asp:ListItem>
                        <asp:ListItem>2)Salame</asp:ListItem>
                        <asp:ListItem>3)Frango com catupiry</asp:ListItem>
                        <asp:ListItem>4)Pepperoni</asp:ListItem>
                        <asp:ListItem>5)Brasileira</asp:ListItem>
                        <asp:ListItem>6)Portuguesa</asp:ListItem>
                        <asp:ListItem>7)Parma</asp:ListItem>
                        <asp:ListItem>8)Brocolis</asp:ListItem>
                        <asp:ListItem>9)Confete</asp:ListItem>
                    </asp:BulletedList>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Procura"></asp:Label>
                    <asp:GridView ID="GVProcura" runat="server" CssClass="auto-style5" Width="509px" OnSelectedIndexChanged="GVProcura_SelectedIndexChanged">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Descrição: </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPizza" runat="server" placeholder="1||2||3||4||5||6||7||8||9" OnTextChanged="txtPizza_TextChanged2"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LblRegistro" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Height="50px" OnClick="Button1_Click2" Text="Remover" Width="125px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="BtnPizza" runat="server" Height="55px" OnClick="Button1_Click1" Text="Pedir Pizza" Width="124px" />
                    <asp:Button ID="BtnProcurar" runat="server" Height="52px" OnClick="Button1_Click" Text="Procurar" Width="115px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GVPizza" runat="server" OnSelectedIndexChanged="GVPizza_SelectedIndexChanged" Width="500px">
        </asp:GridView>
    </form>
    </body>
</html>
