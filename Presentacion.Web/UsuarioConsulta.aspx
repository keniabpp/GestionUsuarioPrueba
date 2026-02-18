<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioConsulta.aspx.cs" Inherits="Presentacion.Web.UsuarioConsulta" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
<title>Consulta de Usuarios</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="card shadow-sm">
                <div class="card-body">
                    <h2 class="card-title text-center mb-4">Consulta de Usuarios</h2>

                    <asp:Label ID="lblMensaje" runat="server" CssClass="text-success d-block text-center mb-3"></asp:Label>

                    <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"
                        OnRowCommand="gvUsuarios_RowCommand" CssClass="table table-striped table-bordered">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" 
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />


                            <asp:ButtonField ButtonType="Link" CommandName="Modificar" Text="Modificar"
                                HeaderText="Acciones" />
                            <asp:ButtonField ButtonType="Link" CommandName="Eliminar" Text="Eliminar"
                                HeaderText="Acciones"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>

        
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>