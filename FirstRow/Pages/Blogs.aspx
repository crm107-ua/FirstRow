<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="FirstRow.Pages.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://www.articlering.com/wp-content/uploads/2022/02/1356543-download-wallpaper-with-writing-1920x1080-for-samsung.jpg)"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a href="/blogs" style="color:white;">Blogs</a>
                </div>
            </div>
        </div>
        <div class="page blog-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <h1 class="title" style="color:white;">
                            Blogs <asp:Label ID="pais_blog" runat="server"></asp:Label>
                        </h1>
                        <p class="subtitle" style="color:white;">
                            Lo que escriben nuestros soñadores
                        </p>
                        <div class="filters">
                            <div class="select_wrap">
                                <asp:DropDownList 
                                       ID="lista_categorias_blogs" 
                                       class="input" 
                                       AutoPostBack="True"
                                       OnSelectedIndexChanged="seleccionDeCategoria"
                                       style="width:100%; height:57px; margin-bottom: 20px;" 
                                       runat="server">
                                </asp:DropDownList>
                            </div>
                            <div style="margin-right:30px;" class="search_wrap">
                                <input class="input" placeholder="Search" type="text">
                                <button class="submit"></button>
                            </div>
                        </div>
                    </div>
                    <div class="page_body">
                        <div class="blog-list">
                            <a class="blog_item" href="/blog/experiencia-en-italia">
                                <div class="blog_item_top" style="background-image: url(https://www.teahub.io/photos/full/200-2000529_italy-venice.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag red">
                                                        Ciudad
                                                    </div>
                                                    <div class="tag green">
                                                        Excursión
                                                    </div>
                                                </div>
                                                <h3 class="_title">
                                                    Destinos populares en Italia
                                                </h3>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="shadow js-shadow"></div>
                                </div>
                                <div class="blog_item_bottom">
                                    <div class="author">
                                        <div class="userpic">
                                            <img alt="" src="https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg">
                                        </div>
                                        <p class="date">
                                            21.09.2022 por Franco
                                        </p>
                                    </div>
                                </div>
                            </a>
                            <a class="blog_item" href="/blog/experiencia-en-la-cordillera-de-los-alpes">
                                <div class="blog_item_top" style="background-image: url(https://eskipaper.com/images/amazing-mountain-road-wallpaper-1.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag black">
                                                        Montaña
                                                    </div>
                                                </div>
                                                <h3 class="_title">
                                                    Experiencia en la cordillera de los Alpes
                                                </h3>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="shadow js-shadow"></div>
                                </div>
                                <div class="blog_item_bottom">
                                    <div class="author">
                                        <div class="userpic">
                                            <img alt="" src="https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg">
                                        </div>
                                        <p class="date">
                                            21.09.2022 by Akira
                                        </p>
                                    </div>
                                </div>
                            </a>
                            <a class="blog_item" href="/blog/experiencia-en-avion">
                                <div class="blog_item_top" style="background-image: url(http://viau.mx/wp-content/uploads/2020/04/white-airliner-wing-on-top-of-sea-clouds-2007401-scaled.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag blue">
                                                        Avión
                                                    </div>
                                                </div>
                                                <h3 class="_title">
                                                    Como trartar el jetlag hoy en día
                                                </h3>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="shadow js-shadow"></div>
                                </div>
                                <div class="blog_item_bottom">
                                    <div class="author">
                                        <div class="userpic">
                                            <img alt="" src="https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg">
                                        </div>
                                        <p class="date">
                                            21.09.2019 por Julio
                                        </p>
                                    </div>
                                </div>
                            </a>                         
                        </div>
                        <div class="btn_wrap load_btn_wrap">
                            <a class="load_more button"><span>Más blogs</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="subscribe_section">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="subscribe_block" style="background-image: url(img/demo-bg.jpg)">
                        <div class="left">
                            <h2 class="_title">
                                Nuevas noticias
                            </h2>
                            <p class="_subtitle">
                                Inicia sesión para obtener las mejores ofertas por email
                            </p>
                        </div>
                        <div class="right">
                            <div class="input_wrap select_wrap">
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
                            <div class="input_wrap">
                                <input class="input" placeholder="Email" type="email">
                            </div>
                            <button class="submit button"><span>Subscribe</span></button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
