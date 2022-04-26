<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Experiencia.aspx.cs" Inherits="FirstRow.Pages.Experiencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
      <div class="tour_page right-sidebar">
            <div class="tour_page_head" style="background-image: url(https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg)">
                <div class="breadcrumbs">
                    <div class="wrap">
                        <div class="wrap_float">
                            <a href="/">FirstRow</a>
                            <span class="separator">/</span>
                            <a href="/experiencias">Experiencias</a>
                            <span class="separator">/</span>
                            <a href="/"><asp:Label ID="slug" runat="server"></asp:Label></a>
                        </div>
                    </div>
                </div>
                <div class="header_content" id="head">
                    <div class="wrap">
                        <div class="wrap_float">
                            <div class="top-info">
                                <p class="country">Croacia</p>
                                <h1 class="tour_title">
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
                                    <a href="https://wallpapercave.com/wp/wp1823653.jpg" class="slide">
                                        <img src="https://wallpapercave.com/wp/wp1823653.jpg" alt="">
                                    </a>
                                    <a href="https://cdn.wallpapersafari.com/35/35/EfVhaN.jpg" class="slide">
                                        <img src="https://cdn.wallpapersafari.com/35/35/EfVhaN.jpg" alt="">
                                    </a>
                                    <a href="https://c4.wallpaperflare.com/wallpaper/695/887/692/omis-dalmacija-croatia-wallpaper-hd-wallpaper-preview.jpg" class="slide">
                                        <img src="https://c4.wallpaperflare.com/wallpaper/695/887/692/omis-dalmacija-croatia-wallpaper-hd-wallpaper-preview.jpg" alt="">
                                    </a>
                                    <a href="https://i0.wp.com/www.rulandomundo.com/wp-content/uploads/split.jpg?fit=1024%2C678&ssl=1" class="slide">
                                        <img src="https://i0.wp.com/www.rulandomundo.com/wp-content/uploads/split.jpg?fit=1024%2C678&ssl=1" alt="">
                                    </a>
                                    <a href="https://www.lacroacia.es/wp-content/uploads/2014/04/anfiteatro_pula_croacia.jpg" class="slide">
                                        <img src="https://www.lacroacia.es/wp-content/uploads/2014/04/anfiteatro_pula_croacia.jpg" alt="">
                                    </a>
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
                                        <div class="cost">desde $356</div>
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
                                <h2 class="title">Descripción de la experiencias</h2>
                                <p class="description">
                                    But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                </p>
                                <div class="programm" id="programm-days">
                                    <div class="day_item">
                                        <div class="day_item-head active">
                                            <div class="preview">
                                                <div class="image">
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </div>
                                                <div class="p">Day 1</div>
                                            </div>
                                            <div class="_title">Transfer to hotel</div>
                                            <div class="element"></div>
                                        </div>
                                        <div class="day_item-body" style="display: block;">
                                            <div class="text">
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </div>
                                            <div class="images">
                                                <div class="scroll lightgallery">
                                                    <a href="img/demo-bg.jpg" class="item">
                                                        <div class="img">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                        <span>Signature under photo</span>
                                                    </a>
                                                    <a href="img/demo-bg.jpg" class="item">
                                                        <div class="img">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                        <span>Signature under photo</span>
                                                    </a>
                                                    <a href="img/demo-bg.jpg" class="item">
                                                        <div class="img">
                                                            <img src="img/demo-bg.jpg" alt="">
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
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </div>
                                                <div class="p">Day 2-4</div>
                                            </div>
                                            <div class="_title">Sightseeing tour</div>
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
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </div>
                                                <div class="p">Day 5</div>
                                            </div>
                                            <div class="_title">Free time</div>
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
                                <h2 class="title">Included</h2>
                                <ul>
                                    <li>
                                        <span class="li_title">Flight by plane</span>
                                        <span class="li_subtitle">Flight and transfer to the hotel</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Wi-fi</span>
                                        <span class="li_subtitle">Free wi-fi in the reception, wi-fi in public areas</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Smorgasbord</span>
                                        <span class="li_subtitle">But I must explain to you how all</span>
                                    </li>
                                    <li>
                                        <span class="li_title">Pool</span>
                                        <span class="li_subtitle">Beautiful and large swimming pool at your service</span>
                                    </li>
                                </ul>
                            </div>
                            <div class="location js-section content-block" id="location">
                                <h3 class="title">Location</h3>
                                <div class="map">
                                    <!--                            <iframe src=""></iframe>-->
                                </div>
                            </div>
                            <div class="stories js-section content-block" id="stories">
                                <div class="title_wrap">
                                    <h2 class="title">Stories</h2>
                                    <div class="link">
                                        <a href="#">All Stories</a>
                                    </div>
                                </div>
                                <div class="stries_slider">
                                    <div class="scroll">
                                        <a href="story.html" class="story_item" style="background-image: url(img/demo-bg.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <div class="flag_wrap">
                                                        <div class="flag">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                    </div>
                                                    <h3 class="country">Russia</h3>
                                                    <p class="text">
                                                        Amazing underwater world
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="story.html" class="story_item" style="background-image: url(img/demo-bg.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <div class="flag_wrap">
                                                        <div class="flag">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                    </div>
                                                    <h3 class="country">Maldives</h3>
                                                    <p class="text">
                                                        Amazing underwater world
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="story.html" class="story_item" style="background-image: url(img/demo-bg.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <div class="flag_wrap">
                                                        <div class="flag">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                    </div>
                                                    <h3 class="country">Australia</h3>
                                                    <p class="text">
                                                        Amazing underwater world
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="shadow js-shadow"></div>
                                        </a>

                                        <a href="story.html" class="story_item" style="background-image: url(img/demo-bg.jpg)">
                                            <div class="item_wrap">
                                                <div class="_content">
                                                    <div class="flag_wrap">
                                                        <div class="flag">
                                                            <img src="img/demo-bg.jpg" alt="">
                                                        </div>
                                                    </div>
                                                    <h3 class="country">Madagascar</h3>
                                                    <p class="text">
                                                        Amazing underwater world
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
                                    <h2 class="title">Reviews</h2>
                                    <div class="counter">12</div>
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
                                                    <img src="img/demo-bg.jpg" alt="">
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
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="comment_item">
                                        <div class="comment_item_top">
                                            <p>
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </p>
                                            <div class="images lightgallery">
                                                <a href="img/demo-bg.jpg" class="img">
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </a>
                                                <a href="img/demo-bg.jpg" class="img">
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </a>
                                                <a href="img/demo-bg.jpg" class="img">
                                                    <img src="img/demo-bg.jpg" alt="">
                                                </a>
                                            </div>
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
                                                    <img src="img/demo-bg.jpg" alt="">
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
                                    <h3 class="title">Write A Review</h3>
                                    <div class="rating">
                                        <div class="rating-text">Assigned Rating</div>
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
                                    <input type="text" class="input" placeholder="Name">
                                    <input type="text" class="input" placeholder="Email">
                                    <textarea class="textarea" placeholder="Reviews"></textarea>
                                </div>
                                <div class="bottom">
                                    <div class="files">
                                        <label for="file-1" class="label"><span>Add a photo</span></label>
                                        <input type="file" id="file-1">
                                        <div class="file-name"><span>IMG_5050.JPG,</span> <span>IMG_5051.JPG</span></div>
                                    </div>
                                    <button class="submit button">Send</button>
                                </div>
                            </div>
                        </div>
                        <div class="right_content sidebar">
                            <div class="navigation" id="sidebar-navigation">
                                <ul>
                                    <li><a class="active" href="#head">Imágenes</a></li>
                                    <li><a href="#overview">Descripción</a></li>
                                    <li><a href="#included">Incluido</a></li>
                                    <li><a href="#location">Localización</a></li>
                                    <li><a href="#stories">Stories</a></li>
                                    <li><a href="#reviews">Comentarios</a></li>
                                </ul>
                            </div>
                            <a class="book-now button js-popup-open" data-href="#book-now">
                                <span>Book now</span>
                                <span class="cost">from $356</span>
                            </a>
                            <div class="add-to-favorites">
                                <div class="add_bookmark fav-button">
                                    <i class="is-added bouncy"></i>
                                    <i class="not-added bouncy"></i>
                                    <span class="fav-overlay"></span>
                                </div>
                                <div class="fav-text">
                                    Add to favourites
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
      </div>
</asp:Content>

