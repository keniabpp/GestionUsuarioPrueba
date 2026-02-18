<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioModificar.aspx.cs" Inherits="Presentacion.Web.UsuarioModificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modificar Usuario</title>

     <style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f7f7f7;
        margin: 0;
        padding: 0;
    }

    .card {
        background-color: #fff;
        max-width: 350px;
        width: 100%;
        margin: 50px auto;
        padding: 20px 30px;
        border-radius: 8px;
        box-shadow: 0 2px 10px rgba(0,0,0,0.2);
    }

    h2 {
        text-align: center;
        color: #333;
        margin-bottom: 20px;
    }

    .form-group {
        margin-bottom: 15px;
    }

    input[type="text"], input[type="date"], select, .form-control {
        width: 100%;
        padding: 8px;
        border-radius: 5px;
        border: 1px solid #ccc;
        box-sizing: border-box;
    }

    .btn {
        width: 100%;
        padding: 10px;
        background-color: #007bff;
        color: white;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        font-size: 16px;
    }

    .btn:hover {
        background-color: #0056b3;
    }

    #lblMensaje {
        text-align: center;
        font-weight: bold;
        display: block;
        margin-top: 15px;
    }
</style>


</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h2> Modificar Usuarios</h2>

            <div class="form-group">
            Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" 
            ErrorMessage="El nombre es requerido." ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
            Fecha de Nacimiento: <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" 
            ControlToValidate="txtFechaNacimiento" ErrorMessage="La Fecha de Nacimiento es requerido." 
            ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
            Sexo: <asp:DropDownList ID="ddlSexo" runat="server">
                     <asp:ListItem Value="">Seleccione</asp:ListItem>
                     <asp:ListItem Value="M">M</asp:ListItem>
                     <asp:ListItem Value="F">F</asp:ListItem>
                     <asp:ListItem Value="O">O</asp:ListItem>
                  </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvSexo" runat="server" 
           ControlToValidate="ddlSexo" InitialValue="" ErrorMessage="El sexo es obligatorio." 
           ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
           </div>

            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn" OnClick="btnModificar_Click" 
            CausesValidation="true" />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>


        </div>
    </form>
</body>
</html>
