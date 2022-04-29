<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Sorteo.aspx.cs" Inherits="FirstRow.Pages.Sorteo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
      <div class="tour_page right-sidebar">
            <div class="tour_page_head" style="background-image: url(https://s1.1zoom.me/b5946/658/Italy_Vernazza_Liguria_Houses_Marinas_Boats_540593_1920x1080.jpg)">
                <div class="breadcrumbs">
                    <div class="wrap">
                        <div class="wrap_float">
                            <a href="/" style="color:white;">FirstRow</a>
                            <span class="separator" style="color:white;">/</span>
                            <a href="/experiencias" style="color:white;">Experiencias</a>
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
                                </h1>
                            </div>
                            <div class="bottom-info">
                                <div class="bottom-info-left">
                                    <div class="search-tour">
                                        <div class="search-form">
                                            <div class="date-col">
                                                <div style="color:white" class="label">Inicio</div>
                                                <div class="date_div">
                                                    <div class="day">21</div>
                                                    <div class="date_div_right">
                                                        <div class="month">December</div>
                                                        <div class="year">2019</div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="date-col">
                                                <div style="color:white" class="label">Final</div>
                                                <div class="date_div">
                                                    <div class="day">21</div>
                                                    <div class="date_div_right">
                                                        <div class="month">December</div>
                                                        <div class="year">2019</div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="num-col">
                                                <div style="color:white" class="label">Adultos</div>
                                                <div class="num_wrap">
                                                    <input type="number" class="val js_num" value="3" min="0" max="99">
                                                </div>
                                            </div>
                                            <div class="num-col last">
                                                <div style="color:white" class="label">Niños</div>
                                                <div class="num_wrap">
                                                    <input type="number" class="val js_num" value="3" min="0" max="99">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="bottom-info-right">
                                    <div class="info">
                                        <div class="days">JetEnterprise |</div>
                                        <div class="cost">1807 usuarios</div>
                                    </div>
                                    <button type="button" class="btn button">Participar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
           </div>      
      </div>
</asp:Content>

