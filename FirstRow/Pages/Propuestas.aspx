<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Propuestas.aspx.cs" Inherits="FirstRow.Pages.Propuestas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
     <div class="image_header" runat="server" id="background_image_header" style="z-index: -3;"></div> 
    <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a href="/propuestas" style="color:white;">Propuestas</a>
                     <a id="add_form" runat="server" style="float: right; color:white;" href="/crear_propuesta">Agregar propuesta</a>
                </div>
            </div>
        </div>
        <div class="page blog-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                       <h1 class="title"><a style="color:white" href="/"><asp:Label ID="propuestas_titulo" runat="server"></asp:Label></a></h1>
                        <br />
                        <p class="subtitle" runat="server" style="color:white;" id="propuestas_texto"></p>
                       
                    </div>
                    <div class="page_body">
                        <div class="blog-list" runat="server" id="sorteos_list">   
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>