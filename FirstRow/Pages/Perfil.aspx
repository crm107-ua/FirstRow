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
                        <div style="background-color:#FC805A; border-radius: 20px; padding: 100px;">
                            <h1 id="titulo_tabla" runat="server" class="title" style="margin-bottom:30px; color:white; width:60%;"></h1>
                            <div id="scroll_reservas" runat="server" style="height: 40%; overflow-x: scroll;">
                                 <asp:GridView ID="reservasTabla" runat="server" style="width:100%" AutoGenerateColumns="true" CssClass="table table-responsive" GridLines="None" HeaderStyle-CssClass="header" RowStyle-CssClass="rows"></asp:GridView>  
                             </div>
                            <h1 id="top" runat="server" class="title" style="margin-bottom:30px; margin-top:30px; color:white; width:60%;"></h1>
                            <div id="scroll_top" runat="server" style="height: 25%; overflow-x: scroll;">
                                <asp:GridView ID="top_clientes" runat="server" AutoGenerateColumns="true" style="width:100%" CssClass="table table-responsive" GridLines="None" HeaderStyle-CssClass="header" RowStyle-CssClass="rows"></asp:GridView>
                            </div>
                        </div>
                    </div>                  
                </div>
            </div>
            </div>
       </div>
    <style>
       .mydatagrid
        {
        width: 80%;
        border: solid 2px black;
        min-width: 80%;
        }
        .header
        {
        background-color: #C24125;
        font-family: Arial;
        color: White;
        height: 25px;
        text-align: center;
        font-size: 16px;
        }

        .rows
        {
        background-color: #fff;
        font-family: Arial;
        font-size: 14px;
        color: #000;
        min-height: 25px;
        text-align: left;
        }
        .rows:hover
        {
        background-color: #ff4f53;
        color: #fff;
        }

        .mydatagrid a /** FOR THE PAGING ICONS **/
        {
        background-color: Transparent;
        padding: 5px 5px 5px 5px;
        color: #fff;
        text-decoration: none;
        font-weight: bold;
        }

        .mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
        {
        background-color: #fff;
        color: #000;
        }
        .mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
        {

        padding: 5px 5px 5px 5px;
        background-color: #000;
        color: #fff;
        }
        .pager
        {
        background-color: #ff4f53;
        font-family: Arial;
        color: White;
        height: 30px;
        text-align: left;
        }

        .mydatagrid td
        {
        padding: 5px;
        }
        .mydatagrid th
        {
        padding: 5px;
        }
    </style>
</asp:Content>
