<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HIstorialEventos.aspx.cs" Inherits="NatureEventV2.HIstorialEventos" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
body{
    font-family:'Segoe UI';
}
.footer{
    margin-top:10%;
}

#MainContent_ContentArea{
    min-height:500px;
}
</style>
    <div class="container" runat="server" style="width:100%;">
            <h3 style="margin:auto; width:50%; margin-top:5%; margin-bottom:4%; text-align:center;">Eventos</h3>
            <asp:Panel ID="ContentArea" runat="server">

            </asp:Panel>
     </div>
</asp:Content>
