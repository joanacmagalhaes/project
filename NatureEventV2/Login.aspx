<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NatureEventV2.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <form>
        <div class="container">
        <div class="row justify-content-md-center">
            <div class="col-md-3 col-lg-3"></div>
            <div class="col-md-6 col-lg-6">
                <div class="form-group">
                    <asp:RadioButtonList class="form-check-input" ID="LoginEmpresaUsuario" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Usuario</asp:ListItem>
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
        </div>
    </form>
</asp:Content>

