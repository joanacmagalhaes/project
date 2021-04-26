<%@ Page Title="SOBRE NOSOTROS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="NatureEventV2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2 class="mt-2"><%: Title %></h2>
        <h3 class="text-muted mt-4">
            PROYECTO
        </h3>
        <div class="row mt-4 mb-4">
            <div class="col">
                <div class="text-md-left">
                    <b>¡Bienvenidos a NaturEvent!</b> Esta página web trabaja como intermediario entre organizaciones y usuarios, donde las organizaciones crearán eventos medioambientales para ayudar al planeta y los usuarios podrán participar y tener un fácil acceso. Gracias al mapa situado en la página principal se mostrarán al usuario estas actividades creadas. La finalidad de la web es que los usuarios tengan un fácil acceso a las actividades y las organizaciones tengan una mayor visibilidad y facilidad a la hora de organizar estos eventos medioambientales. Esta idea surgió como proyecto final del curso <i><b>"Competéncias Tecnológicas en .NET: C# y SQL"</b></i> realizado en <b>Fundación Esplai</b>, mediante la metodología de <i>Design Thinking</i> conseguimos llegar a proponernos este objetivo, poder ayudar a los usuarios que quieran ayudar a nuestro planeta y dar una mayor facilidad a las organizaciones de usar nuestra página web para tener muchísima más visibilidad.
                </div>
            </div>
        </div>
        <hr />
        
            <h3 class="text-muted mt-4">
                INTEGRANTES
            </h3>
            <div class="row mt-4">
                <div class="offset-md-2 col-md-5">
                    <div>
                        <h5 class="text-bold">Jonatan García Romero</h5>
                    </div>
                    <div class="text-md-left">
                        <b>Desarrollador de Aplicaciones Web</b><br />
                            En esta aventura mis funciones eran muchas debido a nuestro limitado numero de miembros para este proyecto. Si bien trabaje en muchos campos mis asignaciones fueron más a la lógica de negocio, siendo la integración y la usabilidad de la API Bing Maps mi mayor cometido. También supervise el uso de GIT entre mis compañeros para evitar conflictos entre versiones. 
                    </div>
                    
                    <div class="mt-2">
                        <a href="https://www.linkedin.com/in/jgarcia-07/" class="float-left">                                   
                            <img src="Content/img/linkedin_icon_35x35.png" class="rounded float-right"/>&nbsp@jgarcia-07
                        </a>
                    </div>
                    
                </div>
                <div class="offset-md-1 col-md-2">
                    <img src="Content/img/Perfil-Jonatan.png" class="rounded-circle mt-5 img-perfil"/>
                </div>
            </div>
            <div class="row mt-4">
                <div class="offset-md-2 col-md-2">
                    <img src="Content/img/foto-joana.jpeg" class="rounded-j img-perfil mt-5"/>
                </div>
                <div class="offset-md-1 col-md-5">
                    <div>
                        <h5 class="text-bold text-md-right">Joana Magalhães</h5>
                    </div>
                    <div class="text-md-right">
                        <b>Desarrolladora de C#</b><br />
                            En este proyecto me encargo de crear algunas funcionalidades, como las páginas Historial de eventos, la página de información de Eventos y la funcionalidad de asistencia. Pero contribuí con cosas en cada página, cuando fue necesario. He ayudado en el diseño general de la página.                    

                    </div>
                    
                    <div class="mt-2">
                        <a href="https://www.linkedin.com/in/joana-magalh%C3%A3es-757286126/" class="float-right">@joanacmagalhaes&nbsp
                            <img src="Content/img/linkedin_icon_35x35.png" class="rounded float-right"/>
                        </a>
                    </div>
                    
                </div>
            </div>
            <div class="row mt-4">
                <div class="offset-md-2 col-md-5">
                    <div>
                        <h5 class="text-bold">Daniel Diaz Montes</h5>
                    </div>
                    <div class="text-md-left">
                       <b>Técnico informático</b><br />
                        En este proyecto me he encargado de ayudar a resolver conflictos y ayudar al resto del equipo. Me he encargado tanto de Front-end como de Back-end y he estado mas pendiente del registro y del historial de eventos.
                    </div>
                    
                    <div class="mt-2">
                        <a href="https://www.linkedin.com/in/daniel-diaz-montes-513058165/">&nbsp@danieldiazmontes
                            <img src="Content/img/linkedin_icon_35x35.png" class="rounded float-left"/>
                        </a>
                    </div>
                    
                </div>
                <div class="offset-md-1 col-md-2">
                    <img src="Content/img/foto-daniel.jpeg" class="rounded-circle img-perfil mt-5"/>
                </div>
            </div>
            <div class="row mt-4">
                <div class="offset-md-2 col-md-2">
                    <img src="Content/img/foto-diego.jpeg" class="rounded-circle mt-5 img-perfil"/>
                </div>
                <div class="offset-md-1 col-md-5">
                    <div>
                        <h5 class="text-bold text-md-right">Diego Miguel Soler Aparicio</h5>
                    </div>
                    <div class="text-md-right">
                       <b>Desarrollador de Aplicaciones Web</b><br />
                        En este proyecto me he encargado de la gestión del equipo y organización gracias a la herramienta Trello, así como he estado ayudando tanto en Back-end como en Front-end. He intervenido en el desarrollo de los perfiles tanto de usuario como de las organizaciones y he ayudado en el diseño general de la página, tanto con la <i>User Interface</i> como la <i>User Experience</i>.
                    </div>
                    
                    <div class="mt-2">
                        <a href="https://www.linkedin.com/in/diegosolerma/" class="float-right">@diegosolerma&nbsp
                            <img src="Content/img/linkedin_icon_35x35.png" class="rounded float-right"/>
                        </a>
                    </div>
                    
                </div>
            </div>
        
    </div>
    
</asp:Content>
