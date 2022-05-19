<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Experiencia.aspx.cs" Inherits="FirstRow.Pages.Experiencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
      <div class="tour_page right-sidebar">
            <div id="bg_experiencia" runat="server" class="tour_page_head">
                <div class="breadcrumbs">
                    <div class="wrap">
                        <div class="wrap_float">
                            <a href="/" style="color:white;">FirstRow</a>
                            <span style="color:white;" class="separator">/</span>
                            <a href="/experiencias" style="color:white;">Experiencias</a>
                            <span class="separator" style="color:white;">/</span>
                            <a href="/" style="color:white;"><asp:Label ID="slug" runat="server" style="color:white;"></asp:Label></a>
                            <a id="empresa_enlace" runat="server"  style="color:white; float:right;"></a>
                        </div>
                    </div>
                </div>

                <div class="header_content" id="head">
                    <div class="wrap">
                        <div class="wrap_float">
                            <div class="top-info">
                                <p id="texto_pais" runat="server" class="country"></p>
                                <h1 id="texto_titulo" runat="server" class="tour_title">
                                    Una experiencia inolvidable por las playas más atractivas del mediterráneo
                                </h1>
                                <div class="controls">
                                    <div class="arrows" id="tour-head-slider-arrows">
                                        <div class="arrow prev"></div>
                                        <div class="arrow next"></div>
                                    </div>
                                </div>
                            </div>
                            <div class="slider_wrap">
                            <div class="slider lightgallery" id="tour-head-slider">
                                <div id="carga" class="slider lightgallery" runat="server"></div>
                                <a class="slide" style="pointer-events: none; z-index:-1;" > </a>   
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>  
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>   
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>   
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>  
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>   
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>  
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a>
                                <a class="slide" style="pointer-events: none; z-index:-1;"> </a> 
                             </div>
                            </div>
                            <div class="bottom-info">
                                <div class="bottom-info-left">
                                    <div class="search-tour">
                                        <div class="search-form">
                                            <div class="date-col">
                                                <div style="color:white" class="label">Entrada</div>
                                                <div class="date_div">
                                                    <input name="reservaEntrada" type="text" class="js_calendar desctop-input">
                                                    <input type="date" class="mobile-input">
                                                    <div class="day">21</div>
                                                    <div class="date_div_right">
                                                        <div class="month">May</div>
                                                        <div class="year">2022</div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="num-col">
                                                <div style="color:white" class="label">Personas</div>
                                                <div class="num_wrap">
                                                    <div class="buttons">
                                                        <button type='button' class="plus"></button>
                                                        <button type='button' class="minus"></button>
                                                    </div>
                                                    <input name="PersonNumber" type="number" class="val js_num" value="3" min="0" max="9">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="bottom-info-right">
                                    <div class="info">
                                        <div id="display_dias" runat="server" style="color:white;" class="days">5 dias |</div>
                                        <div id="display_precio" runat="server" style="color:white;" class="cost">desde 356€</div>
                                    </div>
                                    <asp:Button ID="reserva_button" runat="server" Text="Reserva Ahora" class="btn button" OnClick="reserva" />
                                    <div class="rating">
                                        <div id="display_comentarios" runat="server" style="color:white;" class="rating-text"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="tour_page_body">
                <div class="wrap">
                    <div class="wrap_float">
                        <div class="left_content">
                            <div class="overview js-section content-block" id="overview">
                                <h2 class="title">Descripción de la experiencia</h2>
                                <p id="display_description" runat="server" class="description">
                                </p>
                                <div class="programm" id="programm-days">
                                    <div id="generadorEtapas" runat="server"></div>
                                </div>
                            </div>
                            <div class="included js-section content-block" id="included">
                                <h2 class="title">Incluido</h2>
                                <ul id="generadorIncluidos" runat="server"></ul>
                            </div>
                            <div class="stories js-section content-block" id="stories">
                                <div class="title_wrap">
                                    <h2 class="title">Stories</h2>
                                    <div class="link">
                                        <a href="/stories">Todas las stories</a>
                                    </div>
                                </div>
                                <div class="stries_slider">
                                    <div id="generadorStories" runat="server" class="scroll">
                                        <div class="shadow js-shadow"></div>
                                    </div>
                                </div>
                            </div>
                            <div class="comments-block js-section" id="reviews">
                                <div class="title_wrap">
                                    <h2 class="title">Comentarios</h2>
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
                            <div class="navigation" id="sidebar-navigation">
                                <ul>
                                    <li><a class="active" href="#head">Imágenes</a></li>
                                    <li><a href="#overview">Descripción</a></li>
                                    <li><a href="#included">Incluido</a></li>
                                    <li><a href="#stories">Stories</a></li>
                                    <li><a href="#reviews">Comentarios</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
      </div>
</asp:Content>



