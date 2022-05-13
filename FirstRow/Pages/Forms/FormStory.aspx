<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormStory.aspx.cs" Inherits="FirstRow.Pages.Forms.FormStory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una story</h3>
            </div>
            <div class="center">
                <asp:TextBox ID="create_story_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_story_requerido" ControlToValidate="create_story_title" validationgroup="GrupoCrearStory" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_story_formato" ControlToValidate="create_story_title" validationgroup="GrupoCrearStory" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                <asp:TextBox ID="create_story_descripcion" runat="server" type="text" textMode="MultiLine" style=" width:100%;" Height="180px" class="input" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_story_requerido" ControlToValidate="create_story_descripcion" validationgroup="GrupoCrearStory" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_story_formato" ControlToValidate="create_story_descripcion" validationgroup="GrupoCrearStory" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                <div>  
                    <h5 class="title" style="margin-left: 10px;" >Imagenes</h5>
                    <div>
                        <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                        <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                            <ContentTemplate>  
                                <asp:FileUpload ID="crear_story_imagenes" multiple="multiple" accept=".jpg , .png, .jpeg" runat="server" />  
                            </ContentTemplate> 
                        </asp:UpdatePanel>
                        
                    </div>
                    <asp:RequiredFieldValidator ID="imagenes_story_requerido" ControlToValidate="crear_story_imagenes" validationgroup="GrupoCrearStory" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" runat="server" ErrorMessage="*Imagen requerida"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="imagenes_story_formato" ControlToValidate="crear_story_imagenes" validationgroup="GrupoCrearStory" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" ValidationExpression="(.*?)\.(jpg|png|JPG|PNG|jpeg|JPEG)$" runat="server" ErrorMessage="*Formato imagenes incorrecto"></asp:RegularExpressionValidator>
                </div> 
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Crear" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearStory"/>
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>