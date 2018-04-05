<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Scripts>
                    <asp:ScriptReference Path="Scripts/jquery-3.3.1.min.js" />
                </Scripts>
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            <asp:Image ID="Image1" runat="server" Height="176px" ImageUrl="~/Images/loadon.gif" Width="199px" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </ContentTemplate>
               
            </asp:UpdatePanel>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Button" />
            </ContentTemplate>

        </asp:UpdatePanel>
        <br />
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" Width="492px">
            <asp:ListItem>computer</asp:ListItem>
            <asp:ListItem>keyboard</asp:ListItem>
            <asp:ListItem>Mouse</asp:ListItem>
        </asp:DropDownList>
        <br />
        
    </form>
</body>
</html>
