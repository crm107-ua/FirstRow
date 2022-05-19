<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="FirstRow.Pages.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="tour_page_head" style="background-image: url(https://free4kwallpapers.com/uploads/originals/2021/07/21/venice-italy-wallpaper.jpg)">
       <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a id="tipo" runat="server" href="/perfil" style="color:white;"></a>
                </div>
            </div>
        </div>
        <div class="page contacts-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <div style="background-color:#FC805A; border-radius: 20px; padding: 100px;">
                         <div>
                                <img id="foto_perfil" src="/" runat="server" style="width: 30%; float:right; border-radius: 20px;" />
                                <h1 id="name_titulo_text" runat="server" class="title" style="margin-bottom:30px; color:white; width:60%;"></h1>
                                <p id="nickname_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:60%;"></p>
                                <p id="email_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:60%;"></p>
                                <p id="name_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:60%;"></p>
                                <p id="firstname_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="secondname_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="face_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="tw_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="cif_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%; margin-top:20px;"></p>
                                <p id="direccion_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="fecha_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                                <p id="pais_text" runat="server" class="subtitle" style="margin-bottom:20px; color:white; width:100%;"></p>
                             </div>
                                <a id="settings_user_pop_up" runat="server" class="subtitle js-popup-open" data-href="#profile-setting" style="color:white; text-decoration: underline white;">Ajustes</a>
                                <a id="settings_emp_pop_up"  runat="server" class="subtitle js-popup-open" data-href="#empresa-setting" style="color:white; text-decoration: underline white;">Ajustes de empresa</a>
                        </div>
                    </div>
                    <div class="page_body">
                    </div>
                </div>
            </div>
            </div>
        </div>
</asp:Content>
