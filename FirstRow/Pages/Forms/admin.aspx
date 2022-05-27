<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="FirstRow.Pages.Forms.Formadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://www.xtrafondos.com/descargar.php?id=4621&resolucion=2560x1440)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Modificacion de campos</h3>
            </div>
          
            <div class="center">
                <h5 class="subtitle">Titulo de la experiencia: </h5>
                <asp:TextBox ID="create_admin_title_experiencia" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la experiencia"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_exp_admin_requerido" ControlToValidate="create_admin_title_experiencia" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_admin_formato" ControlToValidate="create_admin_title_experiencia" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo de la galeria: </h5>
                <asp:TextBox ID="create_admin_tittle_galeria" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la galeria"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_galeria_admin_requerido" ControlToValidate="create_admin_tittle_galeria" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_galeria_admin_formato" ControlToValidate="create_admin_tittle_galeria" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo de la storie: </h5>
                <asp:TextBox ID="create_admin_tittle_storie" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la storie"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_storie_admin_requerido" ControlToValidate="create_admin_tittle_storie" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_storie_admin_formato" ControlToValidate="create_admin_tittle_storie" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulol blog: </h5>
                <asp:TextBox ID="create_admin_tittle_blog" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo del blog"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_blog_admin_requerido" ControlToValidate="create_admin_tittle_blog" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_blog_admin_formato" ControlToValidate="create_admin_tittle_blog" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo del sorteo: </h5>
                <asp:TextBox ID="create_admin_tittle_sorteo" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo sorteos"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_sorteos_admin_requerido" ControlToValidate="create_admin_tittle_sorteo" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_sorteos_admin_formato" ControlToValidate="create_admin_tittle_sorteo" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Descripcion experiencia: </h5>
                <asp:TextBox ID="create_admin_descripcion" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion experiencia"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_exp_admin_requerido" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_admin_formato" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion galeria: </h5>
                <asp:TextBox ID="create_admin_descripcion_galeria" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion galeria"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_galeria_admin_requerido" ControlToValidate="create_admin_descripcion_galeria" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_galeria_admin_formato" ControlToValidate="create_admin_descripcion_galeria" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion stories: </h5>
                <asp:TextBox ID="create_admin_descripcion_stories" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion stories"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_stories_admin_requerido" ControlToValidate="create_admin_descripcion_stories" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_stories_admin_formato" ControlToValidate="create_admin_descripcion_stories" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion blogs: </h5>
                <asp:TextBox ID="create_admin_descripcion_blogs" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion blogs"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_blogs_admin_requerido" ControlToValidate="create_admin_descripcion_blogs" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_blogs_admin_formato" ControlToValidate="create_admin_descripcion_blogs" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion sorteos: </h5>
                <asp:TextBox ID="create_admin_descripcion_sorteos" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion sorteos"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_sorteos_admin_requerido" ControlToValidate="create_admin_descripcion_sorteos" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion sorteos"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_sorteos_admin_formato" ControlToValidate="create_admin_descripcion_sorteos" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>
                   
                  <h5 class="subtitle">Slogan: </h5>
                                <asp:TextBox ID="create_admin_slogan" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Slogan texto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="slogan_requerido" ControlToValidate="create_admin_slogan" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="slogan_formato" ControlToValidate="create_admin_slogan" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Info: </h5>
                                <asp:TextBox ID="create_admin_info" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Info texto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="info_text" ControlToValidate="create_admin_info" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="info_formato" ControlToValidate="create_admin_info" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>
               
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Modificar" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearadmin"/>
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>