<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="FirstRow.Pages.Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="breadcrumbs white-color">
        <div class="wrap">
            <div class="wrap_float">
                <a href="/">FirstRow</a>
                <span class="separator">/</span>
                <a href="/galeria">Galeria</a>
                <a id="add" runat="server" style="float: right;" href="/agregar-seccion-galeria">Agregar sección</a>
            </div>
        </div>
    </div>
    <div class="gallery-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <asp:Label ID="Title_gal" runat="server" class="title" Text=""></asp:Label>
                        <div>
                        <asp:Label ID="Description_gal" runat="server" class="subtitle" Text=""></asp:Label>
                            </div>
                        <div class="select_wrap">
                            <asp:DropDownList ID="Direccion" runat="server" OnSelectedIndexChanged="Direccion_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        </div>
                    </div>
                <div class="gallery-page-body">
                    <div class="gallery-list">
                        <asp:Panel ID="mostrar_galerias" runat="server"></asp:Panel>
                     </div>
                </div>
            </div>
        </div>
       </div>
</asp:Content>

