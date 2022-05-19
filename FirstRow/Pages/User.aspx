<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="FirstRow.Pages.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
            <div class="image_header" style="background-image: url(https://hd-wallpaper.wiki/wp-content/uploads/2022/04/best-travel-wallpapers-22.jpg)"></div>
            <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/">Visor de usuarios</a>
                </div>
            </div>
        </div>
        <div class="page travel-list full-width full-width-image-header">
            <div class="page_head">
                <div class="wrap_float">
                    <div class="wrap">
                        <div class="wrap_float">
                            <h1 id="user_text" runat="server" class="title">
                            </h1>
                            <p id="tipo_text" runat="server" class="subtitle">
                            </p>
                            <h1 id="mode_text" runat="server" class="title" style="margin-top: 50px;">
                            </h1>
                        </div>
                    </div>
                </div>
            </div>
            <div class="page_body">
                <div class="wrap">
                    <div class="wrap_float">
                         <div class="page_body">
                            <div class="posts">
                                <asp:Panel ID="mostrar_experiencias" runat="server" class="posts">
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
