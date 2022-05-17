<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="FirstRow.Pages.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://www.articlering.com/wp-content/uploads/2022/02/1356543-download-wallpaper-with-writing-1920x1080-for-samsung.jpg)"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a style="color:white;">Blogs <asp:Label ID="pais_blog" runat="server"></asp:Label></a>
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
                        <p id="resultado_busqueda" runat="server" class="subtitle" style="color:white;"></p>
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
                        </div>
                    </div>
                    <div class="page_body">
                        <div id="cargaBlogs" runat="server" class="blog-list"></div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
