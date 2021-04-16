<%@ Page Language="C#" AutoEventWireup="true"  Masterpagefile="~/Site.Master" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="NatureEventV2.RegistroEmpresa" %>


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
            <h4>Email</h4>
           
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LblEmail" runat="server"></asp:Label>
            <br />
            
            <h4>CIF</h4>
            
            <asp:TextBox ID="TxtCIF" runat="server"></asp:TextBox>
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
            
            <br />
            <asp:Button ID="BtnValidar" runat="server" Text="Validar" OnClick="validar_empresa_click" />
            <br />
            <br />
            <br />
            <br />
                </div>
        </div>
        </form>
    </a>
    </asp:Content>


