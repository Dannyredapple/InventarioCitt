<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RequestArticule.aspx.cs" Inherits="Inventory.Presentation.RequestArticule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Solicitar Articulo</h1>
        <div id="Solicitar">
            <table cellpadding="5" style="content:center">
                <tr>
                    <td>Solicitado por:</td>
                    <td><asp:TextBox ID="txtRequestedBy" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtRequestedBy" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage=" *El solicitante no puede tener mas de 40 caracteres" ControlToValidate="txtRequestedBy" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td>Cantidad:</td>
                    <td><asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtQuantity" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage=" *La cantidad no puede ser mas de 50 articulos" ControlToValidate="txtQuantity" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td class="auto-style1">Correro Estudiantil:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
                    <td class="auto-style1"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Obligatorio" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>Articulo:</td>
                    <td><asp:DropDownList ID="ddlAticle" runat="server"></asp:DropDownList></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Autorisado por:</td>
                    <td><asp:DropDownList ID="ddlAuthorized" runat="server"></asp:DropDownList></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Fecha Actual:</td>
                    <td><asp:TextBox ID="txtDateToday" runat="server" TextMode="Date" OnTextChanged="txtDateToday_TextChanged" disabled></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button class="Button" ID="Button1" runat="server" Text="Solicitar" OnClick="Button1_Click" /></td>
                    <td></td>
                </tr>
            </table>
        </div>
    <br />
    <hr />
    <br />
        <h1>Articulos solicitados</h1>
    <asp:GridView ID="gvRequest" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvRequest_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    </center>

</asp:Content>
