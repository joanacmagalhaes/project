<%@ Page Language="C#" title="Registro" Masterpagefile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="NatureEventV2.RegistroUsuario"%>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>


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
        </form>
    </a>
    </asp:Content>

