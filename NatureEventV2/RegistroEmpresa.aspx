<%@ Page Language="C#" AutoEventWireup="true"  Masterpagefile="~/Site.Master" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="NatureEventV2.RegistroEmpresa" %>


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


            <a href="Login.aspx">No tienes cuenta? Aqui te dejo un enlace hacia el login!</a>
         ´<br />
         ´<br />
         ´<br />
         ´<br />
         ´<br />
         ´<br />
         ´<br />

            </div>
            <div class="col-md-6">
                <h2> REGISTRO DE EMPRESA</h2>
                    <br />
                    <br />
            <div class="row">
            <div class="col-md-6">
            <h4>Nombre</h4>
            <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
          
            <br />
             <h4>Direccion</h4>
            
            <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
                <br />

            <h4>Email</h4>
           
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <br />
            <h4>Contrasenya</h4>
            <asp:TextBox ID="TxtContrasenya" runat="server" SkinID="*"></asp:TextBox>
            <br />
                  <br />
            <asp:Button ID="BtnValidar" runat="server" Text="Validar" OnClick="validar_empresa_click" />
            <br />
                </div>
             <div>
            <h4>CIF</h4>
            
            <asp:TextBox ID="TxtCIF" runat="server"></asp:TextBox>

        
                <br />
                <h4>Telefono</h4>
                <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                <br />         
           
            <h4>Repetir contrasenya</h4>
            <asp:TextBox ID="TxtContrasenya2" runat="server" SkinID="*"></asp:TextBox>
                <br />
            
          

            </div>
          </div>
        </div>
        </form>
 
    </asp:Content>


