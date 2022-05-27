<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormBlog.aspx.cs" Inherits="FirstRow.Pages.Forms.FormBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega un Blog</h3>
                <asp:Label ID="resultado" runat="server" style="margin:10px; color:red;"></asp:Label>
            </div>
            <div class="center">
                <asp:TextBox id="create_titulo_blog" maxlength="80" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Titulo" value="Ejemplo Titulo Blog"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_blog_requerido" ControlToValidate="create_titulo_blog" validationgroup="GrupoCrearBlog" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_blog_formato" ControlToValidate="create_titulo_blog" validationgroup="GrupoCrearBlog" style="float:left;  margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="Formato de titulo incorrecto."> </asp:RegularExpressionValidator>

                <asp:TextBox id="create_descripcion_blog" maxlength="300" placeholder="Descripción" style="margin-top: 3%; width:100%; height: 150px; line-height: 250%;" class="input" TextMode="multiline" runat="server" text="Ejemplo Descripcion Blog" />
                <asp:RequiredFieldValidator ID="descripcion_blog_requerida" ControlToValidate="create_descripcion_blog" validationgroup="GrupoCrearBlog" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Descripción requerida"></asp:RequiredFieldValidator>

                
                <asp:TextBox id="create_text_1_blog" maxlength="300" placeholder="Texto 1" style="margin-top: 3%; width:100%; height: 150px; line-height: 250%;" class="input" TextMode="multiline" runat="server" text="Ejemplo Texto 1 Blog" />
                <asp:RequiredFieldValidator ID="text_1_blog_requerida" ControlToValidate="create_text_1_blog" validationgroup="GrupoCrearBlog" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Texto 1 requerido"></asp:RequiredFieldValidator>

                
                <asp:TextBox id="create_text_2_blog" maxlength="300" placeholder="Texto 2" style="margin-top: 3%; width:100%; height: 150px; line-height: 250%;" class="input" TextMode="multiline" runat="server" text="Ejemplo Texto 2 Blog" />
                <asp:RequiredFieldValidator ID="text_2_blog_requerida" ControlToValidate="create_text_2_blog" validationgroup="GrupoCrearBlog" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Texto 2 requerido"></asp:RequiredFieldValidator>

                
                <asp:TextBox id="create_text_3_blog" maxlength="300" placeholder="Texto 3" style="margin-top: 3%; width:100%; height: 150px; line-height: 250%;" class="input" TextMode="multiline" runat="server" text="Ejemplo Texto 3 Blog" />
                <asp:RequiredFieldValidator ID="text_3_blog_requerida" ControlToValidate="create_text_3_blog" validationgroup="GrupoCrearBlog" ForeColor="Red" style="float:left; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Texto 3 requerido"></asp:RequiredFieldValidator>

                 
                <asp:TextBox id="create_citacion_blog" maxlength="80" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Menciona una cita" value="Ejemplo Cita Blog"></asp:TextBox>
                <asp:RegularExpressionValidator ID="citacion_blog_requerido" ControlToValidate="create_citacion_blog" validationgroup="GrupoCrearBlog" style="float:left;  margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="Formato de cita incorrecto."> </asp:RegularExpressionValidator>

                <h2 style="margin-top: 5%;">Fondo principal</h2>  
                <asp:FileUpload id="background_blog" accept=".jpg , .png" style="margin-top: 3%; width:100%; margin-bottom: 20px;" runat="server"/>

                <h2 style="margin-top: 5%;">Imágenes del blog</h2>  
                <asp:FileUpload id="imagenes_blog" accept=".jpg , .png" style="margin-top: 3%; width:100%; margin-bottom: 20px;" runat="server" AllowMultiple="true"/>

                <h3 style="margin-top: 3%; width:100%">Categoría:</h3>
                <div class="destination-col" style="margin-top: 1%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaCategorias_form_blog" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>

                <h3 style="margin-top: 3%; width:100%">País destino:</h3>
                <div class="destination-col" style="margin-top: 1%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_blog" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>

            </div>
            <div class="bottom">
                <asp:Button id="botonCrearBlog" class="submit button" onClick="crearBlog" runat="server" Text="Crear Blog" validationgroup="GrupoCrearBlog"/>
            </div>
        </div>
    </div>
</asp:Content>
