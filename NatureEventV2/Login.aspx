<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NatureEventV2.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
 
 <div class="container-fluid">
  <div class="row no-gutter">
   <div class="d-none d-md-flex col-md-4 col-lg-6 bg-image"></div>
    <div class="col-md-8 col-lg-6">
      <div class="login d-flex align-items-center py-5">
        <div class="container">
          <div class="row">
            <div class="col-md-9 col-lg-8 mx-auto">
              <h3 class="login-heading mb-4">Bienvenido!</h3>
              <form>
                <div class="form-label-group ml-4 mb-5">
                  <asp:RadioButtonList class="form-check-input" ID="LoginEmpresaUsuario" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">&nbsp Usuario</asp:ListItem>
                        <asp:ListItem>&nbsp Empresa</asp:ListItem>
                  </asp:RadioButtonList>
                </div>
                  <br>
                <div class="form-label-group">
                  <asp:TextBox class="form-control" ID="InputEmail" aria-describedby="emailHelp" runat="server"></asp:TextBox>
                  <label id="insertEmail" runat="server" for="InputEmail">Email</label>
                  <label id="errorEmail"  runat="server" for="InputEmail" Visible="False">Inserta un email válido</label>
                </div>

                <div class="form-label-group">
                  <asp:TextBox class="form-control" ID="InputPassword" aria-describedby="emailHelp" runat="server" TextMode="Password"></asp:TextBox>
                  <label id="insertPass" runat="server" for="InputPassword">Contraseña</label>
                  <label id="errorPassword" runat="server" for="InputPassword" Visible="False">Inserta una contraseña válida</label>
                </div>
                <div class="custom-control custom-checkbox">
                  <asp:label id="errorLogin" runat="server" Visible="False" Text="Email o contraseña incorrectas"></asp:label>
                </div>
                <asp:Button ID="Button1" runat="server" Class="btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2" OnClick="Button1_Click" Text="Iniciar Sesión" />
                <div class="text-center">
                  <asp:HyperLink class="small" NavigateUrl="RegistroUsuario.aspx" runat="server">¿No tienes una cuenta? Regístrate aquí.</asp:HyperLink></div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
</asp:Content>

