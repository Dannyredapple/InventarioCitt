<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InventoryView.aspx.cs" Inherits="Inventory.Presentation.InventoryView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Vista de objetos agregados</h2>
    <table>
        <tr>
            <td><asp:GridView ID="gvLista" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
    </asp:GridView></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div id="formLeader">
        <table>
            <tr>
                <th><asp:Button class="Button" ID="btnEditar" runat="server" Text="Editar"/></th >
                <th><asp:Button class="Button" ID="btnEliminar" runat="server" Text="Eliminar" /></th>
            </tr>
        </table>
    </div>
    </asp:Content>
