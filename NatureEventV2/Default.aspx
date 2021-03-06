<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NatureEventV2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="HiddenFieldSessionID" runat="server" />
    <asp:HiddenField ID="HiddenFieldTypeUser" runat="server" />

    <div class="row">
        <div class="col-md-12" id="mensajeServidor"></div>
        <div class="col-md-12">
            <h2>Mapa de Eventos</h2>
        </div>
        <div class="col-md-5">
            <label><b>Organización:</b></label>
            <asp:DropDownList ID="FilterListOrg" runat="server">
                <asp:ListItem>Selecciona Organización</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-5 ">
            <label><b>Fecha de inicio:</b></label>
            <asp:TextBox TextMode="Date" ID="FilterDate" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <button type="button" id="BtnFiltro" class="btn btn-success" onclick="mapaFilter()">Aplicar Filtro</button>
        </div>
        <div class="col-md-12 mb-2"></div>
        <div class="col-md-12">
            <div id="myMap" style="position: relative; width: 100%; height: auto;"></div>
        </div>
        <div class="mb-2"></div>
    </div>


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <script type='text/javascript'>
        function unirseEvento(idEvento) {
            var uid = document.getElementById("MainContent_HiddenFieldSessionID").value;

            $.ajax({
                type: "POST",
                url: "Default.aspx/UnirseEvento",
                data: '{ eid:' + idEvento + ', uid:' + uid + '}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: onSucessEvent,
                failure: function (response) {
                    alert(response.d);
                },
                error: function (response) {
                    alert(response.d);
                }
            });
        }
        function mapaFilter() {
            var selCompany = document.getElementById("MainContent_FilterListOrg").value;
            var dateStart = document.getElementById("MainContent_FilterDate").value;
            selCompany = JSON.stringify(selCompany);
            dateStart = JSON.stringify(dateStart);
            $.ajax({
                type: "POST",
                url: "Default.aspx/GetEventosFilter",
                data: '{ idC:' + selCompany + ', dStart:' + dateStart + '}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: onSucessFilter,
                failure: function (response) {
                    alert(response.d);
                },
                error: function (response) {
                    alert(response.d);
                }
            });
        }

        function onSucessFilter(response) {

            document.getElementById("mensajeServidor").innerHTML = "<div class='alert alert-success alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Resultados: </strong> Se han encontrado " + response.d.length + " eventos.</div>";
            onSucess(response);

        }


        function onSucessEvent(response) {
            if (response.d == 1) {
                document.getElementById("mensajeServidor").innerHTML = "<div class='alert alert-success alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Exito!</strong> Te has registrado correctamente al evento.</div>";
            } else if (response.d == 2) {
                document.getElementById("mensajeServidor").innerHTML = "<div class='alert alert-info alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Información:</strong> Ya estas registrado al evento.</div>";

            } else {
                document.getElementById("mensajeServidor").innerHTML = "<div class='alert alert-warning alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Fallo!</strong> Ha ocurrido un error en la conexión, prueba más tarde.</div>";

            }
        }

        var map, infobox, pin;

        $(function () {
            $.ajax({
                type: "POST",
                url: "Default.aspx/GetEventos",
                data: '{}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: onSucess,
                failure: function (response) {
                    alert(response.d);
                },
                error: function (response) {
                    alert(response.d);
                }
            });
        });


        function onSucess(response) {
            map = new Microsoft.Maps.Map('#myMap', {});
            infobox = new Microsoft.Maps.Infobox(map.getCenter(), {
                visible: false
            });
            infobox.setOptions({ maxHeight: 420 });
            infobox.setMap(map);

            var eventos = response.d;

            var buttonHtml = "";
            var Hidden;
            Hidden = document.getElementById("MainContent_HiddenFieldTypeUser");

            $(eventos).each(function () {
                if (Hidden.value == "0") {
                    buttonHtml = "<br><button class='btn btn-primary float-right' type='button' onclick='unirseEvento(" + this.IdEvento + ")'>Unirse</button>";
                }
                var texto = "<strong>Fecha inicio</strong>:<br/>" + this.FechaInicio + "<br/><strong>Fecha Final:</strong><br/>" + this.FechaFinal + "<br/><strong>Puntos:</strong><br/>" + this.Puntos + "<br/><strong>Descripción:</strong><br/>" + this.Descripcion + buttonHtml;

                pin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(this.PosX, this.PosY), {
                    title: this.Nombre,
                    subTitle: this.Direccion

                });

                pin.metadata = {
                    title: this.NombreEmpresa,
                    description: texto
                };

                Microsoft.Maps.Events.addHandler(pin, 'click', pushpinClicked);
                map.entities.push(pin);
            });
        }

        function pushpinClicked(e) {

            //Make sure the infobox has metadata to display.
            if (e.target.metadata) {
                //Set the infobox options with the metadata of the pushpin.
                infobox.setOptions({
                    location: e.target.getLocation(),
                    title: e.target.metadata.title,
                    description: e.target.metadata.description,
                    visible: true
                });
            }
        }







    </script>

</asp:Content>
