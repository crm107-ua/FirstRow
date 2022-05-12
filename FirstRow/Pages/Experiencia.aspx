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
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
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
                                                    <input type="text" class="js_calendar desctop-input">
                                                    <input type="date" class="mobile-input">
                                                    <div class="day">21</div>
                                                    <div class="date_div_right">
                                                        <div class="month">December</div>
                                                        <div class="year">2019</div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="date-col">
                                                <div style="color:white" class="label">Salida</div>
                                                <div class="date_div">
                                                    <input type="text" class="js_calendar desctop-input">
                                                    <input type="date" class="mobile-input">
                                                    <div class="day">21</div>
                                                    <div class="date_div_right">
                                                        <div class="month">December</div>
                                                        <div class="year">2019</div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="num-col">
                                                <div style="color:white" class="label">Adultos</div>
                                                <div class="num_wrap">
                                                    <div class="buttons">
                                                        <button type='button' class="plus"></button>
                                                        <button type='button' class="minus"></button>
                                                    </div>
                                                    <input type="number" class="val js_num" value="3" min="0" max="99">
                                                </div>
                                            </div>
                                            <div class="num-col last">
                                                <div style="color:white" class="label">Niños</div>
                                                <div class="num_wrap">
                                                    <div class="buttons">
                                                        <button type='button' class="plus"></button>
                                                        <button type='button' class="minus"></button>
                                                    </div>
                                                    <input type="number" class="val js_num" value="3" min="0" max="99">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="bottom-info-right">
                                    <div class="info">
                                        <div class="days">5 dias |</div>
                                        <div class="cost">desde 356€</div>
                                    </div>
                                    <button type="button" class="btn button">Reserva ahora</button>
                                    <div class="rating">
                                        <div class="rating-stars">
                                            <div class="star filled"></div>
                                            <div class="star filled"></div>
                                            <div class="star filled"></div>
                                            <div class="star filled"></div>
                                            <div class="star"></div>
                                        </div>
                                        <div class="rating-text">3 comentarios</div>
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
                                <p class="description">
                                    But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                </p>
                                <div class="programm" id="programm-days">
                                    <div class="day_item">
                                        <div class="day_item-head active">
                                            <div class="preview">
                                                <div class="image">
                                                    <img src="https://www.planetware.com/wpimages/2019/03/croatia-best-beaches-punta-rata-brela.jpg" alt="">
                                                </div>
                                                <div class="p">Day 1</div>
                                            </div>
                                            <div class="_title">Bienvenida a Croacia</div>
                                            <div class="element"></div>
                                        </div>
                                        <div class="day_item-body" style="display: block;">
                                            <div class="text">
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </div>
                                            <div class="images">
                                                <div class="scroll lightgallery">
                                                    <a href="https://www.croatiaweek.com/wp-content/uploads/2020/05/croatia-beach-summer-covid-recommendations.jpg" class="item">
                                                        <div class="img">
                                                            <img src="https://www.croatiaweek.com/wp-content/uploads/2020/05/croatia-beach-summer-covid-recommendations.jpg" alt="">
                                                        </div>
                                                        <span>Signature under photo</span>
                                                    </a>
                                                    <a href="https://www.theunionjournal.com/wp-content/uploads/2020/03/Croatia.jpg" class="item">
                                                        <div class="img">
                                                            <img src="https://www.theunionjournal.com/wp-content/uploads/2020/03/Croatia.jpg" alt="">
                                                        </div>
                                                        <span>Signature under photo</span>
                                                    </a>
                                                    <a href="https://ecty2018.org/wp-content/uploads/2018/11/Awarded-programs2.jpg" class="item">
                                                        <div class="img">
                                                            <img src="https://ecty2018.org/wp-content/uploads/2018/11/Awarded-programs2.jpg" alt="">
                                                        </div>
                                                        <span>Signature under photo</span>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="day_item">
                                        <div class="day_item-head">
                                            <div class="preview">
                                                <div class="image">
                                                    <img src="https://a.cdn-hotels.com/gdcs/production74/d1449/5695b321-d12f-425d-86db-fd6cc68eff36.jpg" alt="">
                                                </div>
                                                <div class="p">Day 2-4</div>
                                            </div>
                                            <div class="_title">Vistas por la ciudad</div>
                                            <div class="element"></div>
                                        </div>
                                        <div class="day_item-body">
                                            <div class="text">
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </div>
                                        </div>
                                    </div>

                                    <div class="day_item">
                                        <div class="day_item-head">
                                            <div class="preview">
                                                <div class="image">
                                                    <img src="https://media.gadventures.com/media-server/dynamic/admin/content_pages/croatia-destination-social.jpg" alt="">
                                                </div>
                                                <div class="p">Day 5</div>
                                            </div>
                                            <div class="_title">Tour nocturno</div>
                                            <div class="element"></div>
                                        </div>
                                        <div class="day_item-body">
                                            <div class="text">
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                            <div class="included js-section content-block" id="included">
                                <h2 class="title">Incluido</h2>
                                <ul>
                                    <li>
                                        <span class="li_title">Bebida</span>
                                        <span class="li_subtitle">Gratis en todo el recorrido</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Wi-fi</span>
                                        <span class="li_subtitle">Conexión a internet gratuita</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Comida</span>
                                        <span class="li_subtitle">Gratis en todo el recorrido</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Piscina</span>
                                        <span class="li_subtitle">Acceso premium a piscinas y gimnasios</span>
                                    </li>
                                </ul>
                            </div>
                            <div class="stories js-section content-block" id="stories">
                                <div class="title_wrap">
                                    <h2 class="title">Stories</h2>
                                    <div class="link">
                                        <a>Todas las stories</a>
                                    </div>
                                </div>
                                <div class="stries_slider">
                                    <div class="scroll">
                                        <a href="/stories" class="story_item" style="background-image: url(https://www.themayor.eu/web/files/articles/8689/main_image/thumb_1024x663_zagreb-croatia-2.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <p class="text">
                                                        Puerto en Croacia
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="/stories" class="story_item" style="background-image: url(https://media.cntraveler.com/photos/59809ccef7c3f505c149b858/5:4/w_1920,h_1536,c_limit/Rovinj-Croatia-GettyImages-184911149.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <p class="text">
                                                        Arquitectura mediterranea
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="/stories" class="story_item" style="background-image: url(https://media.worldnomads.com/Explore/europe/croatia-local-streets-istock.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <p class="text">
                                                        Pequeños rincones
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="story.html" class="story_item" style="background-image: url(https://www.intrepidtravel.com/adventures/wp-content/uploads/2017/01/Croatia-island-sailing.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <p class="text">
                                                        Recorrido en barca
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>
                                    </div>

                                </div>
                            </div>
                            <div class="comments-block js-section" id="reviews">
                                <div class="title_wrap">
                                    <div class="val">5.0</div>
                                    <h2 class="title">Comentarios</h2>
                                    <div class="counter">3</div>
                                </div>
                                <div class="comments">
                                    <div class="comment_item">
                                        <div class="comment_item_top">
                                            <p>
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </p>
                                        </div>
                                        <div class="comment_item_bottom">
                                            <div class="rating">
                                                <div class="rating-stars">
                                                    <div class="star filled"></div>
                                                    <div class="star filled"></div>
                                                    <div class="star filled"></div>
                                                    <div class="star"></div>
                                                    <div class="star"></div>
                                                </div>
                                                <button class="reply">Reply</button>
                                            </div>
                                            <div class="author">
                                                <div class="userpic">
                                                    <img src="https://cdn.pixabay.com/photo/2020/07/01/12/58/icon-5359553_1280.png" alt="Usuario">
                                                </div>
                                                <div class="name">21.09.2019 by Maya Delia</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="comment_item answer_comment">
                                        <div class="comment_item_top">
                                            <p>
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness.
                                            </p>
                                        </div>
                                        <div class="comment_item_bottom">
                                            <button class="reply">Reply</button>
                                            <div class="author">
                                                <div class="name">21.09.2019 by Maya Delia</div>
                                                <div class="userpic">
                                                    <img src="https://cdn.pixabay.com/photo/2020/07/01/12/58/icon-5359553_1280.png" alt="Usuario">
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="comment_item">
                                        <div class="comment_item_top">
                                            <p>
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </p>
                                        </div>
                                        <div class="comment_item_bottom">
                                            <div class="rating">
                                                <div class="rating-stars">
                                                    <div class="star filled"></div>
                                                    <div class="star filled"></div>
                                                    <div class="star filled"></div>
                                                    <div class="star"></div>
                                                    <div class="star"></div>
                                                </div>
                                                <button class="reply">Reply</button>
                                            </div>
                                            <div class="author">
                                                <div class="userpic">
                                                    <img src="https://cdn.pixabay.com/photo/2020/07/01/12/58/icon-5359553_1280.png" alt="Usuario">
                                                </div>
                                                <div class="name">21.09.2019 by Maya Delia</div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="pagination">
                                    <a class="arrow prev"></a>
                                    <ul>
                                        <li><a href="#" class="active">1</a></li>
                                        <li><a href="#">2</a></li>
                                        <li><a href="#">3</a></li>
                                        <li><a href="#">4</a></li>
                                    </ul>
                                    <a class="arrow next"></a>
                                </div>
                            </div>
                            <div class="write_comment">
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
                                    <input type="text" class="input" placeholder="Nombre">
                                    <input type="text" class="input" placeholder="Email">
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



