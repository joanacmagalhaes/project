<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilEmpresa.aspx.cs" Inherits="NatureEventV2.PerfilEmpresa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <br /><br />
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
                            <asp:TextBox ID="TextBoxNombreEmpresa" runat="server" Visible="False" ></asp:TextBox>
                            <asp:Label ID="LabelNombreEmpresa" runat="server" Text="NombreEmpresa" ></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxEmail" runat="server" Visible="False" ></asp:TextBox>
                            <asp:Label ID="LabelEmail" runat="server" Text="EmailEmpresa"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxTelefono" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelTelefono" runat="server" Text="TeléfonoEmpresa"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:TextBox ID="TextBoxDireccion" runat="server" Visible="False"></asp:TextBox>
                            <asp:Label ID="LabelDireccion" runat="server" Text="DirecciónEmpresa"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <br />
                            <asp:Label ID="LabelCif" runat="server" Text="CIFEmpresa"></asp:Label>
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
