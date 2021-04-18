<%@ Page Language="C#" title="Registro" Masterpagefile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="NatureEventV2.RegistroUsuario"%>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <form>


        <div class="row">
            <div class="col-md-6">
                <br />
            <br />
                <div class="panel panel-default" >
            <h2>Cuenta de Usuario</h2>
                <h5>Permisos de usuario: </h5>
                <ul>
                  <li>Posibilidad de unirse a eventos.</li>
                  <li>Recompensas por participar en actividades</li>
                  <li>HOLI UWU</li>

                </ul>
            <br />
            <br />
            <br />
                </div>
           
            <h2>Cuenta de Registro</h2>
                <h5>Permisos de usuario: </h5>
                <ul>
                  <li>Posibilidad de unirse a eventos.</li>
                  <li>Recompensas por participar en actividades</li>
                  <li>HOLI UWU</li>

                </ul>

            <br />
            <br />
            <a href="Login.aspx">No tienes cuenta? Aqui te dejo un enlace hacia el login!</a>
             
            </div>
            <br />
            <br />
            <br />
            <div class="col-md-6">
                <h2> REGISTRO DE USUARIO</h2>
                    <br />
                    <br />
           <div class="row">
            <div class="col-md-6">
                    
               
             <h6>Nombre</h6>
                    
           
             <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
            <br />
            <h6>DNI</h6>
             <asp:TextBox ID="TxtDNI" runat="server"></asp:TextBox>
             <br />
             <h6>Telefono</h6>
             <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                  <br />
            
            <h6>Contrasenya</h6>
            <asp:TextBox ID="TxtContrasenya" runat="server" SkinID="*"></asp:TextBox>
             </div>
            <div>
          
            <h6>Apellido</h6>
           
            <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
            <br />
           
            <h6>Direccion</h6>
            
            <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            <br />
            <h6>Email</h6>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <br />
            <h6>Repetir contrasenya</h6>
            <asp:TextBox ID="TxtContrasenya2" runat="server" SkinID="*"></asp:TextBox>
            

            <br />
            <h6>Fecha de nacimiento</h6>
            
            <asp:Calendar ID="Fecha" runat="server"></asp:Calendar>
            
            <br />
                <p align="right">
                     <asp:Button ID="BtnValidar" runat="server" Text="Validar" OnClick="validar_click" />
                 </p> 
                </div>
                    </div>
                </div>
        </div>
        </form>--%>

 <div class="container-fluid">
  <div class="row no-gutter">
   <div class="d-none d-md-flex col-md-4 col-lg-6">
    <div class="container">
        <div class="row mt-4">
            <div class="row no-gutters bg-light position-relative">
                <div class="col-md-6 mb-md-0 p-md-4">
                    <img src="..." class="w-100" alt="...">
                </div>
                <div class="col-md-6 position-static p-4 pl-md-0">
                    <h5 class="mt-0">Registro Usuario</h5>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                    <a href="RegistroUsuario.aspx" runat="server" class="stretched-link">Registro Usuario</a>
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="row no-gutters bg-light position-relative">
                <div class="col-md-6 mb-md-0 p-md-4">
                    <img src="..." class="w-100" alt="...">
                </div>
                <div class="col-md-6 position-static p-4 pl-md-0">
                    <h5 class="mt-0">Registro Empresa</h5>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                    <a href="RegistroEmpresa.aspx" runat="server" class="stretched-link">Registro Empresa</a>
                </div>
            </div>
        </div>
    </div>

   </div>
    <div class="col-md-8 col-lg-6">
      <div class="login d-flex align-items-center py-5">
        <div class="container">
          <div class="row">
              <h3 class="login-heading mb-4">REGISTRO DE USUARIO</h3>
              <form>
           </div>
            <div class="row">
                <div class="col-md-6 col-lg-6 mx-auto">
                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtUsuario"  runat="server"></asp:TextBox>
                        <label id="nombreTag" runat="server" for="TxtUsuario">Nombre</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtDNI" runat="server"></asp:TextBox>
                        <label id="dniTag" runat="server" for="TxtDNI">DNI</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtTelefono" runat="server"></asp:TextBox>
                        <label id="Label3" runat="server" for="TxtTelefono">Telefono</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtContrasenya" runat="server"></asp:TextBox>
                        <label id="Label4" runat="server" for="TxtContrasenya">Contrasenya</label>
                    </div>

                    <div class="form-label-group">
                        <asp:Calendar ID="Fecha" runat="server"></asp:Calendar>
                        <label id="Label6" runat="server">Fecha de nacimiento</label>
                    </div>
                </div>
                <div class="col-md-6 col-lg-6 mx-auto">
                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtApellido" runat="server"></asp:TextBox>
                        <label id="apellidoTag" runat="server" for="TxtApellido">Apellido</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtDireccion" runat="server"></asp:TextBox>
                        <label id="Label1" runat="server" for="TxtDireccion">Direccion</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtEmail" runat="server"></asp:TextBox>
                        <label id="Label2" runat="server" for="TxtEmail">E-mail</label>
                    </div>

                    <div class="form-label-group">
                        <asp:TextBox class="form-control" ID="TxtContrasenya2" runat="server"></asp:TextBox>
                        <label id="Label5" runat="server" for="TxtContrasenya2">Repetir contrasenya</label>
                    </div>
                </div>
                </div>
                <asp:Button ID="BtnValidar" runat="server" Class="btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2" OnClick="validar_click" Text="Validar" />
              </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
    
    </asp:Content>

