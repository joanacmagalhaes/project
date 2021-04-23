<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="NatureEventV2.Asistencia" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Panel ID="ContentArea" runat="server">
        </asp:Panel>
        <asp:Button ID="guardarAsistencia" runat="server" Text="Guardar" OnClick="ButtonAsistencia_Click"/>
    </div>
    <asp:CheckBox />
</asp:Content> 