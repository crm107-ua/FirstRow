<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="Stories.aspx.cs" Inherits="FirstRow.Pages.Stories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <div class="image_header" runat="server" id="background_image_header"></div>
        <div class="breadcrumbs">
            <div class="wrap">
                <div class="wrap_float">
                    <a href="/" style="color:white;">FirstRow</a>
                    <span class="separator" style="color:white;">/</span>
                    <a href="/stories" style="color:white;">Stories</a>
                </div>
            </div>
        </div>
        <div class="page stories-list-page full-width">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="page_head">
                        <h1 class="title" runat="server" style="color:white;" id="stories_title"></h1>
                        <p class="subtitle" runat="server" style="color:white;" id="stories_subtitle"></p>
                        <asp:DropDownList CssClass="select_wrap" runat="server" ID="country_list" AppendDataBoundItems="true">
                            <asp:ListItem class="subtitle" Text="-- Destination --" Value="-1" />
                        </asp:DropDownList>
                        
                        <!--
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
                        </div> -->
                    </div>
                    <div class="page_body">
                        <div class="stories_list">
                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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

                            <a href="story/ejemplo" class="story_item" style="background-image: url(https://wallpaper.dog/large/5498384.png)">
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
                        </div>
                        <div class="btn_wrap load_btn_wrap">
                            <a class="load_more button"><span>Load more</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="description-block">
            <div class="wrap">
                <div class="wrap_float">
                    <asp:Label runat="server" class="title" id="stories_description_title" />
                    <br />
                    <asp:Label runat="server" class="text" id="stories_description" />
                </div>
            </div>
        </div>
        <asp:Button CssClass="button" runat="server" ID="modify_page" Text="Modificar página" />
</asp:Content>
