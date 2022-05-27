<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Seccion_Galeria.aspx.cs" Inherits="FirstRow.Pages.Seccion_Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="#">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/galeria">Galería</a>
                    <span class="separator">/</span>
                    <a href="/"><asp:Label ID="slug" runat="server"></asp:Label></a>
                    <a id="user_enlace" runat="server"  style="color:white; float:right;"></a>
                </div>
            </div>
        </div>
    <div class="gallery-page gallery-single-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <p class="country"><asp:Label ID="pais" runat="server"></asp:Label></p>
                        <asp:Panel id="delete_galeria" runat="server" CssClass="buttons">
                            <asp:Button ID="Button1" CssClass="buttons" BorderStyle="None" Font-Size="Larger" runat="server" OnClick="borradoGaleria" Text="Borrar"/>
                        </asp:Panel>
                            <div class="gallery-page-head">
                                <asp:Label ID="title" runat="server" class="title" style="margin-top:20px; width:100%;"></asp:Label>
                            </div>
                        <div class="subtitle">
                            <asp:Label ID="Descripcion" runat="server"></asp:Label>
                        </div>
                    </div>
                    <div class="gallery-page-body">
                        <div class="image-list">
                            <asp:Panel ID="addImg" runat="server">
                            </asp:Panel>
                        </div>
                        <div class="other_gallery">
                            <h2 class="title">Experiencia que te puede interesar</h2>
                            <div class="gallery-list">
                                <asp:Panel ID="mostrar_experiencias" runat="server" class="posts">
                            </asp:Panel>
                                    </div>
                                    </div>
                        <div class="other_gallery">
                            <h2 class="title">También te puede interesar</h2>
                            <div class="gallery-list">
                                <asp:Panel ID="masGaleri" runat="server">

                                </asp:Panel>
                                    </div>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
