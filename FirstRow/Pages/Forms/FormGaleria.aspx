<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormGaleria.aspx.cs" Inherits="FirstRow.Pages.Forms.FormGaleria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una galeria</h3>
            </div>
            <div class="center">
                <asp:TextBox ID="create_galeria_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_galeria_requerido" ControlToValidate="create_galeria_title" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_galeria_formato" ControlToValidate="create_galeria_title" validationgroup="GrupoCrearGaleria" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                <asp:TextBox ID="create_galeria_descripcion" runat="server" type="text" textMode="MultiLine" style=" width:100%;" Height="180px" class="input" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_galeria_requerido" ControlToValidate="create_galeria_descripcion" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_galeria_formato" ControlToValidate="create_galeria_descripcion" validationgroup="GrupoCrearGaleria" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                <div>  
                    <h5 class="title" style="margin-left: 10px;" >Imagenes</h5>
                    <div>
                        <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                        <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                            <ContentTemplate>  
                                <asp:FileUpload ID="crear_galeria_imagenes" multiple="multiple" accept=".jpg , .png, .jpeg" runat="server" />  
                            </ContentTemplate> 
                        </asp:UpdatePanel>
                        
                    </div>
                    <asp:RequiredFieldValidator ID="imagenes_galeria_requerido" ControlToValidate="crear_galeria_imagenes" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" runat="server" ErrorMessage="*Imagen requerida"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="imagenes_galeria_formato" ControlToValidate="crear_galeria_imagenes" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" ValidationExpression="(.*?)\.(jpg|png|JPG|PNG|jpeg|JPEG)$" runat="server" ErrorMessage="*Formato imagenes incorrecto"></asp:RegularExpressionValidator>
                </div> 
                <div class="destination-col" style="margin-top: 5px; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_galeria" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Crear" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearGaleria"/>
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>