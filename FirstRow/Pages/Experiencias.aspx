<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Experiencias.aspx.cs" Inherits="FirstRow.Pages.Experiencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://img4.goodfon.com/wallpaper/nbig/9/4c/gorod-irlandiia-starinnaia-ulochka-kafe-magazinchiki-suvenir.jpg)"></div>
        <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/experiencias">Experiencias</a>
                </div>
            </div>
        </div>
        <div class="page travel-list full-width full-width-image-header">
            <div class="page_head">
                <div class="wrap_float">
                    <div class="wrap">
                        <div class="wrap_float">
                            <h1 class="title">
                                Nuestras experiencias
                            </h1>
                            <p class="subtitle" style="color:white;">
                                Cumpliendo sueños alrededor de todo el mundo
                            </p>
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
