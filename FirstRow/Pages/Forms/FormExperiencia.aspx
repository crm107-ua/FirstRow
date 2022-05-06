<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="FormExperiencia.aspx.cs" Inherits="FirstRow.Pages.Forms.FormExperiencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
<div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una experiencia</h3>
            </div>
            <div class="center">
                <input type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Nombre">
                <input type="text" style="margin-top: 3%; width:100%" class="input" placeholder="Titulo">
                <textarea style="margin-top: 3%; width:100%" class="textarea" placeholder="Descripcion"></textarea>
                <div class="destination-col" style="margin-top: 3%; width:100%">
                    <div class="select_wrap">
                        <asp:DropDownList ID="listaPaises_form_experiencia" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="bottom">
                <button class="submit button">Crear</button>
            </div>
        </div>
    </div>
</asp:Content>
