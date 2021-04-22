<%@ Page Title="Crear Evento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="NatureEventV2.CrearEvento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>

    <div class="row">
        <asp:HiddenField ID="TextBoxPosX" runat="server" />
        <asp:HiddenField ID="TextBoxPosY" runat="server" />

        <div class="col-md-6">
            <div class="form-group">
                <asp:TextBox ID="TextBoxNombreActividad" runat="server" CssClass="form-control inputMaxWidth" placeholder="Nombre actividad" ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="CalendarFechaInicio" CssClass="form-control inputMaxWidth" runat="server" placeholder="Fecha inicio"
                    ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:TextBox ID="HoraInicio" CssClass="form-control inputMaxWidth" runat="server" placeholder="Hora inicio" ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio" TextMode="Time" />
            </div>

        </div>
        <div class="col-md-6">
            <div class="form-group">
                <asp:TextBox ID="TextBoxPuntos" runat="server" CssClass="form-control inputMaxWidth"
                    ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio" placeholder="Puntos Evento, ex: 500" TextMode="Number"></asp:TextBox>

            </div>

            <div class="form-group">
                <asp:TextBox ID="CalendarFechaFinal" CssClass="form-control inputMaxWidth" runat="server" placeholder="Fecha final"
                    ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio"></asp:TextBox>

            </div>

            <div class="form-group">
                <asp:TextBox ID="HoraFinal" CssClass="form-control inputMaxWidth" runat="server" placeholder="Hora final" TextMode="Time" ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio" />

            </div>

        </div>
        <div class="col-md-12">

            <div class="form-group">
                <asp:TextBox ID="TextBoxDireccion" CssClass="form-control inputMaxWidth" runat="server" placeholder="Dirección completa" ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio"></asp:TextBox>

            </div>
            <div class="form-group">
                <asp:TextBox ID="TextBoxDescripcion" Rows="5" TextMode="MultiLine" runat="server" CssClass="form-control inputMaxWidth" placeholder="Descripción del evento" ControlToValidate="TargetControlId" ErrorMessage="Campo Obligatorio"></asp:TextBox>
            </div>

        </div>
        <div class="col-md-12">
            <div class="form-group">
                <div class="alert alert-info alert-dismissible" >
                    <strong>Información:</strong> Haz clic en el mapa donde vas a llevar acabo el evento.
                    
                </div>
                
                <asp:Label ID="TextoAlerta" Text="" runat="server"></asp:Label>
                <div id="myMap" style="position: relative; width: 100%; height: 300px;"></div>
            </div>
        </div>
        
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" Text="Subir Evento" CssClass="form-control btn btn-primary inputMaxWidth" OnClick="ButtonCrearEvento_Click" />
        </div>

    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js" integrity="sha256-VazP97ZCwtekAsvgPBSUwPFKdrwD3unUfSGVYrahUqU=" crossorigin="anonymous"></script>

    <script type="text/javascript">
        var map, pin;
        window.onload = function () {
            console.log("dentro function document ready");
            map = new Microsoft.Maps.Map('#myMap', {});
            Microsoft.Maps.Events.addHandler(map, 'click', displayLatLong);
        };

        function displayLatLong(e) {
            if (e.targetType == "map") {
                map.entities.clear();
                var point = new Microsoft.Maps.Point(e.getX(), e.getY());
                var loc = e.target.tryPixelToLocation(point);
                pin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(loc.latitude, loc.longitude));
                map.entities.push(pin);
                Microsoft.Maps.Events.addHandler(map, 'click', displayLatLong);
                document.getElementById("MainContent_TextBoxPosX").value = loc.latitude;
                document.getElementById("MainContent_TextBoxPosY").value = loc.longitude;

            }
        }

        $('#MainContent_CalendarFechaInicio').datepicker(
            {
                dateFormat: 'dd/mm/yy',
                timeFormat: "hh:mm:ss",
                changeMonth: true,
                changeYear: true,
                minDate: 0

            });
        $('#MainContent_CalendarFechaFinal').datepicker(
            {
                dateFormat: 'dd/mm/yy',
                timeFormat: "hh:mm:ss",
                changeMonth: true,
                changeYear: true,
                minDate: 0

            });
    </script>
</asp:Content>
