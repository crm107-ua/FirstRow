<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Experiencias.aspx.cs" Inherits="FirstRow.Pages.Experiencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://img4.goodfon.com/wallpaper/nbig/9/4c/gorod-irlandiia-starinnaia-ulochka-kafe-magazinchiki-suvenir.jpg)"></div>
        <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/experiencias">Experiencias</a>
                    <a href="/agregar-experiencia" id="crear_experiencia" runat="server" style="float:right;"></a>
                </div>
            </div>
        </div>
        <div class="page travel-list full-width full-width-image-header">
            <div class="page_head">
                <div class="wrap_float">
                    <div class="wrap">
                        <div class="wrap_float">
                            <asp:Label ID="Title_exp" Class="title" runat="server" Text="Label"></asp:Label>
                            <div>
                            <asp:Label ID="Description_exp" class="subtitle" runat="server" Text="Label"></asp:Label>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="page_body">
                <div class="wrap">
                    <div class="wrap_float">
                        <div class="posts">
                            <asp:Panel ID="mostrar_experiencias" runat="server" class="posts">
                            </asp:Panel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
