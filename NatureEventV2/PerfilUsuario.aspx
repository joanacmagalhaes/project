<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="NatureEventV2.PerfilUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        
        <h2><%: Title %></h2>
        <div class="panel panel-default">
            <div class="panel-body">
                <div class="container col-md-2">
                    <div>
                        <asp:Image ID="Image1" runat="server" Height="85px" Width="100px" />
                    </div>
                </div>
                <div class="container col-md-10">
                    <div class="row">
                        <div class="col-md-2">
                            <asp:TextBox ID="TextBoxNombre" runat="server" Visible="False" ></asp:TextBox>
                            <asp:Label ID="LabelNombre" runat="server" Text="Nombre" ></asp:Label>
                        </div>
                        <div class="col-md-2">
                            <asp:TextBox ID="TextBoxApellidos" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelApellidos" runat="server" Text="Apellidos"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxEmail" runat="server" Visible="False" ></asp:TextBox>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxTelefono" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelTelefono" runat="server" Text="Teléfono"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxDireccion" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelDireccion" runat="server" Text="Dirección"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxDni" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelDni" runat="server" Text="Dni"></asp:Label>
                        </div>
                    </div>
                    
                </div>
                
                
                <!--
                <br /><br />
                <br /><br />
                -->

            </div>
        </div>
        
        <br />
        <asp:Button ID="ButtonEditar" runat="server" Text="Editar" style="margin-left:1117px" OnClick="ButtonEditar_Click" />

    </div>
</asp:Content>
