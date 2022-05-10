<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormExperiencia.aspx.cs" Inherits="FirstRow.Pages.Forms.FormExperiencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
<div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una experiencia</h3>
            </div>
            <div class="center">
                <asp:TextBox id="create_titulo_experiencia" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_experiencia_requerido" ControlToValidate="create_titulo_experiencia" validationgroup="GrupoCrearExperiencia" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_experiencia_formato" ControlToValidate="create_titulo_experiencia" validationgroup="GrupoCrearExperiencia" style="float:left;  margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9 ]+$" ErrorMessage="Formato de titulo incorrecto."> </asp:RegularExpressionValidator>


                <asp:TextBox id="create_nombre_experiencia" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Nombre"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nombre_experiencia_requerido" ControlToValidate="create_nombre_experiencia" validationgroup="GrupoCrearExperiencia" ForeColor="Red" style="float:left;  margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="nombre_experiencia_formato" ControlToValidate="create_nombre_experiencia" validationgroup="GrupoCrearExperiencia" style="float:left; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9 ]+$" ErrorMessage="Formato de nombre incorrecto."> </asp:RegularExpressionValidator>


                <asp:TextBox id="create_precio_experiencia" runat="server" type="number" style="margin-top: 3%; width:100%" class="input" placeholder="Precio"></asp:TextBox>
                <asp:RequiredFieldValidator ID="precio_experiencia_requerido" ControlToValidate="create_precio_experiencia" validationgroup="GrupoCrearExperiencia" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Precio requerido"></asp:RequiredFieldValidator>

               
                <asp:TextBox id="create_descripcion_experiencia" runat="server" type="text" mode="multiline" style="margin-top: 3%; width:100%" class="input" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_experiencia_requerido" ControlToValidate="create_descripcion_experiencia" validationgroup="GrupoCrearExperiencia" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Descripción requerida"></asp:RequiredFieldValidator>


                <div class="destination-col" style="margin-top: 3%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_experiencia" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>

                <h3 style="margin-top: 5%;">Agrega etapas a tu experiencia</h3>
                <asp:Button id="add_etapa_button" runat="server" style="float:left; margin-left: 30%;" class="submit button" onClick="agregarEtapa" Text="Agregar etapa"/>

                <asp:Panel runat="server" ID="incluidos">
                </asp:Panel>







            </div>
            <div class="bottom">
                <asp:Button id="botonCrearExperiencia" class="submit button" onClick="crearExperiencia" runat="server" Text="Crear Experiencia" validationgroup="GrupoCrearExperiencia"/>
            </div>
        </div>
    </div>
</asp:Content>
