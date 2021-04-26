<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NatureEventV2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="mb-4">

        <!--Section heading-->
        <h2 class="h1-responsive font-weight-bold text-center my-4">¡Contáctanos!</h2>
        <!--Section description-->
        <p class="text-center w-responsive mx-auto mb-5">
            ¿Tienes algún problema o duda? Por favor no dudes en contactarnos directamente. Nuestro equipo estará encantado de estar a tu disposición.
        </p>

        <div class="row">

            <!--Grid column-->
            <div class="col-md-12">

                <!--Grid row-->
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:Literal ID="TextMensajeInfo" runat="server" Text=""></asp:Literal>
                        </div>
                    </div>
                    <!--Grid column-->
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name" class="">Nombre</label>
                            <asp:TextBox ID="TextNombre" TextMode="SingleLine" runat="server" CssClass="form-control inputMaxWidth" MaxLength="50"></asp:TextBox>
                        </div>
                    </div>
                    <!--Grid column-->

                    <!--Grid column-->
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="email" class="">Email</label>
                            <asp:TextBox ID="TextBoxEmail" TextMode="Email" runat="server" CssClass="form-control inputMaxWidth" MaxLength="50"></asp:TextBox>
                        </div>
                    </div>
                    <!--Grid column-->

                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="subject" class="">Asunto</label>
                            <asp:TextBox ID="TextBoxAsunto" TextMode="SingleLine" runat="server" Class="form-control inputMaxWidth" MaxLength="100"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class="row">

                    <!--Grid column-->
                    <div class="col-md-12">

                        <div class="form-group">
                            <label for="message">Mensaje</label>
                            <asp:TextBox ID="TextAreaMensaje" TextMode="MultiLine" MaxLength="400" Rows="10" runat="server" CssClass="form-control inputMaxWidth"></asp:TextBox>
                        </div>

                    </div>
                </div>
                <!--Grid row-->


                <div class="form-group">
                    <asp:Button Class="btn btn-lg btn-primary btn-block btn-login text-uppercase font-weight-bold mb-2" ID="btnEnviar" Text="Enviar" OnClick="btnEnviar_Click" runat="server" />
                </div>
            </div>

        </div>

    </section></asp:Content>
