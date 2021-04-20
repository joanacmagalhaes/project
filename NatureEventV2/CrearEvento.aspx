<%@ Page Title="Crear Evento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="NatureEventV2.CrearEvento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    
    <form>
        <div class="row">
            <div class="col">

                <asp:TextBox ID="TextBoxNombreActividad" runat="server" CssClass="form-control">NombreActividad</asp:TextBox><br /><br />
                <asp:TextBox ID="TextBoxDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:TextBox ID="TextBoxPuntos" runat="server">0</asp:TextBox>
                <asp:Calendar ID="CalendarFechaInicio" runat="server"></asp:Calendar>

            </div>
            <div class="col">
                
                <asp:TextBox ID="TextBoxPosX" runat="server" CssClass="form-control">PosX</asp:TextBox><br /><br />
                <asp:TextBox ID="TextBoxPosY" runat="server" CssClass="form-control">PosY</asp:TextBox><br /><br />
                <asp:Calendar ID="CalendarFechaFinal" runat="server"></asp:Calendar>
                <asp:TextBox ID="TextBoxDireccion" runat="server">Dirección</asp:TextBox>
                <asp:Button ID="ButtonCrearEvento" runat="server" Text="Crear" OnClick="ButtonCrearEvento_Click" />
            </div>

        </div>
    </form>
</asp:Content>
