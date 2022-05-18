<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="FirstRow.Pages.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="z-index:-3;background-image: url(https://wallpapers-hub.art/wallpaper-images/115204.jpg)"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a style="color:white" href="/">FirstRow</a>
                    <span style="color:white" class="separator">/</span>
                    <a style="color:white" href="/">Blog</a>
                    <span style="color:white" class="separator">/</span>
                    <a style="color:white" href="/"><asp:Label ID="slug" runat="server"></asp:Label></a>
                </div>
            </div>
        </div>
        <div class="page blog-list-page blog-single-page right-sidebar">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_body">
                        <div class="left_content">
                            <div class="blog_single-head">
                                <div id="imagen_principal" runat="server" class="blog_single-head_top">
                                    <div class="tags">
                                        <div id="text_categoria" runat="server" class="tag green"></div>
                                        <div id="text_pais" runat="server" class="tag blue"></div>
                                    </div>
                                    <h1 class="title"><a style="color:white" href="/"><asp:Label ID="titulo" runat="server"></asp:Label></a></h1>
                                </div>
                                <div class="blog_single-head_bottom">
                                    <div class="author">
                                        <div id="foto_perfil" runat="server" class="userpic"></div>
                                        <p id="text_fecha" runat="server" class="name"></p>
                                    </div>
                                </div>
                            </div>
                            <div class="blog_single-body">
                                <p id="text_description" runat="server" class="description"></p>
                                <p id="text_1" runat="server"></p>

                                <div class="stories">
                                    <h2 id="text_stories" runat="server">Stories</h2>
                                    <div class="scroll">
                                        <div id="cargaStories" runat="server" class="scroll_wrap">
                                        </div>
                                    </div>
                                </div>

                                <p id="text_2" runat="server"></p>
                                <div class="quote">
                                    <p id="text_cita" runat="server"></p>
                                </div>
                                <p id="text_3" runat="server"></p>

                                <h2>
                                    Imágenes del  blog
                                </h2>

                                <div class="gallery-block">
                                    <div id="cargaImagenes" runat="server" class="scroll"></div>
                                </div>
                                <h2 id="recomendadaAviso" runat="server">
                                    Experiencia recomendada
                                </h2>
                                <div id="recomendada" runat="server" class="tour-block">
                    
                                </div>
                            </div>
                            <div class="comments-block js-section" id="reviews">
                                <div class="title_wrap">
                                    <h2 id="text_comentarios" runat="server" class="title">Comentarios</h2>
                                    <div id="contadorComentarios" runat="server" class="counter"></div>
                                </div>
                                 <div id="generadorComentarios" runat="server" class="comments"></div>
                            </div>
                            <div id="seccion_escribir_comentario" runat="server" class="write_comment">
                                <div class="top">
                                    <h3 class="title">Escribe un comentario</h3>
                                    <div class="rating">
                                        <div class="rating-text">Estrellas</div>
                                        <div class="rating-stars stars user-rating">
                                            <div class="star"></div>
                                            <div class="star"></div>
                                            <div class="star"></div>
                                            <div class="star"></div>
                                            <div class="star"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="center">
                                    <textarea class="textarea" placeholder="Comentario"></textarea>
                                </div>
                                <div class="bottom">
                                    <button class="submit button">Comentar</button>
                                </div>
                            </div>
                        </div>
                        <div class="right_content sidebar">
                            <div  class="_block category_block">
                                <h4 class="block_title">
                                    Categorias
                                </h4>
                                <ul runat="server" id="listaCategorias"></ul>
                            </div>                        
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
