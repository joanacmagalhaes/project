<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NatureEventV2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <div class="row">
        <div class="col-md-12"><h2>Mapa de Eventos</h2></div>
        <div class="col-md-6">
            <asp:DropDownList ID="FilterListOrg" runat="server">
                <asp:ListItem>Selecciona Organización</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-6">
               <asp:Label>Filter time</asp:Label>
        </div>
        <div class="clearfix"></div>
        <div class="col-md-12">
                <div id="myMap" style="position:relative;width:100%;height:700px;"></div>
        </div>
    </div>        
  

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type='text/javascript' src='https://www.bing.com/api/maps/mapcontrol?callback=GetMap&key=AqYVkNUW99uD9gb1YRVpQtpicnUFXDOt05i27d7828ZAmXLnEgAlIL8k9NG0UGOc' async defer></script>
    <script type='text/javascript'>
            $(document).ready(function () {
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

                    $(eventos).each(function () {

                        var texto = "Fecha inicio:<br/>" + this.FechaInicio + "<br/>Fecha Final:<br/>" + this.FechaFinal + "<br/>Puntos:<br/>" + this.Puntos + "<br/>Descripción:<br/>" + this.Descripcion;

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

            });





    </script>

</asp:Content>
