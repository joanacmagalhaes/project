<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="NatureEventV2.Asistencia" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="submenu" class="mt-2 mb-5" style=" height:4%; ">
            <p><a style="color:gray;" href="HistorialEventos.aspx">Historial Eventos</a> &nbsp > &nbsp <a style="color:gray;">Evento</a> &nbsp > &nbsp  <b style="color:darkslategray">Asistencia</b></p>
    </div>
    <div class="container">
        <asp:Panel ID="ContentArea" runat="server">
        </asp:Panel>
        <asp:Button ID="guardarAsistencia" runat="server" Text="Guardar" OnClick="ButtonAsistencia_Click"/>
    </div>
    
</asp:Content> 