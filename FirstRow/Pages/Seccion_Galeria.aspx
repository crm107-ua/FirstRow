<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Seccion_Galeria.aspx.cs" Inherits="FirstRow.Pages.Seccion_Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="#">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/galeria">Galería</a>
                    <span class="separator">/</span>
                    <a href="/galeria">Seccion Galería</a>
                </div>
            </div>
        </div>
    <div class="gallery-page gallery-single-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <p class="country">Australia</p>
                        <h1 class="title">Beautiful birds of Australia</h1>
                        <div class="subtitle">
                            <p>
                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                            </p>
                        </div>
                    </div>
                    <div class="gallery-page-body">
                        <div class="image-list lightgallery">
                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                            <a href="img/demo-bg.jpg" class="image-item">
                                <img src="img/demo-bg.jpg" alt="">
                            </a>

                        </div>
                        <a href="tour-page-right-sidebar.html" class="tour">
                            <div class="item">
                                <div class="item_left">
                                    <div class="image" style="background-image: url(img/demo-bg.jpg)">
                                        <div class="shadow js-shadow"></div>
                                    </div>
                                </div>
                                <div class="item_right">
                                    <div class="_top">
                                        <p class="country">North Africa</p>
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
                                            A trip to the mighty desert
                                        </h3>
                                        <div class="item_text">
                                            <p>
                                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt
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
                            <h2 class="title">See also gallery</h2>
                            <div class="gallery-list">
                                <a href="gallery-single.html" class="gallery-item">
                                    <div class="top">
                                        <div class="country">Australia</div>
                                        <div class="title">Beautiful birds of Australia</div>
                                    </div>
                                    <div class="images">
                                        <div class="scroll">
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                        </div>
                                    </div>
                                </a>

                                <a href="gallery-single.html" class="gallery-item">
                                    <div class="top">
                                        <p class="country">Rome</p>
                                        <p class="title">Stunning architecture of Rome</p>
                                    </div>
                                    <div class="images">
                                        <div class="scroll">
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
                                            </div>
                                            <div class="img">
                                                <img src="img/demo-bg.jpg" alt="">
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
