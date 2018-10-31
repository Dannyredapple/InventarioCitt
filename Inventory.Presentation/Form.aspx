<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Inventory.Presentation.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div id="formulario">
            <h1>Formulario de Articulo</h1>
            <br />
            <table cellpadding="5">
                 <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="ID:" AssociatedControlID="txtID"></asp:Label></td>
                    <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Nombre:" AssociatedControlID="txtName"></asp:Label></td>
                        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage=" *No puede tener mas de 30 caracteres" ControlToValidate="txtName" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblStock" runat="server" Text="Stock:" AssociatedControlID="txtStock" ></asp:Label></td>
                    <td><asp:TextBox ID="txtStock" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtStock" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage=" *El objeto no puede tener un stock menor a 0" ControlToValidate="txtStock" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblDesc" runat="server" Text="Descripcion:" AssociatedControlID="txtDesc"></asp:Label>:</td>
                    <td><asp:TextBox ID="txtDesc" runat="server"></asp:TextBox></td>
                    <td> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtDesc" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage=" *no debe tener mas de 100 caracteres" ControlToValidate="txtDesc" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblDrawer" runat="server" Text="Cubiculo:" AssociatedControlID="txtName"></asp:Label></td>
                    <td><asp:DropDownList ID="ddlDrawer" runat="server" OnSelectedIndexChanged="ddlDrawer_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCrear" runat="server" Text=""></asp:Label></td>
                    <td><asp:Button class="Button" ID="btnAdd" runat="server" Text="Agregar" OnClick="Button1_Click" /></td>
                    <td><asp:Button class="Button" ID="btnRead" runat="server" Text="Leer"  />
                    <asp:Button class="Button" ID="btnUpdate" runat="server" Text="Actualizar"  />
                    <asp:Button class="Button" ID="btndelete" runat="server" Text="Delete"  /></td>
                </tr>
            </table>
        </div>
    </center>

</asp:Content>
