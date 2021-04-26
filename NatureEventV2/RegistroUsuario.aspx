<%@ Page Language="C#" Title="Registro" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="NatureEventV2.RegistroUsuario" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <div class="row no-gutter">
            <div class="d-none d-md-flex col-md-4 col-lg-6">
                <div class="container">
                    <div class="row mt-4">
                        <div class="row no-gutters bg-light position-relative">
                            <div class="col-md-6 mb-md-0 p-md-4">
                                <img src="https://picsum.photos/id/1050/300/400" class="w-100" alt="...">
                            </div>
                            <div class="col-md-6 position-static p-4 pl-md-0">
                                <h5 class="mt-0">Registro Usuario</h5>
                                <p>Registrarse como usuario para poder acceder a los eventos, y ser parte de una comunidad que trabaja para mejorar este mundo al que pertenecemos. Al participar en eventos ganarás puntos y podrás canjearlos por premios. ¿A qué esperas para empezar?</p>
                            </div>
                        </div>
                    </div>
                    <div class="row mt-3">
                        <div class="row no-gutters bg-light position-relative">
                            <div class="col-md-6 mb-md-0 p-md-4">
                                <img src="https://picsum.photos/id/3/300/400" class="w-100" alt="...">
                            </div>
                            <div class="col-md-6 position-static p-4 pl-md-0">
                                <h5 class="mt-0">Registro Empresa</h5>
                                <p>Regístrese como empresa para poder sumar todos los eventos enfocados a la preservación del medio ambiente. Sea la razón por la que nuestros usuarios quieren aspirar a un mundo mejor.</p>
                                <a href="RegistroEmpresa.aspx" runat="server" class="stretched-link">Registro Empresa</a>
                            </div>
                        </div>
                    </div>
                    <a href="Login.aspx" runat="server">¿Ya tienes cuenta? ¡Aquí te dejo un enlace hacia el login!</a>
                </div>

            </div>
            <div class="col-md-8 col-lg-6">
                <div class="login d-flex align-items-center py-5">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <h3 class="login-heading mb-4">REGISTRO DE USUARIO</h3>
                            </div>
                            <div class="col-md-6 col-lg-6 mx-auto">
                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtUsuario" runat="server"></asp:TextBox>
                                    <label id="nombreTag" runat="server" for="TxtUsuario">Nombre</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtDNI" runat="server"></asp:TextBox>
                                    <label id="dniTag" runat="server" for="TxtDNI">DNI</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtTelefono" runat="server"></asp:TextBox>
                                    <label id="Label3" runat="server" for="TxtTelefono">Teléfono</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtContrasenya" runat="server" TextMode="Password"></asp:TextBox>
                                    <label id="Label4" runat="server" for="TxtContrasenya">Contraseña</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox ID="TxtFecha" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                                    <label id="Label6" runat="server">Fecha de nacimiento</label>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-6 mx-auto">
                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtApellido" runat="server"></asp:TextBox>
                                    <label id="apellidoTag" runat="server" for="TxtApellido">Apellidos</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtDireccion" runat="server"></asp:TextBox>
                                    <label id="Label1" runat="server" for="TxtDireccion">Dirección</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtEmail" runat="server"></asp:TextBox>
                                    <label id="Label2" runat="server" for="TxtEmail">Email</label>
                                </div>

                                <div class="form-label-group">
                                    <asp:TextBox class="form-control" ID="TxtContrasenya2" runat="server" TextMode="Password"></asp:TextBox>
                                    <label id="Label5" runat="server" for="TxtContrasenya2">Repetir Contraseña</label>
                                </div>
                            </div>
                        </div>
                        <asp:Button ID="BtnValidar" runat="server" Class="btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2" OnClick="validar_click" Text="Registrar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</asp:Content>

