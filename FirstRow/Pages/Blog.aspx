<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="FirstRow.Pages.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="z-index:-3;background-image: url(https://www.uncommoncaribbean.com/wp-content/uploads/2011/11/Caribbean-Sea-Sunset-Bequia1.jpg)"></div>
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
                                <div class="blog_single-head_top" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                    <div class="tags">
                                        <div class="tag red">Stream</div>
                                        <div class="tag green">Countries</div>
                                    </div>
                                    <h1 class="title"><a style="color:white" href="/"><asp:Label ID="titulo" runat="server"></asp:Label></a></h1>
                                </div>
                                <div class="blog_single-head_bottom">
                                    <div class="author">
                                        <div class="userpic">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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
                                            <a href="story.html" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                            <div class="flag">
                                                                <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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

                                            <a href="story.html" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                            <div class="flag">
                                                                <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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

                                            <a href="story.html" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                            <div class="flag">
                                                                <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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

                                            <a href="story.html" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                                <div class="item_wrap">
                                                    <div class="_content">
                                                        <div class="flag_wrap">
                                                            <div class="flag">
                                                                <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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
                                <div class="two-colums">
                                    <h2>Sed ut perspiciatis unde</h2>
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
                                        But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and
                                    </p>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <h2>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque
                                </h2>
                                <div class="gallery-block">
                                    <div class="scroll lightgallery">
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                    </div>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <h2>
                                    Laudantium, totam rem aperiam
                                </h2>
                                <div class="video_block">
                                    <div class="video">
                                        <!--<iframe src="https://www.youtube.com/embed/XXXXXXXXXXX?rel=0" allowfullscreen></iframe>-->
                                    </div>
                                    <span>Signature under video</span>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Sed ut perspiciatis unde omnis iste natus error sit
                                </p>
                                <div class="img-block">
                                    <img src="img/demo-bg-2.jpg" alt="">
                                    <span>Signature under photo</span>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit. Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit
                                </p>
                                <h2>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque
                                </h2>
                                <div class="tour-block">
                                    <a href="tour-page-right-sidebar.html" class="item">
                                        <div class="item_left">
                                            <div class="image" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)">
                                                <div class="shadow js-shadow"></div>
                                            </div>

                                        </div>
                                        <div class="item_right">
                                            <p class="country">North Africa</p>
                                            <div class="rating-stars">
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star filled"></div>
                                                <div class="star"></div>
                                                <div class="star"></div>
                                            </div>
                                            <h3 class="item_title">
                                                A trip to the mighty desert
                                            </h3>
                                            <p class="item_text">
                                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt
                                            </p>
                                            <div class="info">
                                                <div class="days">5 days |</div>
                                                <div class="cost">from $356</div>
                                            </div>
                                            <div class="add_bookmark fav-button">
                                                <i class="is-added bouncy"></i>
                                                <i class="not-added bouncy"></i>
                                                <span class="fav-overlay"></span>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                                <p>
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim
                                </p>
                                <div class="slider-block" id="blog-slider">
                                    <div class="arrows">
                                        <div class="arrow prev"></div>
                                        <div class="arrow next"></div>
                                    </div>
                                    <div class="full-width-link"></div>
                                    <div class="slider_top lightgallery">
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                        <a class="slide" href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </a>
                                    </div>
                                    <div class="slider_bottom">
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                        <div class="slide">
                                            <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="comments-block js-section" id="reviews">
                                <div class="title_wrap">
                                    <h2 class="title">Comments</h2>
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
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                                </div>
                                                <p class="name">21.09.2019 by Maya Delia</p>
                                            </div>
                                        </div>
                                        <div class="write_comment reply_form">
                                            <div class="top">
                                                <div class="title">Write A Reply</div>
                                                <div class="username">
                                                    <div class="userpic"></div>
                                                    <div class="login">Reply <span>Admin</span></div>
                                                </div>
                                                <div class="cancel">
                                                    <a href="#"><span>Click here to cancel reply</span></a>
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
                                                    <div class="file-name">IMG_5050.JPG, IMG_5051.JPG</div>
                                                </div>
                                                <button class="submit button">Send</button>
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
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
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
                                                <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                                </a>
                                                <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                                </a>
                                                <a href="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" class="img">
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                                </a>
                                            </div>
                                        </div>
                                        <div class="comment_item_bottom">
                                            <div class="author">
                                                <div class="userpic">
                                                    <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                                </div>
                                                <p class="name">21.09.2019 by Maya Delia</p>
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
                                </div>
                                <div class="center">
                                    <input type="text" class="input" placeholder="Name">
                                    <input type="text" class="input" placeholder="Email">
                                    <textarea class="textarea" placeholder="Reviews"></textarea>
                                </div>
                                <div class="bottom">
                                    <div class="files">
                                        <label for="file-2" class="label"><span>Add a photo</span></label>
                                        <input type="file" id="file-2">
                                        <div class="file-name"><span>IMG_5050.JPG,</span> <span>IMG_5051.JPG</span></div>
                                    </div>
                                    <button class="submit">Send</button>
                                </div>
                            </div>
                        </div>
                        <div class="right_content sidebar">
                            <div  class="_block category_block">
                                <h4 class="block_title">
                                    Category
                                </h4>
                                <ul>
                                    <li>
                                        <a href="#" class="active">
                                            <span>Show All</span>
                                            <span class="count">56</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span>Countries</span>
                                            <span class="count">56</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span>Stream</span>
                                            <span class="count">56</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span>Video</span>
                                            <span class="count">56</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#">
                                            <span>Travel</span>
                                            <span class="count">56</span>
                                        </a>
                                    </li>
                                </ul>
                            </div>

                            <div class="_block gallery_block">
                                <h4 class="block_title">
                                    Beautiful birds of Australia
                                </h4>
                                <div class="images">
                                    <a href="gallery-single.html" class="img">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </a>
                                    <a href="gallery-single.html" class="img">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </a>
                                    <a href="gallery-single.html" class="img">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </a>
                                    <a href="gallery-single.html" class="img">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </a>
                                </div>
                                <a class="link" href="gallery.html">View All Photo</a>
                            </div>

                            <div class="_block">
                                <h4 class="block_title">
                                    Popular travel
                                </h4>
                                <div class="popular">
                                    <a href="tour-page-right-sidebar.html" class="item">
                                        <div class="item_top">
                                            <div class="img" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)"></div>
                                            <h5 class="_title">
                                                A trip to the mighty desert
                                            </h5>
                                        </div>
                                        <div class="item_bottom">
                                            <div class="days">5 days |</div>
                                            <div class="cost">from $356</div>
                                        </div>
                                    </a>

                                    <a href="tour-page-right-sidebar.html" class="item">
                                        <div class="item_top">
                                            <div class="img" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)"></div>
                                            <h5 class="_title">
                                                Antelope canyon in Arizona USA exclusive tour
                                            </h5>
                                        </div>
                                        <div class="item_bottom">
                                            <div class="days">5 days |</div>
                                            <div class="cost">from $356</div>
                                        </div>
                                    </a>

                                    <a href="tour-page-right-sidebar.html" class="item">
                                        <div class="item_top">
                                            <div class="img" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg)"></div>
                                            <h5 class="_title">
                                                Asia
                                            </h5>
                                        </div>
                                        <div class="item_bottom">
                                            <div class="days">5 days |</div>
                                            <span class="sale">-23%</span>
                                            <div class="cost">from $356</div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="blog">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="title_wrap">
                        <h2 class="title">Recent Blog Posts</h2>
                        <p class="subtitle">
                            Watch and be inspired
                        </p>
                        <div class="controls">
                            <a href="blog-left-sidebar.html" class="link">All Blog Posts</a>
                        </div>
                    </div>
                    <div class="section_content">
                        <a href="blog-single-right-sidebar.html" class="blog_item">
                            <div class="blog_item_top" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg);">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="tags">
                                                <div class="tag red">Stream</div>
                                                <div class="tag green">Countries</div>
                                            </div>
                                            <h3 class="_title">
                                                Most popular destinations destinations
                                            </h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </div>
                            <div class="blog_item_bottom">
                                <div class="author">
                                    <div class="userpic">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </div>
                                    <p class="date">21.09.2019 by Maya Delia</p>
                                </div>
                                <p class="text">
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque
                                </p>
                            </div>
                        </a>

                        <a href="blog-single-right-sidebar.html" class="blog_item">
                            <div class="blog_item_top" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg);">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="tags">
                                                <div class="tag blue">Video</div>
                                            </div>
                                            <h3 class="_title">
                                                Most popular destinations destinations
                                            </h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </div>
                            <div class="blog_item_bottom">
                                <div class="author">
                                    <div class="userpic">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </div>
                                    <p class="date">21.09.2019 by Maya Delia</p>
                                </div>
                                <p class="text">
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque
                                </p>
                            </div>
                        </a>

                        <a href="blog-single-right-sidebar.html" class="blog_item">
                            <div class="blog_item_top" style="background-image: url(https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg);">
                                <div class="sq_parent">
                                    <div class="sq_wrap">
                                        <div class="sq_content">
                                            <div class="tags">
                                                <div class="tag black">Trips</div>
                                            </div>
                                            <h3 class="_title">
                                                Most popular destinations destinations
                                            </h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </div>
                            <div class="blog_item_bottom">
                                <div class="author">
                                    <div class="userpic">
                                        <img src="https://img.freepik.com/vector-gratis/fondo-abstracto-blanco-estilo-papel-3d_23-2148403778.jpg" alt="">
                                    </div>
                                    <p class="date">21.09.2019 by Maya Delia</p>
                                </div>
                                <p class="text">
                                    Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque
                                </p>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
