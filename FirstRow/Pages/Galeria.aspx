<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="FirstRow.Pages.Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="breadcrumbs white-color">
        <div class="wrap">
            <div class="wrap_float">
                <a href="/">FirstRow</a>
                <span class="separator">/</span>
                <a href="/galeria">Galeria</a>
            </div>
        </div>
    </div>
    <div class="gallery-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <h1 class="title">Galería</h1>
                        <div class="select_wrap">
                            <asp:DropDownList ID="Direccion" runat="server" OnSelectedIndexChanged="Direccion_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <asp:Panel id="add_galeria" runat="server">
                            <div class="buttons">
                                <a href="/agregar-seccion-galeria" class="btn button" style="color:white; font-size:larger;" tabindex="-1">Añadir</a>
                             </div>
                        </asp:Panel>
                    </div>
                <div class="gallery-page-body">
                    <div class="gallery-list">
                        <asp:Panel ID="mostrar_galerias" runat="server">
                            </asp:Panel>
                     </div>
                </div>
            </div>
        </div>
</asp:Content>

