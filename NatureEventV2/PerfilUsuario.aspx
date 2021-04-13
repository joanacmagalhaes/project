<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="NatureEventV2.PerfilUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    
    <asp:Panel ID="Panel1" runat="server" Height="132px">
        <asp:TextBox ID="TextBoxNombre" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBoxApellidos" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:Label ID="LabelApellidos" runat="server" Text="Apellidos"></asp:Label><br />
        <asp:TextBox ID="TextBoxEmail" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
        <asp:TextBox ID="TextBoxTelefono" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="LabelTelefono" runat="server" Text="Teléfono"></asp:Label><br />
        <asp:TextBox ID="TextBoxDireccion" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="LabelDireccion" runat="server" Text="Dirección"></asp:Label><br />
        <asp:TextBox ID="TextBoxDni" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="LabelDni" runat="server" Text="Dni"></asp:Label>
        
    </asp:Panel>
    <asp:Button ID="ButtonEditar" runat="server" Text="Editar" style="margin-left:760px" OnClick="ButtonEditar_Click" />
    
</asp:Content>
