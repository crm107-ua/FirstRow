<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="FirstRow.Pages.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="z-index:-3;background-image: url(https://www.pixelstalk.net/wp-content/uploads/images6/Beautiful-4K-Travel-Wallpaper-HD.jpg)"></div>
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
                                <div class="blog_single-head_top" style="background-image: url(https://wallpapershome.com/images/wallpapers/mountains-5120x2880-macos-4k-5k-sierra-sky-android-wallpaper-11473.jpg)">
                                    <div class="tags">
                                        <div class="tag red">Sierra</div>
                                        <div class="tag green">Italia</div>
                                    </div>
                                    <h1 class="title"><a style="color:white" href="/"><asp:Label ID="titulo" runat="server"></asp:Label></a></h1>
                                </div>
                                <div class="blog_single-head_bottom">
                                    <div class="author">
                                        <div class="userpic">
                                            <img src="https://wallpaperaccess.com/full/1431610.jpg" alt="">
                                        </div>
                                        <p class="name">20.09.2019 by Victor Shibut</p>
                                    </div>
                                </div>
                            </div>
                            <div class="blog_single-body">
                                <p class="description">
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur
                                </p>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <div class="stories">
                                    <h2>Stories</h2>
                                    <div class="scroll">
                                        <div class="scroll_wrap">
                                            <a href="/story/Italia" class="story_item" style="background-image: url(https://i.pinimg.com/originals/cf/fb/0e/cffb0e9cae7dea51b4e8a0effbeed5e1.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="shadow js-shadow"></div>
                                            </a>

                                            <a href="/story/Italia" class="story_item" style="background-image: url(https://r1.ilikewallpaper.net/iphone-12-pro-max-wallpapers/download-113692/Troll-Wall-Romsdal-Norway-mountains-4K-Travel.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="shadow js-shadow"></div>
                                            </a>

                                            <a href="/story/Italia" class="story_item" style="background-image: url(https://i.pinimg.com/736x/c6/7a/d9/c67ad952889e87af1f14999144c3dcbc.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="shadow js-shadow"></div>
                                            </a>

                                            <a href="/story/Italia" class="story_item" style="background-image: url(https://www.ixpap.com/images/2021/02/travel-wallpaper-ixpap-2.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="shadow js-shadow"></div>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class="two-colums">
                                    <h2>Texto Titulo 1</h2>
                                    <div>
                                        <div class="col">
                                            <p>
                                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore
                                            </p>
                                        </div>
                                        <div class="col">
                                            <p>
                                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class="quote">
                                    <p>
                                        Texto de cita
                                    </p>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <h2>
                                    Seccion imágenes de blog
                                </h2>
                                <div class="gallery-block">
                                    <div class="scroll lightgallery">
                                        <a href="https://sworld.co.uk/img/img/167/photoAlbum/324787/originals/0.jpeg" class="img">
                                            <img src="https://sworld.co.uk/img/img/167/photoAlbum/324787/originals/0.jpeg" alt="">
                                        </a>
                                        <a href="https://wallpaperaccess.com/full/134107.jpg" class="img">
                                            <img src="https://wallpaperaccess.com/full/134107.jpg" alt="">
                                        </a>
                                        <a href="https://c4.wallpaperflare.com/wallpaper/550/704/2/brown-bird-with-worm-in-its-beak-focus-lens-photography-wren-wren-wallpaper-preview.jpg" class="img">
                                            <img src="https://c4.wallpaperflare.com/wallpaper/550/704/2/brown-bird-with-worm-in-its-beak-focus-lens-photography-wren-wren-wallpaper-preview.jpg" alt="">
                                        </a>
                                    </div>
                                </div>
                                <h2>
                                    Texto Titulo 2
                                </h2>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Sed ut perspiciatis unde omnis iste natus error sit
                                </p>
                                <h2>
                                    Experiencia recomendada
                                </h2>
                                <div class="tour-block">
                                    <a href="tour-page-right-sidebar.html" class="item">
                                        <div class="item_left">
                                            <div class="image" style="background-image: url(https://wallpapermemory.com/uploads/546/venice-wallpaper-4k-492886.jpg)">
                                                <div class="shadow js-shadow"></div>
                                            </div>

                                        </div>
                                        <div class="item_right">
                                            <p class="country">Venecia</p>
                                            <div class="rating-stars">
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star"></div>
                                                <div class="star"></div>
                                            </div>
                                            <h3 class="item_title">
                                                Una experiencia inolvidable en Italia
                                            </h3>
                                            <p class="item_text">
                                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt
                                            </p>
                                            <div class="info">
                                                <div class="days">5 dias |</div>
                                                <div class="cost">desde 358€</div>
                                            </div>
                                            <div class="add_bookmark fav-button">
                                                <i class="is-added bouncy"></i>
                                                <i class="not-added bouncy"></i>
                                                <span class="fav-overlay"></span>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <div class="comments-block js-section" id="reviews">
                                <div class="title_wrap">
                                    <h2 class="title">Comentarios</h2>
                                    <div class="counter">2</div>
                                </div>
                                <div class="comments">
                                    <div class="comment_item">
                                        <div class="comment_item_top">
                                            <p>
                                                But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful.
                                            </p>
                                        </div>
                                        <div class="comment_item_bottom">
                                            <div class="author">
                                                <div class="userpic">
                                                    <img src="https://w0.peakpx.com/wallpaper/276/541/HD-wallpaper-alone-attitude-boy-single-thumbnail.jpg" alt="">
                                                </div>
                                                <p class="name">21.09.2019 por Jordi Cardona</p>
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
                                            <div class="author">
                                                <div class="name">21.09.2019 by Maya Delia</div>
                                                <div class="userpic">
                                                    <img src="https://i.pinimg.com/originals/4b/87/be/4b87be4b61783df07b80f9f3190e926c.jpg" alt="">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="write_comment">
                                <div class="top">
                                    <h3 class="title">Escribe un comentario</h3>
                                </div>
                                <div class="center">
                                    <textarea class="textarea" placeholder="Escribe lo que más te guste!"></textarea>
                                </div>
                                <div class="bottom">
                                    <button class="submit">Send</button>
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
