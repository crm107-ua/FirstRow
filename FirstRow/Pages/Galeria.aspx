<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="FirstRow.Pages.Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="breadcrumbs white-color">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/">FirstRow</a>
                    <span class="separator">/</span>
                    <a href="/galeria">Galeria</a>
                </div>
            </div>
        </div>
    <div class="gallery-page">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="gallery-page-head">
                        <h1 class="title">Galería</h1>
                        <div class="select_wrap">
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
                    </div>
                    <div class="gallery-page-body">
                        <div class="gallery-list">
                            <a href="gallery-single.html" class="gallery-item">
                                <div class="top">
                                    <p class="country">Australia</p>
                                    <p class="title">Beautiful birds of Australia</p>
                                </div>
                                <div class="images">
                                    <div class="scroll">
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                    </div>
                                </div>
                            </a>

                            <a href="gallery-single.html" class="gallery-item">
                                <div class="top">
                                    <p class="country">Rome</p>
                                    <p class="title">Stunning architecture of Rome</p>
                                </div>
                                <div class="images">
                                    <div class="scroll">
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                    </div>
                                </div>
                            </a>

                            <a href="gallery-single.html" class="gallery-item">
                                <div class="top">
                                    <p class="country">Madagascar</p>
                                    <p class="title">Underwater world</p>
                                </div>
                                <div class="images">
                                    <div class="scroll">
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                    </div>
                                </div>
                            </a>

                            <a href="gallery-single.html" class="gallery-item">
                                <div class="top">
                                    <p class="country">Thailand</p>
                                    <p class="title">Azure beach</p>
                                </div>
                                <div class="images">
                                    <div class="scroll">
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                        <div class="img">
                                            <img src="img/demo-bg.jpg" alt="">
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="btn_wrap load_btn_wrap">
                            <a class="load_more button"><span>Load more</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

