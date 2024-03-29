﻿<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="FirstRow.Pages.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="main_slider js_height">
            <div class="slider_wrap" id="main_slider_wrap">
                <div class="slide">
                    <div class="bg-img" style="background-image: url(https://i.natgeofe.com/n/32f7dda9-f96d-478a-bd1a-28328253ab49/2103_BURKARD_08056%20copy.jpg)"></div>
                    <div class="wrap">
                        <div class="wrap_float js_height">
                            <div class="slide_content">
                                <div class="title_wrap">
                                    <p class="country">España</p>
                                    <h2 class="slide_title">La Palma</h2>
                                </div>
                                <p class="text" style="color:white;">
                                    Vive una de las experiencias más extremas de tu vida
                                </p>
                                <div class="buttons">
                                    <a href="/experiencias" class="btn button">Reserva ahora</a>
                                </div>
                                <div class="next_title">Japón</div>
                            </div>
                        </div>
                    </div>
                </div>

            <div class="slide">
                    <div class="bg-img" style = "background-image: url(https://cdn.wallpapersafari.com/72/27/nr6KEN.jpg)"></div>
                    <div class="wrap">
                        <div class="wrap_float js_height">
                            <div class="slide_content">
                                <div class="title_wrap">
                                    <p class="country">Japón</p>
                                    <h2 class="slide_title">Monte Fuji</h2>
                                </div>
                                <p class="text" style="color:white;">
                                    Vive una experiencia increíble en la excursión más impactante de tu vida
                                </p>
                                <div class="buttons">
                                    <a href="/experiencias" class="btn button">Reserva ahora</a>
                                </div>
                                <div class="next_title">Chile</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="slide">
                    <div class="bg-img" style="background-image: url(https://s.abcnews.com/images/Travel/HT_national_geographic2_cf_151223_22x15_1600.jpg)"></div>
                    <div class="wrap">
                        <div class="wrap_float js_height">
                            <div class="slide_content">
                                <div class="title_wrap">
                                    <p class="country">Chile</p>
                                    <h2 class="slide_title">Torres del Paine National Park</h2>
                                </div>
                                <p class="text" style="color:white;">
                                    Los paisajes más impresionantes del mundo
                                </p>
                                <div class="buttons">
                                    <a href="/experiencias" class="btn button">Reserva ahora</a>
                                </div>
                                <div class="next_title">España</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="arrows">
                <div class="arrow prev"></div>
                <div class="arrow next"></div>
            </div>
        </div>
