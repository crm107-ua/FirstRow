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
                </div>
            </div>
        </div>
    <div class="gallery-page gallery-single-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <p class="country"><asp:Label ID="titulo" runat="server"></asp:Label></p>
                        <h1 class="title" style="margin-top:20px; width:100%;">Hermosas aves por el mundo</h1>
                        <div class="subtitle">
                            <p>
                                Podemos ver a las preciosas aves en pleno explendor, la naturaleza es admirable y siempre te sorprende
                            </p>
                        </div>
                    </div>
                    <div class="gallery-page-body">
                        <div class="image-list lightgallery">
                            <a href="https://www.junglepark.es/wp-content/uploads/2017/05/casuarioblog2-1024x978.jpg" class="image-item">
                                <img src="https://www.junglepark.es/wp-content/uploads/2017/05/casuarioblog2-1024x978.jpg" alt="">
                            </a>
                            <a href="https://p0.pikist.com/photos/377/731/pelican-bird-sea-birds-water-nature-australia-pelecanus-conspicillatus-australian-pelican-4k-wallpaper.jpg" class="image-item">
                                <img src="https://p0.pikist.com/photos/377/731/pelican-bird-sea-birds-water-nature-australia-pelecanus-conspicillatus-australian-pelican-4k-wallpaper.jpg" alt="">
                            </a>
                            <a href="https://dam.ngenespanol.com/wp-content/uploads/2021/03/GettyImages-976978800.jpg" class="image-item">
                                <img src="https://dam.ngenespanol.com/wp-content/uploads/2021/03/GettyImages-976978800.jpg" alt="">
                            </a>
                            <a href="https://dam.ngenespanol.com/wp-content/uploads/2021/03/aves.jpg" class="image-item">
                                <img src="https://dam.ngenespanol.com/wp-content/uploads/2021/03/aves.jpg" alt="">
                            </a>
                            <a href="https://www.el-carabobeno.com/wp-content/uploads/2017/09/maxresdefault-7.jpg" class="image-item">
                                <img src="https://www.el-carabobeno.com/wp-content/uploads/2017/09/maxresdefault-7.jpg" alt="">
                            </a>
                        </div>
                        <a href="/experiencias" class="tour">
                            <div class="item">
                                <div class="item_left">
                                    <div class="image" style="background-image: url(https://media.istockphoto.com/photos/ait-benhaddou-ancient-city-in-morocco-north-africa-picture-id982105760?k=20&m=982105760&s=612x612&w=0&h=gheGJi_2vF29VX1VZ6lTf8IIPrPk8Nc2FkAl6AE94Hc=)">
                                        <div class="shadow js-shadow"></div>
                                    </div>
                                </div>
                                <div class="item_right">
                                    <div class="_top">
                                        <p class="country">Africa del Norte</p>
                                    </div>
                                    <div class="_center">
                                        <div class="rating-stars">
                                            <div class="star filled"></div>
                                            <div class="star filled"></div>
                                            <div class="star filled"></div>
                                            <div class="star"></div>
                                            <div class="star"></div>
                                        </div>
                                        <h3 class="item_title">
                                            Un viaje por el desierto
                                        </h3>
                                        <div class="item_text">
                                            <p>
                                                En nuestro recorido pasaremos por ciudades emblematicas cruzando por el caluroso desierto
                                            </p>
                                        </div>
                                    </div>
                                    <div class="_bottom">
                                        <div class="info">
                                            <div class="days">5 days |</div>
                                            <div class="cost">from $356</div>
                                        </div>
                                    </div>
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
                                </div>
                            </div>
                        </a>
                        <div class="other_gallery">
                            <h2 class="title">También te puede interesar</h2>
                            <div class="gallery-list">
                                <a href="galeria/madagascar" class="gallery-item">
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
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
