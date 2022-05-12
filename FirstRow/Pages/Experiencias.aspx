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
                            <a href="/experiencia/viaje-a-croacia" class="tour_item" style="background-image: url(https://tripin.hellodigi.ru/img/tour-item-1.jpg)">
                                <div class="tour_item_top">
                                    <p class="country">
                                        <span>North Africa</span>
                                    </p>
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
                                </div>
                                <div class="tour_item_bottom">
                                    <h3 class="_title">A trip to the mighty desert</h3>
                                    <div class="_info">
                                        <div class="_info_left">
                                            <div class="days">5 days |</div>
                                            <div class="cost">from $356</div>
                                        </div>
                                        <div class="_info_right">
                                            <div class="rating-stars">
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star"></div>
                                                <div class="star"></div>
                                            </div>
                                            <p class="rating-text">10 reviews</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
