<%@ Page Title="Mi Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilEmpresa.aspx.cs" Inherits="NatureEventV2.PerfilEmpresa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="page-content page-container mt-5" style="height:500px;" id="page-content">
    <div class="padding">
        <div class="row container d-flex justify-content-center" >
            <div class="col-xl-10 col-md-10 col-lg-10" >
                <div class="card user-card-full">
                    <div class="row m-l-0 m-r-0" style="height:500px;">
                        <div class="col-sm-4 col-md-4 bg-c-lite-green user-profile">
                            <div class="card-block text-center" style="margin-top:40%">
                                <div class="m-b-25"> <img src="https://img.icons8.com/bubbles/100/000000/user.png" class="img-radius" alt="User-Profile-Image"> </div>
                                <asp:TextBox ID="TextBoxNombreEmpresa" runat="server" Visible="False" ></asp:TextBox>
                                 <asp:Label ID="LabelNombreEmpresa" runat="server" Text="Nombre" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" style="padding:10px;"></asp:Label>
                                </p> 
                            </div>
                        </div>
                        <div class="col-sm-8 col-md-8" style="margin-top:10%">
                            <div class="card-block mt-4">
                                <h6 class="m-b-20 p-b-5 b-b-default f-w-600">Information</h6>
                                <hr  style="width:90%; margin-left:0;"/>
                                <div class="row">
                                    <div class="col-sm-6 mt-4">
                                           <asp:TextBox ID="TextBoxEmail" runat="server" Visible="False" ></asp:TextBox>
                                            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                                    </div>
                                    <div class="col-sm-6 mt-4">
                                         <asp:TextBox ID="TextBoxTelefono" runat="server" Visible="False"></asp:TextBox>
                                         <asp:Label ID="LabelTelefono" runat="server" Text="Teléfono"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-6 mt-4">
                                        <asp:TextBox ID="TextBoxDireccion" runat="server" Visible="False"></asp:TextBox>
                                        <asp:Label ID="LabelDireccion" runat="server" Text="Dirección"></asp:Label>
                                    </div>
                                    <div class="col-sm-6 mt-4 mb-5">                                    
                                        <asp:Label ID="LabelCif" runat="server" Text="CIFEmpresa"></asp:Label>
                                    </div>
                                </div>                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:Button ID="ButtonEditar" runat="server" Text="Editar" style="margin-left:1117px" OnClick="ButtonEditar_Click" />
        </div>
    </div>
</div>
    
</asp:Content>
