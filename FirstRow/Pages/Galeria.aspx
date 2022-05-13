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
                            <asp:DropDownList ID="Direccion" runat="server" OnSelectedIndexChanged="Direccion_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <asp:Panel id="add_galeria" runat="server">
                            <div class="buttons">
                                <a href="/agregar-seccion-galeria" class="btn button" style="color:white; font-size: large;" tabindex="-1">Añadir</a>
                             </div>
                        </asp:Panel>
                    </div>
                <div class="gallery-page-body">
                    <div class="gallery-list">
                        <asp:Panel ID="mostrar_galerias" runat="server">
                            </asp:Panel>

                        <a href="/galeria/australia" class="gallery-item">
                            <div class="top">
                                <p class="country">Australia</p>
                                <p class="title">Las preciosas aves de Australia</p>
                            </div>
                            <div class="images">
                                <div class="scroll">
                                    <div class="img">
                                        <img src="https://www.junglepark.es/wp-content/uploads/2017/05/casuarioblog2-1024x978.jpg" alt="">
                                    </div>
                                    <div class="img">
                                        <img src="https://p0.pikist.com/photos/377/731/pelican-bird-sea-birds-water-nature-australia-pelecanus-conspicillatus-australian-pelican-4k-wallpaper.jpg" alt="">
                                    </div>
                                    <div class="img">
                                        <img src="https://dam.ngenespanol.com/wp-content/uploads/2021/03/GettyImages-976978800.jpg" alt="">
                                    </div>
                                    <div class="img">
                                        <img src="https://dam.ngenespanol.com/wp-content/uploads/2021/03/aves.jpg" alt="">
                                    </div>
                                    <div class="img">
                                        <img src="https://www.el-carabobeno.com/wp-content/uploads/2017/09/maxresdefault-7.jpg" alt="">
                                    </div>
                                </div>
                            </div>
                        </a>
                </div>
            </div>
        </div>
</asp:Content>

