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
                        <p class="country"><asp:Label ID="pais" runat="server"></asp:Label></p>
                        <asp:Label ID="title" runat="server" class="title" style="margin-top:20px; width:100%;"></asp:Label>
                        <div class="subtitle">
                            <asp:Label ID="Descripcion" runat="server"></asp:Label>
                        </div>
                    </div>
                    <div class="gallery-page-body">
                        <div class="image-list lightgallery">
                            <asp:Panel ID="addImg" runat="server">
                                </asp:Panel>
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
