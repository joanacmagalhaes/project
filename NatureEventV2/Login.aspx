<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NatureEventV2.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    
        <%--<div class="container">
        <div class="row justify-content-md-center">
            <div class="col-md-3 col-lg-3"></div>
            <div class="col-md-6 col-lg-6">
                <div class="form-group">
                    <asp:RadioButtonList class="form-check-input" ID="LoginEmpresaUsuario" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">Usuario</asp:ListItem>
                        <asp:ListItem>Empresa</asp:ListItem>
                    </asp:RadioButtonList>
                    <label for="InputEmail">Email address</label>
                    <asp:TextBox class="form-control" ID="InputEmail" aria-describedby="emailHelp" runat="server"></asp:TextBox>
                    <asp:Label ID="errorEmail" runat="server" Text="Insert a Valid Email" Visible="False"></asp:Label>
                </div>
                <div class="form-group">
                    <label for="InputPassword">Password</label>
                    <asp:TextBox class="form-control" ID="InputPassword" aria-describedby="emailHelp" runat="server"></asp:TextBox>
                    <asp:Label ID="errorPassword" runat="server" Text="Insert a Valid Password" Visible="False"></asp:Label>
                </div>
                <asp:Label ID="errorLogin" runat="server" Text="Incorrect Password or E-mail" Visible="False"></asp:Label>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Send" />
            </div>
            <div class="col-md-3 col-lg-3"></div>
          </div>
        </div>--%>
        <div class="container-fluid">
  <div class="row no-gutter">
    <div class="d-none d-md-flex col-md-4 col-lg-6 bg-image"></div>
    <div class="col-md-8 col-lg-6">
      <div class="login d-flex align-items-center py-5">
        <div class="container">
          <div class="row">
            <div class="col-md-9 col-lg-8 mx-auto">
              <h3 class="login-heading mb-4">Welcome back!</h3>
              <form>
                <div class="form-label-group mb-5">
                  <asp:RadioButtonList class="form-check-input" ID="LoginEmpresaUsuario" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">Usuario</asp:ListItem>
                        <asp:ListItem>Empresa</asp:ListItem>
                  </asp:RadioButtonList>
                </div>

                <div class="form-label-group mt-5">
                  <asp:TextBox class="form-control" ID="InputEmail" aria-describedby="emailHelp" runat="server"></asp:TextBox>
                  <label id="insertEmail" runat="server" for="InputEmail">Email address</label>
                  <label id="errorEmail" runat="server" for="InputEmail" Visible="False">Insert a Valid Email</label>
                </div>

                <div class="form-label-group">
                  <asp:TextBox class="form-control" ID="InputPassword" aria-describedby="emailHelp" runat="server"></asp:TextBox>
                  <label id="insertPass" runat="server" for="InputPassword">Password</label>
                  <label id="errorPassword" runat="server" for="InputPassword" Visible="False">Insert a Valid Password</label>
                </div>
                <div class="custom-control custom-checkbox">
                  <label id="errorLogin" runat="server" Visible="False">Incorrect Password or E-mail</label>
                </div>
                <asp:Button ID="Button1" runat="server" Class="btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2" OnClick="Button1_Click" Text="Sign in" />
                <div class="text-center">
                  <a class="small" href="#">Don't have an account? Register here</a></div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
</asp:Content>

