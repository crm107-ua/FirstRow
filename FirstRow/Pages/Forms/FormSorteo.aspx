<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormSorteo.aspx.cs" Inherits="FirstRow.Pages.Forms.FormSorteo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega un sorteo</h3>
            </div>
            <div class="center">
                <h2 class="subtitle" style="margin-left: 10px;" >Titulo</h2>
                <asp:TextBox ID="create_sorteo_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_sorteo_requerido" ControlToValidate="create_sorteo_title" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_sorteo_formato" ControlToValidate="create_sorteo_title" validationgroup="GrupoCrearsorteo" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>
                <h5 class="subtitle" style="margin-left: 10px;" >Descripcion</h5>
                <asp:TextBox ID="create_sorteo_descripcion" runat="server" type="text" textMode="MultiLine" style=" width:100%;" Height="180px" class="input" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_sorteo_requerido" ControlToValidate="create_sorteo_descripcion" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="create_sorteo_descripcion" validationgroup="GrupoCrearsorteo" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripción incorrecto"> </asp:RegularExpressionValidator>
                <asp:Label ID="ErrorDesc" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>

                <h2  class="subtitle" style="margin-left: 10px;" >Fecha de inicio</h2>
                <asp:TextBox ID="fechainicio" runat="server" type="date" style=" width:100%" class="input" placeholder="Fecha de inicio"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="fechainicio" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="fechainicio" validationgroup="GrupoCrearsorteo" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                     <h2 class="subtitle" style="margin-left: 10px;" >Fecha de finalizacion</h2>
                    <asp:TextBox ID="fechafinal" runat="server" type="date"  style=" width:100%" class="input" placeholder="Fecha de finalizacion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="fechafinal" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="fechafinal" validationgroup="GrupoCrearsorteo" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>
                    
         
                <h2 class="subtitle" style="margin-left: 10px;" >Experiencia</h2>
         
                    <div class="destination-col" style="margin-top: 1%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaexperiencias" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                <!-- 
             <div>  
                    <h5 class="title" style="margin-left: 10px;" >Imagen</h5>
                    <div>
                        <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                        <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                            <ContentTemplate>  
                                <asp:FileUpload ID="crear_sorteo_imagen" accept=".jpg , .png, .jpeg" runat="server" />  
                            </ContentTemplate> 
                        </asp:UpdatePanel>
                        
                    </div>
                    <asp:RequiredFieldValidator ID="imagen_sorteo_requerido" ControlToValidate="crear_sorteo_imagen" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" runat="server" ErrorMessage="*Imagen requerida"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="imagen_sorteo_formato" ControlToValidate="crear_sorteo_imagen" validationgroup="GrupoCrearsorteo" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" ValidationExpression="(.*?)\.(jpg|png|JPG|PNG|jpeg|JPEG)$" runat="server" ErrorMessage="*Formato imagenes incorrecto"></asp:RegularExpressionValidator>
                </div> 
               
                <div class="destination-col" style="margin-top: 5px; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_sorteo" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
                 -->
            </div>
             <div class="bottom">
                 <!--onClick="crearSorteo"-->
                <asp:Button id="botonCrearsorteo" onClick="crearSorteo" class="submit button"  runat="server" Text="Crear Sorteo" validationgroup="GrupoCrearsorteo"/>
            </div>
        </div>
    </div>
</asp:Content>