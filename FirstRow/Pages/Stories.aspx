<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Stories.aspx.cs" Inherits="FirstRow.Pages.Stories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <ajaxToolkit:ToolkitScriptManager runat="server"></ajaxToolkit:ToolkitScriptManager>
        <div class="image_header" runat="server" id="background_image_header" style="z-index: -3;"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a href="/stories" style="color:white;">Stories</a>
                    <a id="add_form" runat="server" style="float: right; color:white;" href="/agregar-story"></a>
                </div>
            </div> 
        </div>
        <div class="page stories-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <h1 class="title" runat="server" style="color:white;" id="stories_title"></h1>
                        <p class="subtitle" runat="server" style="color:white;" id="stories_subtitle">
                        </p>
                        <div class="select_wrap">
                            <asp:DropDownList runat="server" ID="country_list" AutoPostBack="true" OnSelectedIndexChanged="seleccionarPais" style="font-size: 18px" />

                        </div>
                        
                    </div>
                    <div class="page_body">
                        <div class="stories_list" runat="server" id="stories_list">
                            <!--
                            <a runat="server" id="russia_btn" href="story/russia" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Russia</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/maldives" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Maldives</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/australia" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Australia</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/madagascar" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Madagascar</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/switzerland" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Switzerland</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/grece" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Grece</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/africa" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Africa</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/arctic" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Arctic</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/arctic" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Arctic</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>

                            <a href="story/arctic" class="story_item" style="background-image: url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)">
                                <div class="item_wrap">
                                    <div class="_content">
                                        <h3 class="country">Arctic</h3>
                                        <p class="text">
                                            Amazing underwater world
                                        </p>
                                    </div>
                                </div>
                                <div class="shadow js-shadow"></div>
                            </a>
                            -->
                        </div>
                        <!--
                        <div class="btn_wrap load_btn_wrap">
                            <a class="load_more button"><span>Load more</span></a>
                        </div> -->
                    </div>
                </div>
            </div>
        </div>
        <div class="description-block">
            <div class="wrap">
                <div class="wrap_float">
                    <asp:Label runat="server" class="title" id="stories_description_title" />
                    <br />
                    <asp:TextBox runat="server" ID="stories_description_title_edit" Text="" Visible="false" />
                    <br />
                    <asp:Label runat="server" class="text" id="stories_description" /><br />
                    <asp:TextBox runat="server" ID="stories_description_edit" Text="" Visible="false" />
                </div>
            </div>
        </div>
</asp:Content>