<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Story.aspx.cs" Inherits="FirstRow.Pages.Story" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title>FirstRow - Making Dreams</title>
    <!--<link rel="stylesheet" type="text/css" href="~/assets/css/style.css" > -->
    <link rel="stylesheet" type="text/css" href="~/assets/css/style.css?v=<%DateTime.Now%>" >
    <link rel="icon" type="image/x-icon" href="~/assets/img/favicons/favicon.png">
    <meta name="msapplication-TileColor" content="#151515">
    <meta name="theme-color" content="#151515">
</head>  

<body>
    <div class="container">
        <div class="top_panel">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="left">
                        <a href="/" class="logo">
                            <img src="../../assets/img/Logo_Principal.png" alt="">
                        </a>
                    </div>
                    <div class="menu_wrap" id="menu_wrap">
                            <div class="scroll">
                                <div class="center">
                                    <div class="menu">
                                        <ul>
                                            <li><a href="/"><span>Home</span></a></li>
                                            <li><a href="/experiencias"><span>Experiencias</span></a></li>
                                            <li><a href="/galeria"><span>Galería</span></a></li>
                                            <li><a href="/stories"><span>Stories</span></a></li>
                                            <li><a href="/blogs"><span>Blogs</span></a></li>
                                            <li><a href="/sorteos"><span>Sorteos</span></a></li>
                                            <li class="dropdown_li">
                                                <a><span>FirstRow</span></a>
                                                <ul class="dropdown_ul">
                                                    <li><a href="/propuestas"><span>Propuestas</span></a></li>
                                                    <li><a href="/equipo"><span>Nuestro equipo</span></a></li>
                                                    <li><a href="/contacto"><span>Contacto</span></a></li>
                                                </ul>
                                            </li>
                                        </ul>
                                    </div>
                                </div><!--
                                <div class="user" id="userblock">
                                    <div class="userlink" id="userlink"></div>
                                    <div class="usermenu" id="usermenu">
                                        <ul>
                                            <li id="login_sect" runat="server"><a id="login_user_pop_up" class="js-popup-open" data-href="#login">Iniciar sesion</a></li>
                                            <li id="register_sect" runat="server"><a id="register_user_pop_up" class="js-popup-open" data-href="#registration">Registrarse</a></li>
                                            <li id="settings_sect" runat="server"><a id="settings_user_pop_up" class="js-popup-open" data-href="#profile-setting">Ajustes</a></li>
                                            <li id="settings_emp_sect" runat="server"><a id="settings_emp_pop_up"  class="js-popup-open" data-href="#empresa-setting">Ajustes de empresa</a></li> 
                                            <li id="logout_sect" runat="server"><a class="js-popup-open" data-href="#logout">Cerrar sesion</a></li>
                                        </ul>
                                            <%-- Elementos ocultos --%>
                                            <a hidden id="login_emp_pop_up" class="js-popup-open" data-href="#login_empresa">Iniciar sesion</a>
                                            <a hidden id="register_emp_pop_up" class="js-popup-open" data-href="#registro_empresa">Iniciar sesion</a>
                                    </div>
                                </div> -->
                            </div>
                        </div>
                </div>
            </div>
        </div>
        <div class="stories_page" id="stories_page">
            <a href="/experiencias" class="right_btn">Añadir story</a>
            <div class="left_bottom_title" id="left_bottom_title" runat="server"
                 style="position: absolute;
                        z-index: 2;
                        font-family: 'Prata', serif;
                        font-size: 55px;
                        text-align: center;
                        color: #fff;
                        width: auto;
                        height: 50px;
                        padding: 0 14px;
                        margin-bottom: 12px;
                        bottom: 25px;
                        left: 60px;"
                ></div>
            
            <!--<a href="stories-right-sidebar.html" class="right_btn">More stories</a>-->
            <div class="stories_bg" id="stories_bg"></div>
            <div class="stories_page_wrap">
                <div class="stories_box" id="stories_box">
                    <div class="arrows">
                        <div class="arrow prev disabled"></div>
                        <div class="arrow next"></div>
                    </div>
                    <div class="items stories_items" id="stories_items" runat="server">
                        
                        <a href="/stories" class="item" style="background-image: url(https://media-exp1.licdn.com/dms/image/C4D12AQHhj7R2c7hdrQ/article-cover_image-shrink_600_2000/0/1520167342937?e=1654128000&v=beta&t=cTkGEwA7jCsqkWK4C4TcSY5S4RNYGaZn1tru_nrckHE)" data-blur-bg="../../assets/img/demo-bg-4.jpg">
                            <!--
                            <div class="_info">
                                <div class="country"><span></span></div>
                            </div>
                            -->
                            <div>
                                <div class="tag">Última Story</div>
                            </div>
                            <h3 class="_title">
                                No hay más Stories
                            </h3>
                            <p class="_text">
                                Has llegado a la última Story, pulsa arriba en "Stories" para ver más
                            </p>
                        </a>
                        
                        <!--
                        <asp:Panel runat="server" class="item" id="default_story_panel" >
                            <div class="_info">
                                <div class="country"><span runat="server" id="country_span">Pais de ejemplo</span></div>
                            </div>
                            <h3 class="_title">
                                The amazing world of the animals of Madagascar
                            </h3>
                            <p class="_text">
                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem
                            </p>
                        </asp:Panel> -->
                    </div>
                    <div class="dots">
                        <ul></ul>
                    </div>
                    <div class="story_info">
                        <!--
                        <div class="author">
                            <div class="userpic">
                                <img src="../../assets/img/demo-bg.jpg" alt="">
                            </div>
                            <p class="name">21.09.2019 by Maya Delia</p>
                        </div> -->
                        <div class="counter" id="stories-counter">
                            <span class="this">1</span> / <span class="all"></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="orientation-message">
                To see stories you must rotate your device to portrait orientation
            </div>
        </div>

    </div>


    <script src="/assets/js/jquery.min.js"></script>
    <script src="/assets/js/jquery-ui.min.js"></script>
    <script src="/assets/js/lightgallery.js"></script>
    <script src="/assets/js/jquery.mousewheel.min.js"></script>
    <script src="/assets/js/slick.min.js"></script>
    <script src="/assets/js/hammer.js"></script>
    <script src="/assets/js/scripts.js"></script>

    </body>

</html>