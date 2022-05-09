<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormGaleria.aspx.cs" Inherits="FirstRow.Pages.Forms.FormGaleria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
<div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una galeria</h3>
            </div>
            <div class="center">
                <asp:TextBox ID="Tiulo" runat="server" type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <textarea style="margin-top: 3%; width:100%; margin-bottom: 3%;" class="textarea" placeholder="Descripcion" ></textarea>
                <div>  
                    <h5 class="title">Imagenes</h5>    
                    <asp:ScriptManager ID="SCPTMGR" runat="server"></asp:ScriptManager>  
                    <asp:UpdatePanel ID="UpdimageUpload" runat="server">  
                        <ContentTemplate>  
                            <asp:FileUpload ID="FileuploadImage" accept="image/*" class="submit button" multiple="multiple" runat="server"/>  
                        </ContentTemplate> 
                    </asp:UpdatePanel>  
                </div> 
                <div class="destination-col" style="margin-top: 3%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_experiencia" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Crear" OnClick="btnCrea_Click" />
                <asp:Label ID="Mensaje" style="color: red; margin-left: 3%; margin-top: 15px; visibility: visible;" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
