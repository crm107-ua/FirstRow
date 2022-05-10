<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormGaleria.aspx.cs" Inherits="FirstRow.Pages.Forms.FormGaleria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
<div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una galeria</h3>
            </div>
            <div class="center">
                <asp:TextBox ID="create_galeria_title" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_galeria_requerido" ControlToValidate="create_galeria_title" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_galeria_formato" ControlToValidate="create_galeria_title" validationgroup="GrupoCrearGaleria" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-Z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                <asp:TextBox ID="create_galeria_descripcion" runat="server" type="text" textMode="MultiLine" style=" width:100%" class="input" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_galeria_requerido" ControlToValidate="create_galeria_descripcion" validationgroup="GrupoCrearGaleria" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_galeria_formato" ControlToValidate="create_galeria_descripcion" validationgroup="GrupoCrearGaleria" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-Z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                <div>  
                    <h5 class="title" style="margin-left: 10px;" >Imagenes</h5>    
                    <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                    <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                        <ContentTemplate>  
                            <asp:FileUpload ID="FileuploadImage" accept=".jpg , .png" class="submit button" multiple="multiple" style="margin-left: 10px;" runat="server"/>  
                        </ContentTemplate> 
                    </asp:UpdatePanel>  
                </div> 
                <div class="destination-col" style="margin-top: 3%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_galeria" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Crear" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearGaleria"/>
            </div>
        </div>
    </div>
</asp:Content>
