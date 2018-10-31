<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartSession.aspx.cs" Inherits="Inventory.Presentation.StartSession" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Css/Main.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Inventario CITT</title>
</head>
<body>
    <header>
        <h3 style="text-decoration:none;>
            <a href="index.aspx"> 
            <img src="img/CITT.jpg"/>
        </a>
        </h3>
    </header>
    <br />
    <form id="form1" runat="server">
        <center>
            <main>
                <h1>Inicio</h1>
                <div id="Login">
                    <table>
                        <tr>
                            <td><asp:Label ID="UserLogin" runat="server" Text="Usuario" AssociatedControlID="txtLogin"></asp:Label></td>
                            <td><asp:TextBox ID="txtLogin" runat="server"></asp:TextBox></td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvUser" runat="server" ErrorMessage="Obligatorio" ControlToValidate="txtLogin" ForeColor="Red"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="PassLogin" runat="server" Text="Contraseña" AssociatedControlID="txtPass"></asp:Label></td>
                            <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvPass" runat="server" ErrorMessage="Obligatorio" ControlToValidate="txtPass" ForeColor="Red" ></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><asp:Button class="Button" ID="btnLogin" runat="server" Text="Iniciar" OnClick="btnLogin_Click"/></td>
                        </tr>
                    </table>
                </div>
                <asp:Label ID="lblCatch" runat="server"  Visible="false"></asp:Label>
            </main>   
        </center>
    </form>
    <br />

<footer class="page-footer font-small teal pt-4">

    <!-- Footer Text -->
    <div class="container-fluid text-center text-md-left">

      <!-- Grid row -->
      <div class="row">

        <!-- Grid column -->
        <div class="col-md-6 mb-md-0 mb-3">

          <!-- Content -->
          <h5 class="text-uppercase font-weight-bold">Informaciones:</h5>
            <table>
             <tr>
                <td>Ubicacion:</td>
                <td>Torre N°2, Segundo piso</td>
            </tr>
            <tr>
                <td>Correo:</td>
                <td>Citt.maipu20xx@gmail.com</td>
            </tr>
            <tr>
                <td>Cordinador CITT:</td>
                <td>Jean Paul Fuentes Tognarelli</td>
            </tr>
            </table>
        </div>
        <!-- Grid column -->

      </div>
      <!-- Grid row -->

    </div>
    <!-- Footer Text -->
    <br />
    <div class="footer-copyright text-center py-3">© 2018 Inventario CITT
    </div>

  </footer>
  <!-- Footer -->
</body>
</html>
