<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaEvento.aspx.cs" Inherits="NatureEventV2.PaginaEvento" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="card-block text-center">
                        <p>
                            <asp:TextBox ID="TextBoxNombreEvento" runat="server" Visible="false"></asp:TextBox>
                            <h3><asp:Label ID="LabelNombreEvento" runat="server" Text="Nombre"></asp:Label></h3>
                        </p>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center">
                        <asp:Label ID="LabelDescripcion" runat="server"></asp:Label>
                        <asp:TextBox ID="TextDescripcion" runat="server" Visible="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row mt-3">
                    <div class="card-block text-center">
                        <b>Inicio</b>
                        <asp:TextBox ID="TextFechaInicio" runat="server" Visible="false"></asp:TextBox>
                        <asp:Label ID="LabelFechaInicio" runat="server"></asp:Label>
                    </div>
                    <div class="card-block text-center ml-4">
                        <b>Hasta</b>
                        <asp:TextBox ID="TextFechaFinal" runat="server" Visible="false"></asp:TextBox>
                        <asp:Label ID="LabelFechaFinal" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center mt-3">
                        <b>Direcion</b>
                        <asp:Label ID="LabelDirecionEvento" runat="server"></asp:Label>
                        <asp:TextBox ID="TextDirecionEvento" runat="server" Visible="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center mt-3">
                        <asp:Button ID="ButtonEditar" runat="server" Text="Editar" Visible="false" OnClick="ButtonEditar_Click" />
                    </div>
                     <div class="card-block text-center mt-3">
                        <asp:Button ID="ButAsistencia" runat="server" Text="Asistencia" Visible="false" PostBackUrl="~/Asistencia.aspx" />
                    </div>
                </div>
            </div>
            <div>
                <div>
                    <div class="m-b-25"> 
                        <img src="https://picsum.photos/500" class="img-radius" > </div>
                        
                       <%-- <p class="mt-2"> <asp:Button ID="ButtonEditar" runat="server" Text="Editar" OnClick="ButtonEditar_Click" /></p>--%>
                </div> 
            </div>
        </div>
    </div>

</asp:Content>
