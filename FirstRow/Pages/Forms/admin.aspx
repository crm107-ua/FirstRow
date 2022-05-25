<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="FirstRow.Pages.Forms.Formadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://www.xtrafondos.com/descargar.php?id=4621&resolucion=2560x1440)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Modificacion de campos</h3>
            </div>
          
            <div class="center">
                <h5 class="subtitle">Titulo de la experiencia: </h5>
                <asp:TextBox ID="create_admin_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la experiencia"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_exp_admin_requerido" ControlToValidate="create_admin_title" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_admin_formato" ControlToValidate="create_admin_title" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo de la galeria: </h5>
                <asp:TextBox ID="TextBox1" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la galeria"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_galeria_admin_requerido" ControlToValidate="TextBox1" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_galeria_admin_formato" ControlToValidate="TextBox1" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo de la storie: </h5>
                <asp:TextBox ID="TextBox2" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo de la storie"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_storie_admin_requerido" ControlToValidate="TextBox2" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_storie_admin_formato" ControlToValidate="TextBox2" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulol blog: </h5>
                <asp:TextBox ID="TextBox3" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo del blog"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_blog_admin_requerido" ControlToValidate="TextBox3" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_blog_admin_formato" ControlToValidate="TextBox3" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                 <h5 class="subtitle">Titulo del sorteo: </h5>
                <asp:TextBox ID="TextBox4" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo sorteos"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_sorteos_admin_requerido" ControlToValidate="TextBox4" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_sorteos_admin_formato" ControlToValidate="TextBox4" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>



                 <h5 class="subtitle">Descripcion experiencia: </h5>
                <asp:TextBox ID="create_admin_descripcion" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion experiencia"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_exp_admin_requerido" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_admin_formato" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion galeria: </h5>
                <asp:TextBox ID="TextBox5" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion galeria"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_galeria_admin_requerido" ControlToValidate="TextBox5" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_galeria_admin_formato" ControlToValidate="TextBox5" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion stories: </h5>
                <asp:TextBox ID="TextBox6" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion stories"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_stories_admin_requerido" ControlToValidate="TextBox6" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_stories_admin_formato" ControlToValidate="TextBox6" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion blogs: </h5>
                <asp:TextBox ID="TextBox7" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion blogs"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_blogs_admin_requerido" ControlToValidate="TextBox7" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_blogs_admin_formato" ControlToValidate="TextBox7" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Descripcion sorteos: </h5>
                <asp:TextBox ID="TextBox8" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion sorteos"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_sorteos_admin_requerido" ControlToValidate="TextBox8" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion sorteos"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_sorteos_admin_formato" ControlToValidate="TextBox8" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>
                   
                  <h5 class="subtitle">Slogan: </h5>
                                <asp:TextBox ID="TextBox9" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Slogan texto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="slogan_requerido" ControlToValidate="TextBox9" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="slogan_formato" ControlToValidate="TextBox9" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                  <h5 class="subtitle">Info: </h5>
                                <asp:TextBox ID="TextBox10" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Info texto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="info_text" ControlToValidate="TextBox10" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="info_formato" ControlToValidate="TextBox10" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>
               
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Modificar" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearadmin"/>
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>