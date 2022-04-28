﻿<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="FirstRow.Pages.Galeria" %>
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
                    </div>
                    <asp:ScriptManager ID="Scrip1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="ActualizacionBoton" runat="server" ><ContentTemplate>
                        <!-- Para la animacion una vez se le da a ver más averiguar si pasa igual en dinamico !-->
                        <div class="gallery-page-body">
                            <div class="gallery-list">
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

                                <a href="/galeria/roma" class="gallery-item">
                                    <div class="top">
                                        <p class="country">Roma</p>
                                        <p class="title">La impresionante arquitectura de Roma</p>
                                    </div>
                                    <div class="images">
                                        <div class="scroll">
                                            <div class="img">
                                                <img src="https://p4.wallpaperbetter.com/wallpaper/919/302/326/urban-area-arch-of-septimius-severus-capitoline-hill-temple-of-saturn-wallpaper-preview.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://p4.wallpaperbetter.com/wallpaper/117/225/212/antigua-arquitectura-coliseum-roma-wallpaper-preview.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://arquitectomanuelnavarro.es/wp-content/uploads/2018/01/rome-2960832_1280.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://p1.piqsels.com/preview/322/856/859/roman-ruins-rome-italy-ancient-history.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://i.pinimg.com/originals/3e/23/c6/3e23c67e72041bca3737074b11e4b576.png" alt="">
                                            </div>
                                        </div>
                                    </div>
                                </a>

                                <a href="/galeria/madagascar" class="gallery-item">
                                    <div class="top">
                                        <p class="country">Madagascar</p>
                                        <p class="title">El mundo bajo la superficie</p>
                                    </div>
                                    <div class="images">
                                        <div class="scroll">
                                            <div class="img">
                                                <img src="https://img.freepik.com/foto-gratis/ballena-jorobada-salta-fuera-agua-hermoso-salto-madagascar-isla-santa-maria_265142-30.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://img.ev.mu/images/attractions/2127/960x640/412377.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://www.periodistadigital.com/wp-content/uploads/2019/03/madagascar-rayas.jpg?width=1200&enable=upscale" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="http://www.xdeep.eu/img/expeditions/malazamanga/gallery/images/7.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://laguiadelacuario.es/wp-content/uploads/2020/06/bedotia_geayipda.jpg" alt="">
                                            </div>
                                        </div>
                                    </div>
                                </a>

                                <a href="/galeria/tailandia" class="gallery-item">
                                    <div class="top">
                                        <p class="country">Tailandia</p>
                                        <p class="title">Hermosas playas</p>
                                    </div>
                                    <div class="images">
                                        <div class="scroll">
                                            <div class="img">
                                                <img src="https://www.costacruceros.es/content/dam/costa/costa-magazine/articles-magazine/beaches/thailand-beaches/spiaggia-railay-krabi_m.jpg.image.694.390.low.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://es.luxtraveldmc.com/blog/wp-content/uploads/2019/07/mejores-playas-de-Tailandia.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://todotailandia.com/wp-content/uploads/2017/04/maya-bay-tour.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://www.costacruceros.es/content/dam/costa/costa-magazine/articles-magazine/beaches/thailand-beaches/spiaggia-phi-phi-don-phi-phi-island_m.jpg.image.694.390.low.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="https://media.grandvoyage.com/__sized__/voyages/viajes-a-tailandia_1-thumbnail-1024x512-70.jpeg" alt="">
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                            <center>
                              <asp:Button ID="VerMas" runat="server" Text="Ver más" class="load_more button" OnClick="VerMas_Click"/>
                            </center>
                        </div>
                    </ContentTemplate></asp:UpdatePanel>
                </div>
            </div>
        </div>
</asp:Content>

