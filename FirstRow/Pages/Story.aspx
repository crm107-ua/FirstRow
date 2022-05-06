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
                                        <div class="mobile_content">
                                            <div class="tel">
                                                <a href="tel:+0034411345777">+ 00 344 113 457 77</a>
                                                <p>Soporte 24h</p>
                                            </div>
                                            <div class="social">
                                                <a href="#" class="link facebook"><span></span></a>
                                                <a href="#" class="link instagram"><span></span></a>
                                                <a href="#" class="link pinterest"><span></span></a>
                                                <a href="#" class="link twitter"><span></span></a>
                                                <a href="#" class="link youtube"><span></span></a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="close" id="menu-close">
                                        <span></span>
                                        <span></span>
                                        <span></span>
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
                    <div class="mobile_btn" id="mobile_btn">
                        <span></span>
                        <span></span>
                        <span></span>
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
                        
                        <a href="/stories" class="item" style="background-image: url(https://media-exp1.licdn.com/dms/image/C4D12AQHhj7R2c7hdrQ/article-cover_image-shrink_600_2000/0/1520167342937?e=1654128000&v=beta&t=cTkGEwA7jCsqkWK4C4TcSY5S4RNYGaZn1tru_nrckHE)" data-blur-bg="../../assets/img/demo-bg-2.jpg">
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

    <div class="modal_search" id="modal_search">
        <div class="close"></div>
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
                                    <button class="plus"></button>
                                    <button class="minus"></button>
                                </div>
                                <input type="number" class="val js_num" value="3" min="0" max="99">
                            </div>
                        </div>
                        <div class="num-col last">
                            <div class="label">Children</div>
                            <div class="num_wrap">
                                <div class="buttons">
                                    <button class="plus"></button>
                                    <button class="minus"></button>
                                </div>
                                <input type="number" class="val js_num" value="3" min="0" max="99">
                            </div>
                        </div>
                        <button class="btn button">
                            <span>Search</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="overlay" id="overlay"></div>

    <div class="popup login" id="login">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Sign In</div>
                    <a class="link js-popup-open" data-href="#registration">Sign Up</a>

                </div>
                <div class="popup-body">
                    <div class="subtitle">
                        Use the e-mail and password that you specified when registering on the site
                    </div>
                    <div class="form">
                        <input type="text" class="input" placeholder="Login">
                        <input type="text" class="input" placeholder="Password">
                        <button class="submit button">Sign In</button>
                        <a href="#" class="link">Forgot password?</a>
                    </div>
                </div>
                <div class="popup-foot">
                    <p>Login via social networks</p>
                    <div class="social-links">
                        <a href="#" class="link facebook"><span></span></a>
                        <a href="#" class="link twitter"><span></span></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>


    <div class="popup registration" id="registration">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Sign Up</div>
                    <a class="link js-popup-open" data-href="#login">Sign In</a>

                </div>
                <div class="popup-body">
                    <div class="subtitle">
                        Fill in the registration form and save your favorite tours, synchronize them on all devices
                    </div>
                    <div class="form">
                        <input type="text" class="input" placeholder="Username">
                        <input type="text" class="input" placeholder="Name">
                        <input type="text" class="input" placeholder="Surename">
                        <input type="email" class="input" placeholder="Email">
                        <input type="password" class="input" placeholder="Password">
                        <input type="password" class="input" placeholder="Password Repeat">
                        <button class="submit button js-submit">Registration</button>
                    </div>
                </div>
                <div class="popup-foot">
                    <p>Sign Up via social networks</p>
                    <div class="social-links">
                        <a href="#" class="link facebook"><span></span></a>
                        <a href="#" class="link twitter"><span></span></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>


    <div class="popup forgot-pass" id="recovery-pass">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Forgot password?</div>
                </div>
                <div class="popup-body">
                    <div class="subtitle">
                        Use the e-mail and password that you specified when registering on the site
                    </div>
                    <div class="form">
                        <input type="email" class="input" placeholder="Email">
                        <button class="submit button js-submit">Reset password</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>


    <div class="popup profile-setting" id="profile-setting">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="select-userpic">
                    <div class="userpic">V</div>
                    <div class="select">
                        <input type="file" id="profile-pic">
                        <label for="profile-pic">Select photo</label>
                    </div>
                </div>
                <div class="popup-head">
                    <div class="title">Setting</div>
                </div>
                <div class="popup-body">
                    <div class="form">
                        <input type="text" class="input" placeholder="Username" value="Victor777">
                        <input type="text" class="input" placeholder="Name" value="Victor">
                        <input type="text" class="input" placeholder="Surename" value="Shibut">
                        <input type="email" class="input" placeholder="Email" value="test@test.com">
                        <div class="label">Change password</div>
                        <input type="password" class="input" placeholder="Current password">
                        <input type="password" class="input" placeholder="Enter new password">
                        <input type="password" class="input" placeholder="New password repeat">
                        <div class="label">Authorization through social networks</div>
                        <div class="social-links">
                            <a href="#" class="link facebook active"><span></span></a>
                            <a href="#" class="link twitter"><span></span></a>
                        </div>
                        <button class="submit button js-submit">Save Setting</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>


    <div class="popup contact-us" id="contact-us">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Contact Us</div>
                </div>
                <div class="popup-body">
                    <div class="subtitle">
                        But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain
                    </div>
                    <div class="form">
                        <input type="text" class="input" placeholder="Name">
                        <input type="email" class="input" placeholder="Email">
                        <input type="text" class="input" placeholder="Phone">
                        <textarea class="textarea" placeholder="Your Massage"></textarea>
                        <button class="submit button js-submit">Send Massage</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>

    <div class="popup book-now-popup" id="book-now">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Book Now</div>
                </div>
                <div class="popup-body">
                    <div class="tour-title">
                        <div class="img">
                            <img src="img/demo-bg.jpg" alt="">
                        </div>
                        <div class="tour-name">
                            Tour to the Arctic is an exotic journey on the verge of extreme
                        </div>
                    </div>
                    <div class="tour-info">
                        <div class="col">
                            <div class="label">Check In</div>
                            <div class="date">
                                <div class="day">09</div>
                                <div class="month">May</div>
                                <div class="year">2019</div>
                            </div>
                            <div class="label">Aduld: <span>3</span></div>
                        </div>
                        <div class="col">
                            <div class="label">Check Out</div>
                            <div class="date">
                                <div class="day">09</div>
                                <div class="month">May</div>
                                <div class="year">2019</div>
                            </div>
                            <div class="label">Children: <span>0</span></div>
                        </div>
                    </div>
                    <div class="form">
                        <input type="text" class="input" placeholder="Your First Name">
                        <input type="text" class="input" placeholder="Your Last Name">
                        <input type="email" class="input" placeholder="Your Email">
                        <input type="tel" class="input" placeholder="Your Number Phone">
                        <textarea class="textarea" placeholder="Where are your address?"></textarea>
                        <textarea class="textarea" placeholder="Note:"></textarea>
                        <button class="submit button js-submit">Book Now | <b>$356</b></button>
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
    </div>

    <div class="popup success-popup" id="contact-us-success">
        <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Success</div>
                </div>
                <div class="popup-body">
                    <div class="subtitle">
                        Your message was successfully sent. We will contact you shortly
                    </div>
                </div>
            </div>
        </div>
        <div class="close"></div>
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