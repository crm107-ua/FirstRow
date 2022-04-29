<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="FirstRow.Pages.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://www.articlering.com/wp-content/uploads/2022/02/1356543-download-wallpaper-with-writing-1920x1080-for-samsung.jpg)"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a href="/blogs" style="color:white;">Blogs <asp:Label ID="pais_blog" runat="server"></asp:Label></a>
                </div>
            </div>
        </div>
        <div class="page blog-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <h1 class="title" style="color:white;">
                            Blogs <asp:Label ID="pais_blog_titulo" runat="server"></asp:Label>
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
                            <a class="blog_item" href="/blog/interior/experiencia-en-italia">
                                <div class="blog_item_top" style="background-image: url(https://www.teahub.io/photos/full/200-2000529_italy-venice.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag red">
                                                        Interior
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
                            <a class="blog_item" href="/blog/sierra/experiencia-en-la-cordillera-de-los-alpes">
                                <div class="blog_item_top" style="background-image: url(https://eskipaper.com/images/amazing-mountain-road-wallpaper-1.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag black">
                                                        Sierra
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
                            <a class="blog_item" href="/blog/verano/experiencia-en-avion">
                                <div class="blog_item_top" style="background-image: url(http://viau.mx/wp-content/uploads/2020/04/white-airliner-wing-on-top-of-sea-clouds-2007401-scaled.jpg);">
                                    <div class="sq_parent">
                                        <div class="sq_wrap">
                                            <div class="sq_content">
                                                <div class="tags">
                                                    <div class="tag blue">
                                                        Verano
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
</asp:Content>
