<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewLeader.aspx.cs" Inherits="Inventory.Presentation.NewLeader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista de Capitanes</h1>
    <div>
        <center>
            <table cellpadding="5">
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblRut" runat="server" Text="Rut" ></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="txtRut" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td class="auto-style1"><asp:TextBox ID="txtDV" runat="server" MaxLength="1"></asp:TextBox></td>
                    <td class="auto-style1"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtName"></asp:RequiredFieldValidator> </td>
                    <td><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="*Rut Invalido" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="txtRut"></asp:CustomValidator></td>
                    </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="lblName" runat="server" Text="Nombre"></asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    <td class="auto-style1"><asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtName"></asp:RequiredFieldValidator> </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblWorkingDay" runat="server" Text="Jornada"></asp:Label></td>
                    <td><asp:DropDownList ID="ddlWorkingDay" runat="server"></asp:DropDownList></td>
                    <td></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblCarrea" runat="server" Text="Carrera"></asp:Label></td>
                    <td><asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvCarrera" runat="server" ErrorMessage="*Obligatorio " ControlToValidate="txtCarrera"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblJob" runat="server" Text="Cargo"></asp:Label></td>
                    <td><asp:DropDownList ID="ddlJob" runat="server"></asp:DropDownList></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button class="Button" ID="btnAdd" runat="server" Text="Agregar" OnClick="Button1_Click" /></td>
                    <td><asp:Label ID="lblCrear" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </center>
    </div>
    <br />
    <hr />
</asp:Content>
