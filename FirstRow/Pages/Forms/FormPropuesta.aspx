<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormPropuesta.aspx.cs" Inherits="FirstRow.Pages.Forms.FormPropuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://www.xtrafondos.com/descargar.php?id=4621&resolucion=2560x1440)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una propuesta</h3>
                <asp:Label ID="resultado" runat="server" style="margin:10px; color:red;"></asp:Label>
            </div>
            <div class="center">
                <asp:TextBox ID="create_propuesta_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_propuesta_requerido" ControlToValidate="create_propuesta_title" validationgroup="GrupoCrearPropuesta" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; " runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_propuesta_formato" ControlToValidate="create_propuesta_title" validationgroup="GrupoCrearPropuesta" style="float:left; margin-left: 10px; margin-top: 5px; " runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                <asp:TextBox ID="create_propuesta_descripcion" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_propuesta_requerido" ControlToValidate="create_propuesta_descripcion" validationgroup="GrupoCrearPropuesta" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_propuesta_formato" ControlToValidate="create_propuesta_descripcion" validationgroup="GrupoCrearPropuesta" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

              
                <div>  
                    <h5 class="title" style="margin-left: 10px;" >Imagenes</h5>
                    <div>
                        <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                        <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                            <ContentTemplate>  
                                <asp:FileUpload ID="crear_propuesta_imagenes" accept=".jpg , .png, .jpeg" runat="server"/>  
                            </ContentTemplate> 
                        </asp:UpdatePanel>
                        
                    </div>
                    <asp:RequiredFieldValidator ID="imagenes_propuesta_requerido" ControlToValidate="crear_propuesta_imagenes" validationgroup="GrupoCrearPropuesta" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" runat="server" ErrorMessage="*Imagen requerida"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="imagenes_propuesta_formato" ControlToValidate="crear_propuesta_imagenes" validationgroup="GrupoCrearPropuesta" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" ValidationExpression="(.*?)\.(jpg|png|JPG|PNG|jpeg|JPEG)$" runat="server" ErrorMessage="*Formato imagenes incorrecto"></asp:RegularExpressionValidator>
                </div> 
                <div class="bottom">
                <asp:Button ID="Button1" class="submit button" runat="server" Text="Añadir propuesta" OnClick="CrearPropuesta" ValidationGroup="GrupoCrearPropuesta" />
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
                </div>
        </div>
</asp:Content>