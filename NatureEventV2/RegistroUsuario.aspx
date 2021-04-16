<%@ Page Language="C#" title="Registro" Masterpagefile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="NatureEventV2.RegistroUsuario"%>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>


        <div class="row">
            <div class="col-md-4">
                <br />
                <a  href="~/Contact">
                 <asp:Image ID="Image2" runat="server" Height="35px" ImageUrl="~/Content/img/volver.jpg" Width="35px"/>
                <a />
            </div>
            <div class="col-md-4" align="center">
            <h4>Usuario</h4>
           
           
            <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
          
            <br />
            <h4>Apellido</h4>
           
            <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
            <br />
            <h4>Email</h4>
           
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LblEmail" runat="server"></asp:Label>
            <br />
            
            <h4>DNI</h4>
            
            <asp:TextBox ID="TxtDNI" runat="server"></asp:TextBox>
            <asp:Label ID="LblDNI" runat="server"></asp:Label>
            
                <br />
                <br />
                <br />
                Telefono<br />
                <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                <asp:Label ID="LblTelefono" runat="server" Text="Label"></asp:Label>
                <br />
            
            <br />
            <h4>Direccion</h4>
            
            <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            <br />
            <h4>Contrasenya</h4>
            <asp:TextBox ID="TxtContrasenya" runat="server" SkinID="*"></asp:TextBox>
            <br />
            <h4>Repetir contrasenya</h4>
            <asp:TextBox ID="TxtContrasenya2" runat="server" SkinID="*"></asp:TextBox>
            <asp:Label ID="LblMensaje" runat="server"></asp:Label>
            
            <br />
            <h4>Fecha de nacimiento</h4>
            
            <asp:Calendar ID="Fecha" runat="server"></asp:Calendar>
            
            <br />
            <asp:Button ID="BtnValidar" runat="server" Text="Validar" OnClick="validar_click" />
            <br />
            <br />
            <br />
            <br />
                </div>
        </div>
        </form>
    </a>
    </asp:Content>

