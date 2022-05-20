<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Sorteo.aspx.cs" Inherits="FirstRow.Pages.Sorteo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
      <div class="tour_page right-sidebar">
            <div class="tour_page_head" style="background-image: url(https://s1.1zoom.me/b5946/658/Italy_Vernazza_Liguria_Houses_Marinas_Boats_540593_1920x1080.jpg)">
                <div class="breadcrumbs">
                    <div class="wrap">
                        <div class="wrap_float">
                            <a href="/" style="color:white;">FirstRow</a>
                            <span class="separator" style="color:white;">/</span>
                            <a href="/sorteos" style="color:white;">Sorteos</a>
                            <span class="separator" style="color:white;">/</span>
                            <a href="/" style="color:white;"><asp:Label ID="slug" runat="server"></asp:Label></a>
                        </div>
                    </div>
                </div>
               <div class="header_content" id="head">
                    <div class="wrap">
                        <div class="wrap_float">
                            <div class="top-info">
                                <h1 class="tour_title">
                                    <asp:Label ID="titulo" runat="server"></asp:Label>
                                    </br>
                                </h1>
                                </br>
                                <p class="subtitle" style="color:white;"> 
                                    </br>
                                    <asp:Label ID="describe" runat="server"></asp:Label>
                                </p>
                            </div>
                            <div class="bottom-info">
                                <div class="bottom-info-left">
                                    <div class="search-tour">
                                        <div class="search-form">
                                            <div class="date-col">
                                                <asp:Label runat=server  style="color:white" class="label" ID="inicio" text="Inicio"></asp:Label>
                                                </br>
                                                <div class="num_col">
                                                <asp:Label runat=server  class="day" ID="diaI" text="Dia"></asp:Label>
                                                   
                                                    <div class="date_div_right">
                                                        <asp:Label runat=server  class="month" ID="mesI" ></asp:Label>
                                                        </br>
                                                      <asp:Label runat=server  class="year" ID="anioI" text="2019"></asp:Label>
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                         <div class="date-col">
                                                <asp:Label runat=server  style="color:white" class="label" ID="final" text="Final"></asp:Label>
                                                </br>
                                                <div class="date_div">
                                                <asp:Label runat=server  class="day" ID="diaF" text="Dia"></asp:Label>
                                                   
                                                    <div class="date_div_right">
                                                        <asp:Label runat=server  class="month" ID="mesF" ></asp:Label>
                                                        </br>
                                                      <asp:Label runat=server  class="year" ID="anioF" text="2019"></asp:Label>
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="num-col">
                                                <div style="color:white" class="label">Adultos</div>
                                                <div class="num_wrap">
                                                    <asp:Label runat="server" type="number" class="val js_num" text="2"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="num-col last">
                                                <div style="color:white" class="label">Niños</div>
                                                <div class="num_wrap">
                                                    <input type="number" class="val js_num" value="0" min="0" max="99">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="bottom-info-right">
                                    <div class="info">
                                        <asp:Label runat=server class="cost" ID="empresa"></asp:Label>
                                        <asp:Label class="cost" runat=server ID="participantes"></asp:Label>
                                    </div>
                                    <asp:Button runat=server type="button" class="btn button" text="Participar"></asp:Button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
           </div>      
      </div>
</asp:Content>