<%--    <div class="most_popular">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="title_wrap">
                        <h2 class="title">Most Popular Tours</h2>
                        <p class="subtitle">
                            Latin literature from 45 BC, making it over 2000 years old
                        </p>
                        <div class="controls">
                            <a href="travel-list-right-sidebar.html" class="link">View All Tours</a>
                            <div class="arrows">
                                <div class="arrow prev"></div>
                                <div class="arrow next"></div>
                            </div>
                        </div>
                    </div>
                    <div class="section_content">
                        <div class="tour-slider" id="tour-slider">
                            <a href="tour-page-right-sidebar.html" class="tour_item" style="background-image: url(Assets/img/demo-bg.jpg)">
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

                            <a href="tour-page-right-sidebar.html" class="tour_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="tour_item_top">
                                    <p class="country">
                                        <span>United States of America</span>
                                    </p>
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
                                </div>
                                <div class="tour_item_bottom">
                                    <h3 class="_title">Antelope canyon in Arizona USA exclusive tour</h3>
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
                                            <p class="rating-text">5 reviews</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="tour-page-right-sidebar.html" class="tour_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="tour_item_top">
                                    <p class="country">
                                        <span>Iceland</span>
                                    </p>
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
                                </div>
                                <div class="tour_item_bottom">
                                    <h3 class="_title">Reykjavik</h3>
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

                            <a href="tour-page-right-sidebar.html" class="tour_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="tour_item_top">
                                    <p class="country">
                                        <span>The biggest part of the world</span>
                                    </p>
                                    <div class="add_bookmark fav-button">
                                        <i class="is-added bouncy"></i>
                                        <i class="not-added bouncy"></i>
                                        <span class="fav-overlay"></span>
                                    </div>
                                </div>
                                <div class="tour_item_bottom">
                                    <h3 class="_title">Asia</h3>
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
    <div class="destinations">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="title_wrap">
                        <h2 class="title">Top Destinations</h2>
                        <p class="subtitle">
                            This is the most popular destination in the last month
                        </p>
                        <div class="controls">
                            <a href="travel-list-image-header.html" class="link">View All Destinations</a>
                        </div>
                    </div>
                    <div class="section_content">
                        <div class="scroll">
                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">America</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Australia</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Portugal</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Russia</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Africa</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Italy</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Maldives</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="travel-list-full-width.html" class="destinations_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="_content">
                                                <h3 class="_title">Japan</h3>
                                                <p class="_info">45 tours | 62 hotels</p>
                                            </div>
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
    <div class="search-tour">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="search-form">
                        <div class="destination-col">
                            <div class="label">Destination</div>
                            <div class="select_wrap">
                                <select>
                                    <option value="Destination" disabled selected>Destination</option>
                                    <option value="United States">United States</option>
                                    <option value="United Kingdom">United Kingdom</option>
                                    <option value="Afghanistan">Afghanistan</option>
                                    <option value="Albania">Albania</option>
                                    <option value="Algeria">Algeria</option>
                                    <option value="American Samoa">American Samoa</option>
                                    <option value="Andorra">Andorra</option>
                                    <option value="Angola">Angola</option>
                                    <option value="Anguilla">Anguilla</option>
                                    <option value="Antarctica">Antarctica</option>
                                    <option value="Antigua and Barbuda">Antigua and Barbuda</option>
                                    <option value="Argentina">Argentina</option>
                                    <option value="Armenia">Armenia</option>
                                    <option value="Aruba">Aruba</option>
                                    <option value="Australia">Australia</option>
                                    <option value="Austria">Austria</option>
                                    <option value="Azerbaijan">Azerbaijan</option>
                                    <option value="Bahamas">Bahamas</option>
                                    <option value="Bahrain">Bahrain</option>
                                    <option value="Bangladesh">Bangladesh</option>
                                    <option value="Barbados">Barbados</option>
                                    <option value="Belarus">Belarus</option>
                                    <option value="Belgium">Belgium</option>
                                    <option value="Belize">Belize</option>
                                    <option value="Benin">Benin</option>
                                    <option value="Bermuda">Bermuda</option>
                                    <option value="Bhutan">Bhutan</option>
                                    <option value="Bolivia">Bolivia</option>
                                    <option value="Bosnia and Herzegovina">Bosnia and Herzegovina</option>
                                    <option value="Botswana">Botswana</option>
                                    <option value="Bouvet Island">Bouvet Island</option>
                                    <option value="Brazil">Brazil</option>
                                    <option value="British Indian Ocean Territory">British Indian Ocean Territory</option>
                                    <option value="Brunei Darussalam">Brunei Darussalam</option>
                                    <option value="Bulgaria">Bulgaria</option>
                                </select>
                            </div>
                        </div>
                        <div class="date-col">
                            <div class="label">Check In</div>
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
                            <div class="label">Check Out</div>
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
                            <div class="label">Aduld</div>
                            <div class="num_wrap">
                                <div class="buttons">
                                    <button type="button" class="plus"></button>
                                    <button type="button" class="minus"></button>
                                </div>
                                <input type="number" class="val js_num" value="3" min="0" max="99">
                            </div>
                        </div>
                        <div class="num-col last">
                            <div class="label">Children</div>
                            <div class="num_wrap">
                                <div class="buttons">
                                    <button type="button" class="plus"></button>
                                    <button type="button" class="minus"></button>
                                </div>
                                <input type="number" class="val js_num" value="3" min="0" max="99">
                            </div>
                        </div>
                        <button class="btn button"><span>Search</span></button>
                    </div>
                </div>
            </div>
        </div>
    <div class="stories">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="title_wrap">
                        <h2 class="title">Interesting Stories</h2>
                        <p class="subtitle">
                            Watch and be inspired
                        </p>
                        <div class="controls">
                            <a href="stories-right-sidebar.html" class="link">All Stories</a>
                            <div class="arrows">
                                <div class="arrow prev"></div>
                                <div class="arrow next"></div>
                            </div>
                        </div>
                    </div>
                    <div class="section_content">
                        <div class="stries_slider" id="stries_slider">
                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
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

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
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

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
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

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
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

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
                                            </div>
                                        </div>
                                        <h3 class="country">Switzerland</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
                                            </div>
                                        </div>
                                        <h3 class="country">Grece</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story.html" class="story_item" style="background-image: url(Assets/img/demo-bg.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <div class="flag_wrap">
                                            <div class="flag">
                                                <img src="Assets/img/demo-bg.jpg" alt="">
                                            </div>
                                        </div>
                                        <h3 class="country">Africa</h3>
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
            </div>
        </div>--%>
</asp:Content>



