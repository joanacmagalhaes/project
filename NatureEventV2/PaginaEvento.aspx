<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaEvento.aspx.cs" Inherits="NatureEventV2.PaginaEvento" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
body{
    font-family:'Segoe UI';
}
.footer{
    margin-top:10%;
}
</style>
    <div id="submenu" class="mt-2 mb-5" style=" height:4%; ">
            <p><a style="color:gray;" href="Server.Transfer("HistorialEventos.aspx");">Historial Eventos</a> &nbsp > &nbsp <b style="color:darkslategray">Evento</b></p>
    </div>
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6">
                <div class="row mt-3">
                    <div class="card-block text-center form-label-group">
                        <p class="form-label-group">
                            <asp:TextBox class="form-control" ID="TextBoxNombreEvento" runat="server" Visible="false"></asp:TextBox>
                            <h3><asp:Label ID="LabelNombreEvento" runat="server" Text="Nombre"></asp:Label></h3>
                        </p>
                    </div>
                    <div class="card-block text-center form-label-group">
                        <asp:TextBox  class="form-control" ID="TextDescripcion" runat="server" Visible="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center form-label-group">
                        <asp:Label ID="LabelDescripcion" runat="server"></asp:Label>
                        
                    </div>
                </div>
                <div class="row mt-3">
                    <div class="card-block text-center form-label-group">
                        <b>Inicio</b>
                        <asp:TextBox class="form-control" ID="TextFechaInicio" runat="server" Visible="false"></asp:TextBox>
                        <asp:Label ID="LabelFechaInicio" runat="server"></asp:Label>
                    </div>
                    <div class="card-block text-center ml-4 form-label-group">
                        <b>Hasta</b>
                        <asp:TextBox class="form-control" ID="TextFechaFinal" runat="server" Visible="false"></asp:TextBox>
                        <asp:Label ID="LabelFechaFinal" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center mt-3 form-label-group">
                        <b>Direcion</b>
                        <asp:Label ID="LabelDirecionEvento" runat="server"></asp:Label>
                        <asp:TextBox class="form-control" ID="TextDirecionEvento" runat="server" Visible="false"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="card-block text-center mt-3">
                        <asp:Button ID="ButtonEditar" class="btn btn-primary" runat="server" Text="Editar" Visible="false" OnClick="ButtonEditar_Click" />
                    </div>
                     <div class="card-block text-center mt-3 ml-2">
                        <asp:Button ID="ButAsistencia" class="btn btn-primary"  runat="server" Text="Asistencia" Visible="false" Onclick="ButtonAsistencia" />
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

<!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
  <div class="modal-dialog" role="document">
      <asp:UpdatePanel ID="ContentArea" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
          <ContentTemplate>
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Asistencia</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <asp:Panel ID="ContentTemplate2" runat="server"></asp:Panel>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <asp:Button ID="guardarAsistencia" runat="server" Text="Guardar" class="btn btn-primary" OnClick="ButtonAsistencia_Click"/>
      </div>
    </div>
 </ContentTemplate>
 </asp:UpdatePanel>
 </div>
</div>
         
</asp:Content>
