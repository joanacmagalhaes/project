<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NatureEventV2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type='text/javascript'>
        var map, infobox;

        function GetMap()
        {
            map = new Microsoft.Maps.Map('#myMap', {});

            //Create an infobox at the center of the map but don't show it.
            infobox = new Microsoft.Maps.Infobox(map.getCenter(), {
                visible: false
            });

            //Assign the infobox to a map instance.
            
            infobox.setMap(map);

            var pin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(41.3907285, 2.1745089), {
                title: 'Evento Greenpeace',
                subTitle: 'Discurso de Nature',
                description: 'Info Event Greenpeace'

            });

            var pin2 = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(41.607285, 2.4745089), {
                title: 'Evento SaveWorld',
                subTitle: 'Recogida de Basura',
                description: 'Info Event SaveWorld'

            });

            var pin3 = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(41.9907285, 2.7745089), {
                title: 'Evento Ecology',
                subTitle: 'Recogida de basura',
                description: 'Info Event Ecology'

            });

            //Store some metadata with the pushpin.
            pin.metadata = {
                title: 'Evento Greenpeace',
                subTitle: 'Discurso de Nature',
                description: 'Info Event Greenpeace'
            };
            pin2.metadata = {
                title: 'Evento SaveWorld',
                subTitle: 'Recogida de Basura',
                description: 'Info Event SaveWorld'
            };
            pin3.metadata = {
                title: 'Evento Ecology',
                subTitle: 'Recogida de basura',
                description: 'Info Event Ecology'
            };



            Microsoft.Maps.Events.addHandler(pin, 'click', pushpinClicked);
            Microsoft.Maps.Events.addHandler(pin2, 'click', pushpinClicked);
            Microsoft.Maps.Events.addHandler(pin3, 'click', pushpinClicked);


            //Add the pushpin to the map
            map.entities.push(pin);
            map.entities.push(pin2);
            map.entities.push(pin3);

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
    <script type='text/javascript' src='https://www.bing.com/api/maps/mapcontrol?callback=GetMap&key=AqYVkNUW99uD9gb1YRVpQtpicnUFXDOt05i27d7828ZAmXLnEgAlIL8k9NG0UGOc' async defer></script>

    <h2>MAP INTEGRATION</h2>  
  
    <div class="row">  
        <div class="col-md-12">  
            <div id="myMap" style="position:relative;width:100%;height:400px;"></div>  
        </div>  
    </div>  

</asp:Content>
