<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="FirstRow.Pages.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" style="background-image: url(https://wallpapershome.com/images/pages/pic_h/23357.jpg)"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a style="color:white;">Blogs <asp:Label ID="pais_blog" runat="server"></asp:Label></a>
                    <a id="add_form" runat="server" style="float: right; color:white;" href="/agregar-blog"></a>
                </div>
            </div>
        </div>
        <div class="page blog-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <div class="title" style="color:white;">
                            <asp:Label ID="blog_title" runat="server"></asp:Label>
                            <asp:Label ID="pais_blog_titulo" runat="server"></asp:Label>
                        </div>
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
