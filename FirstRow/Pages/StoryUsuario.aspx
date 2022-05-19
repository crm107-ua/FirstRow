<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoryUsuario.aspx.cs" Inherits="FirstRow.Pages.StoryUsuario" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title>FirstRow - Making Dreams</title>
    <link rel="stylesheet" type="text/css" href="~/assets/css/style.css?v=1" >
    <link rel="icon" type="image/x-icon" href="~/assets/img/favicons/favicon.png">
    <meta name="msapplication-TileColor" content="#151515">
    <meta name="theme-color" content="#151515">
</head>  

<body>
    <form id="WhiteMaster" runat="server" enctype="multipart/form-data" method="post">
    <div class="container">
        <div class="top_panel">
            <div class="wrap">
                <div class="wrap_float">
                    <div class="left">
                        <a href="/" class="logo">
                            <img src="../../assets/img/Logo_Principal.png" alt="">
                        </a>
                    </div>
                    <div class="menu_wrap" id="menu_wrap">
                            <div class="scroll">
                                <div class="center">
                                    <div class="menu">                                     
                                           <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                                                <Items>
                                                    <asp:MenuItem Text="Home" NavigateUrl="/" />
                                                    <asp:MenuItem Text="Experiencias" NavigateUrl="/experiencias" />
                                                    <asp:MenuItem Text="Galería" NavigateUrl="/galeria" />
                                                    <asp:MenuItem Text="Stories" NavigateUrl="/stories" />
                                                    <asp:MenuItem Text="Blogs" NavigateUrl="/blogs" />
                                                    <asp:MenuItem Text="Sorteos" NavigateUrl="/sorteos" />
                                                    <asp:MenuItem Text="FirstRow" NavigateUrl="/firstrow" />
                                                </Items>
                                            </asp:Menu>                                     
                                        <div class="mobile_content"> </div>
                                    </div>
                                    <div class="close" id="menu-close">
                                        <span></span>
                                        <span></span>
                                        <span></span>
                                    </div>
                                </div>
                               
                                <div class="user" id="userblock">
                                    <div class="userlink" id="userlink"></div>
                                    <div class="usermenu" id="usermenu">
                                        <ul>
                                            <li id="login_sect" runat="server"><a id="login_user_pop_up" class="js-popup-open" data-href="#login">Iniciar sesion</a></li>
                                            <li id="register_sect" runat="server"><a id="register_user_pop_up" class="js-popup-open" data-href="#registration">Registrarse</a></li>
                                            <li id="settings_sect" runat="server"><a id="settings_user_pop_up" class="js-popup-open" data-href="#profile-setting">Ajustes</a></li>
                                            <li id="settings_emp_sect" runat="server"><a id="settings_emp_pop_up"  class="js-popup-open" data-href="#empresa-setting">Ajustes de empresa</a></li> 
                                            <li id="logout_sect" runat="server"><a class="js-popup-open" data-href="#logout">Cerrar sesion</a></li>
                                        </ul>
                                            <%-- Elementos ocultos --%>
                                            <a hidden id="login_emp_pop_up" class="js-popup-open" data-href="#login_empresa">Iniciar sesion</a>
                                            <a hidden id="register_emp_pop_up" class="js-popup-open" data-href="#registro_empresa">Iniciar sesion</a>
                                    </div>
                                </div>
                                
                            </div>
                        </div>
                </div>
            </div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" ScriptMode="Release">
        </asp:ScriptManager>
        <div class="stories_page" id="stories_page">
            <a href="/agregar-story" class="right_btn" runat="server" id="crear_story"
                style="margin-bottom: 60px; width: 150px " >Crear Story</a>
            <asp:Button ID="borrar_story" CssClass="right_btn" runat="server" Text="Borrar Story" OnClick="eliminarStory"
                style=" width: 150px " />
            <ajaxToolkit:ConfirmButtonExtender ID="confirm_delete" ConfirmText="¿Desea eliminar la story?" TargetControlID="borrar_story" runat="server"></ajaxToolkit:ConfirmButtonExtender>
            <div class="left_bottom_title" id="left_bottom_title" runat="server"
                 style="position: absolute;
                        z-index: 2;
                        font-family: 'Prata', serif;
                        font-size: 55px;
                        text-align: center;
                        color: #fff;
                        width: auto;
                        height: 50px;
                        padding: 0 14px;
                        margin-bottom: 12px;
                        bottom: 25px;
                        left: 60px;"
                ></div>
            <!-- Quiería crear una clase con estilo en el css, pero por alguna razón que no pude 
                resolver no se actualiza el css. Esto ya me pasó antes y lo solucioné
                poniendo en el link al css ?v=<DateTime.Now %>, que se supone que lo actualizaría
                siempre porque siempre es un número diferente, pero no funciona-->
            
            <!--<a href="stories-right-sidebar.html" class="right_btn">More stories</a>-->
            <div class="stories_bg" id="stories_bg"></div>
            <div class="stories_page_wrap">
                <div class="stories_box" id="stories_box">
                    <div class="arrows">
                        <div class="arrow prev disabled"></div>
                        <div class="arrow next"></div>
                    </div>
                    <div class="items stories_items" id="stories_items" runat="server">
                        
                        <a href="/stories" class="item" style="background-image: url(https://media-exp1.licdn.com/dms/image/C4D12AQHhj7R2c7hdrQ/article-cover_image-shrink_600_2000/0/1520167342937?e=1654128000&v=beta&t=cTkGEwA7jCsqkWK4C4TcSY5S4RNYGaZn1tru_nrckHE)" data-blur-bg="../../assets/img/demo-bg-4.jpg">
                            <!--
                            <div class="_info">
                                <div class="country"><span></span></div>
                            </div>
                            -->
                            <div>
                                <div class="tag">Última Story</div>
                            </div>
                            <h3 class="_title">
                                No hay más Stories
                            </h3>
                            <p class="_text">
                                Has llegado a la última Story, pulsa en esta tarjeta para ver más
                            </p>
                        </a>
                        
                        <!--
                        <asp:Panel runat="server" class="item" id="default_story_panel" >
                            <div class="_info">
                                <div class="country"><span runat="server" id="country_span">Pais de ejemplo</span></div>
                            </div>
                            <h3 class="_title">
                                The amazing world of the animals of Madagascar
                            </h3>
                            <p class="_text">
                                Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem
                            </p>
                        </asp:Panel> -->
                    </div>
                    <div class="dots">
                        <ul></ul>
                    </div>
                    <div class="story_info">
                        <!--
                        <div class="author">
                            <div class="userpic">
                                <img src="../../assets/img/demo-bg.jpg" alt="">
                            </div>
                            <p class="name">21.09.2019 by Maya Delia</p>
                        </div> -->
                        <asp:UpdatePanel ID="UpnlHidden" runat="server">
                            <ContentTemplate>
                                <div class="counter" id="stories-counter">
                                    <span class="this" id="story_id_span" runat="server">1</span> / <span class="all"></span>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="orientation-message">
                To see stories you must rotate your device to portrait orientation
            </div>
        </div>

    </div>
         <div runat="server" class="popup login" id="login">
                <div class="scroll">
                    <div class="scroll_wrap">
                        <div class="popup-head">
                            <div class="title">Iniciar Sesión</div><br /><br />
                        </div>
                        <div class="popup-body">
                            <div class="subtitle">
                                Introduce tu nickname y contraseña para acceder a miles de experiencias.<br />
                                <a class="link js-popup-open" data-href="#registration">Regístrate o </a>
                                <a class="link js-popup-open" data-href="#login_empresa">inicia sesión como empresa</a>
                            </div>
                            <div class="form">
                                <asp:TextBox id="nickname" type="text" runat="server" class="input" placeholder="Nombre de usuario"></asp:TextBox>
                                <asp:TextBox id="password" type="password" runat="server" class="input" placeholder="Password"></asp:TextBox>
                                <asp:Label id="salida" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                <asp:Button id="inicio" type="button" validationgroup="GrupoDeInicioSesion" class="submit button" onClick="iniciarSesion" runat="server" Text="Iniciar Sesión" />
                                <asp:RequiredFieldValidator ID="NicknameReq" validationgroup="GrupoDeInicioSesion" ForeColor="Red" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server" ControlToValidate="nickname" ErrorMessage="Nickname requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="PasswordReq" validationgroup="GrupoDeInicioSesion" ForeColor="Red" style="float: left; margin-bottom: 30px; margin-right: 50px; margin-top: 5px;" runat="server" ControlToValidate="password" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="NicknameReg" validationgroup="GrupoDeInicioSesion" ForeColor="Red" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server" Display="Dynamic" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="nickname" 
                                    ErrorMessage="El nombre de usuario debe tener entre 4 y 20 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" validationgroup="GrupoDeInicioSesion" ForeColor="Red" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server" Display="Dynamic" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="password" 
                                    ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                            </div>                           
                        </div>
                        <div class="popup-foot">
                            <p>Login via social networks</p>
                            <div class="social-links">
                                <a href="#" class="link facebook"><span></span></a>
                                <a href="#" class="link twitter"><span></span></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="close"></div>
            </div>
         <div runat="server" class="popup login" id="login_empresa">
                <div class="scroll">
                    <div class="scroll_wrap">
                        <div class="popup-head">
                            <div class="title">Inicio de sesión para empresas</div>
                        </div>
                        <div class="popup-body">
                            <div class="subtitle">
                                Introduzca el email y contraseña para empezar a administrar sus establecimientos.<br /><br />
                                <a class="link js-popup-open" data-href="#registro-empresa">Registrarse como empresa</a>
                            </div>
                            <div class="form">
                                <asp:TextBox id="login_email_empresa" validationgroup="GrupoDeInicioSesionEmpresa" type="text" runat="server" class="input" placeholder="Email"></asp:TextBox>
                                <asp:TextBox id="login_password_empresa" validationgroup="GrupoDeInicioSesionEmpresa" type="password" runat="server" class="input" placeholder="Password"></asp:TextBox>
                                <asp:Label id="salida_login_empresa" validationgroup="GrupoDeInicioSesionEmpresa" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                <asp:Button id="boton_login_empresa" validationgroup="GrupoDeInicioSesionEmpresa" class="submit button" onClick="iniciarSesionEmpresa" runat="server" Text="Iniciar Sesión" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogEmp1" validationgroup="GrupoDeInicioSesionEmpresa" ForeColor="Red" style="float:left; margin-bottom: 30px; margin-top: 30px;" runat="server" ControlToValidate="login_email_empresa" ErrorMessage="Email requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogEmp2" validationgroup="GrupoDeInicioSesionEmpresa" ForeColor="Red" style="float: left; margin-bottom: 30px; margin-right: 50px; margin-top: 5px;" runat="server" ControlToValidate="login_password_empresa" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorLogEmp3" validationgroup="GrupoDeInicioSesionEmpresa" runat="server"  ControlToValidate="login_email_empresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Direccion de email incorrecta"/>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorLogEmp4" validationgroup="GrupoDeInicioSesionEmpresa" ForeColor="Red" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server" Display="Dynamic" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="login_password_empresa" ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                            </div>                           
                        </div>
                        <div class="popup-foot">
                            <p>Login via social networks</p>
                            <div class="social-links">
                                <a href="#" class="link facebook"><span></span></a>
                                <a href="#" class="link twitter"><span></span></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="close"></div>
            </div>
         <div class="popup registration" id="registration">
                <div class="scroll">
                    <div class="scroll_wrap">
                        <div class="popup-head">
                            <div class="title">Registro</div>
                            <a class="link js-popup-open" data-href="#registro-empresa">Registro de Empresa</a>
                        </div>
                        <div class="popup-body">
                            <div class="subtitle">
                                Completa los siguientes campos para registrarte en FirstRow<br /><br />
                                <a class="link js-popup-open" data-href="#login">¿Ya eres usuario? Inicia de sesión</a>
                            </div>
                            <div class="form">
                                <asp:TextBox id="registro_nickname" type="text" runat="server" class="input" placeholder="Nickname"></asp:TextBox>
                                <asp:TextBox id="registro_email" type="text" runat="server" class="input" placeholder="Email"></asp:TextBox>
                                <asp:TextBox id="registro_nombre" MaxLength="100" type="text" runat="server" class="input" placeholder="Nombre"></asp:TextBox>
                                <asp:TextBox id="registro_apellido_1" MaxLength="100" type="text" runat="server" class="input" placeholder="Primer apellido"></asp:TextBox>
                                <asp:TextBox id="registro_apellido_2" MaxLength="100" type="text" runat="server" class="input" placeholder="Segundo apellido"></asp:TextBox>
                                <asp:TextBox id="password_r_1" type="password" runat="server" class="input" placeholder="Introduzca contraseña"></asp:TextBox>
                                <asp:TextBox id="password_r_2" type="password" runat="server" class="input" placeholder="Introduzca de nuevo la contraseña"></asp:TextBox>
                                <asp:TextBox id="registro_facebook" type="text" runat="server" class="input" MaxLength="100" placeholder="Facebook"></asp:TextBox>
                                <asp:TextBox id="registro_twitter" type="text" runat="server" class="input" MaxLength="100" placeholder="Twitter"></asp:TextBox>
                                <asp:FileUpload id="foto_perfil" type="file" runat="server" class="input" placeholder="Foto de perfil"></asp:FileUpload>

                                <asp:Label id="registro_salida" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                <asp:Button id="registro_button" class="submit button" onClick="registrarse" runat="server" Text="Registrarse" validationgroup="GrupoDeRegirstro"/>

                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" validationgroup="GrupoDeRegirstro" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="password_r_1" ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" validationgroup="GrupoDeRegirstro" ControlToCompare="password_r_1" ControlToValidate="password_r_2" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ForeColor="red" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" validationgroup="GrupoDeRegirstro" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="registro_nickname" ErrorMessage="El nombre de usuario debe tener entre 4 y 20 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" validationgroup="GrupoDeRegirstro" runat="server"  ControlToValidate="registro_email" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Direccion de email incorrecta"/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_nickname" ErrorMessage="Nickname requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_email" ErrorMessage="Email requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_nombre" ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" validationgroup="GrupoDeRegirstro" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_nombre" ErrorMessage="Formato de nombre incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_apellido_1" ErrorMessage="Primer apellido requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" validationgroup="GrupoDeRegirstro" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_apellido_1" ErrorMessage="Formato de primer apellido incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_apellido_2" ErrorMessage="Segundo apellido requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator10" validationgroup="GrupoDeRegirstro" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_apellido_2" ErrorMessage="Formato de segundo apellido incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="password_r_1" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" validationgroup="GrupoDeRegirstro" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="password_r_2" ErrorMessage="Repetición de contraseña requerida"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="popup-foot">
                            <p>Sign Up via social networks</p>
                            <div class="social-links">
                                <a href="#" class="link facebook"><span></span></a>
                                <a href="#" class="link twitter"><span></span></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="close"></div>
            </div>
         <div class="popup registration" id="registro-empresa">
                <div class="scroll">
                    <div class="scroll_wrap">
                        <div class="popup-head">
                            <div class="title">Registro de Empresa</div>
                        </div>
                        <div class="popup-body">
                            <a class="link js-popup-open" data-href="#registration">Registro de usuario</a><br /><br />
                            <div class="subtitle">
                                Completa los siguientes campos para registrarte en FirstRow como empresa asociada
                            </div>
                            <div class="form">
                                <asp:TextBox id="registro_emp_nickname" type="text" runat="server" class="input" placeholder="Nickname"></asp:TextBox>
                                <asp:TextBox id="registro_emp_email" type="text" runat="server" class="input" placeholder="Email"></asp:TextBox>
                                <asp:TextBox id="registro_emp_nombre" MaxLength="100" type="text" runat="server" class="input" placeholder="Nombre"></asp:TextBox>
                                <asp:TextBox id="registro_emp_apellido_1" MaxLength="100" type="text" runat="server" class="input" placeholder="Primer apellido"></asp:TextBox>
                                <asp:TextBox id="registro_emp_apellido_2" MaxLength="100" type="text" runat="server" class="input" placeholder="Segundo apellido"></asp:TextBox>
                                <asp:TextBox id="password_emp_r_1" type="password" runat="server" class="input" placeholder="Introduzca contraseña"></asp:TextBox>
                                <asp:TextBox id="password_emp_r_2" type="password" runat="server" class="input" placeholder="Introduzca de nuevo la contraseña"></asp:TextBox>
                                <asp:TextBox id="registro_emp_cif" type="text" runat="server" class="input" placeholder="CIF"></asp:TextBox>
                                <asp:TextBox id="registro_emp_direccion" type="text" runat="server" class="input" MaxLength="45" placeholder="Direccion"></asp:TextBox>
                                <asp:TextBox id="registro_emp_facebook" type="text" runat="server" class="input" MaxLength="100" placeholder="Facebook"></asp:TextBox>
                                <asp:TextBox id="registro_emp_twitter" type="text" runat="server" class="input" MaxLength="100" placeholder="Twitter"></asp:TextBox>

                                <div class="destination-col">
                                    <div class="label">Pais</div>
                                    <div class="select_wrap">
                                        <asp:DropDownList ID="listaPaisesRegEmpresa" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <asp:FileUpload id="foto_perfil_empresa" type="file" runat="server" class="input" placeholder="Foto de perfil"></asp:FileUpload>


                                <asp:Label id="registro_emp_salida" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                <asp:Button id="registro_emp_boton" class="submit button" onClick="registrarEmpresa" runat="server" Text="Registrar Empresa" validationgroup="GrupoDeRegistroEmpresa"/>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCIF" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_emp_cif" ErrorMessage="CIF requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorCIF" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="([a-z]|[A-Z]|[0-9])[0-9]{7}([a-z]|[A-Z]|[0-9])"  ControlToValidate="registro_emp_cif" ErrorMessage="Formato de CIF incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDireccion" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_emp_direccion" ErrorMessage="Direccion de sede requerida."></asp:RequiredFieldValidator>


                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidatorPass1" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="password_emp_r_1" ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                <asp:CompareValidator ID="empComparePasswords" runat="server" validationgroup="GrupoDeRegistroEmpresa" ControlToCompare="password_emp_r_1" ControlToValidate="password_emp_r_2" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ForeColor="red" />
                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidator1" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="registro_emp_nickname" ErrorMessage="El nombre de usuario debe tener entre 4 y 20 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidatorEmail" validationgroup="GrupoDeRegistroEmpresa" runat="server"  ControlToValidate="registro_emp_email" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Direccion de email incorrecta"/>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorNickname" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_emp_nickname" ErrorMessage="Nickname requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorEmail" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="registro_emp_email" ErrorMessage="Email requerido"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorName" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_emp_nombre" ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidatorName" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_emp_nombre" ErrorMessage="Formato de nombre incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorName1" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_emp_apellido_1" ErrorMessage="Primer apellido requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidator3" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_emp_apellido_1" ErrorMessage="Formato de primer apellido incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorName2" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="registro_emp_apellido_2" ErrorMessage="Segundo apellido requerido"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="EmpRegularExpressionValidator4" validationgroup="GrupoDeRegistroEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="registro_emp_apellido_2" ErrorMessage="Formato de segundo apellido incorrecto."> </asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorPass1" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="password_emp_r_1" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                <asp:RequiredFieldValidator ID="EmpRequiredFieldValidatorPass2" validationgroup="GrupoDeRegistroEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="password_emp_r_2" ErrorMessage="Repetición de contraseña requerida"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="popup-foot">
                            <p>Sign Up via social networks</p>
                            <div class="social-links">
                                <a href="#" class="link facebook"><span></span></a>
                                <a href="#" class="link twitter"><span></span></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="close"></div>
            </div>
         <div runat="server" class="popup login" id="logout">
                <div class="scroll">
                    <div class="scroll_wrap">
                        <div class="popup-head">
                            <div class="title">Cerrar Sesion</div>
                        </div>
                        <div class="popup-body">
                            <div class="subtitle">
                                Nos volveremos a ver pronto!
                            </div>
                            <div class="form">
                                    <asp:Button ID="cierre" class="submit button" runat="server" OnClick="cerrarSesion" Text="Cerrar Sesión" CausesValidation="False"/>
                            </div>                           
                        </div>
                    </div>
                </div>
                <div class="close"></div>
            </div>
         <div class="popup profile-setting" id="profile-setting">
                    <div class="scroll">
                        <div class="scroll_wrap">
                            <div class="select-userpic">
                                <div class="userpic">
                                     <asp:Image ID="user_setting_foto" runat="server" />
                                </div>
                            </div>
                            <div class="popup-head">
                                <div class="title">Ajustes de usuario</div>
                            </div>
                            <div class="popup-body">
                                <div class="form">
                                    <asp:TextBox id="email_setting" type="text" runat="server" class="input" placeholder="Email"></asp:TextBox>
                                    <asp:TextBox id="name_setting" MaxLength="100" type="text" runat="server" class="input" placeholder="Nombre"></asp:TextBox>
                                    <asp:TextBox id="firstname_setting" MaxLength="100" type="text" runat="server" class="input" placeholder="Primer apellido"></asp:TextBox>
                                    <asp:TextBox id="secondname_setting" MaxLength="100" type="text" runat="server" class="input" placeholder="Segundo apellido"></asp:TextBox>
                                    <asp:TextBox id="password_1_setting" type="password" runat="server" class="input" placeholder="Introduzca contraseña"></asp:TextBox>
                                    <asp:TextBox id="password_2_setting" type="password" runat="server" class="input" placeholder="Introduzca de nuevo la contraseña"></asp:TextBox>
                                    <asp:TextBox id="facebook_setting" type="text" runat="server" class="input" MaxLength="100" placeholder="Facebook"></asp:TextBox>
                                    <asp:TextBox id="twitter_setting" type="text" runat="server" class="input" MaxLength="100" placeholder="Twitter"></asp:TextBox>
                                    <asp:FileUpload id="user_setting_foto_mode" type="file" runat="server" class="input" placeholder="Foto de perfil"></asp:FileUpload>

                                    <asp:Label id="salida_ajustes_usuario" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                    <asp:Button id="ajustes_usuario_submit" class="submit button" onClick="modificarUsuario" runat="server" Text="Modificar Usuario" validationgroup="GrupoModificacionUsuario"/>

                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator15"  ControlToValidate="password_1_setting" validationgroup="GrupoModificacionUsuario" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$" ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="password_2_setting" ControlToCompare="password_1_setting" validationgroup="GrupoModificacionUsuario" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ForeColor="red" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator17" ControlToValidate="email_setting" validationgroup="GrupoModificacionUsuario" runat="server" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Direccion de email incorrecta"/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" ControlToValidate="email_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ErrorMessage="Email requerido"></asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" ControlToValidate="name_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator18" ControlToValidate="name_setting" validationgroup="GrupoModificacionUsuario" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$" ErrorMessage="Formato de nombre incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" ControlToValidate="firstname_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Primer apellido requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator19" ControlToValidate="firstname_setting" validationgroup="GrupoModificacionUsuario" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$" ErrorMessage="Formato de primer apellido incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" ControlToValidate="secondname_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Segundo apellido requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator20" ControlToValidate="secondname_setting" validationgroup="GrupoModificacionUsuario" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$" ErrorMessage="Formato de segundo apellido incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" ControlToValidate="password_1_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator23" ControlToValidate="password_2_setting" validationgroup="GrupoModificacionUsuario" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ErrorMessage="Repetición de contraseña requerida"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="close"></div>
                </div>
         <div class="popup profile-setting" id="empresa-setting">
                    <div class="scroll">
                        <div class="scroll_wrap">
                            <div class="select-userpic">
                                <div class="userpic">
                                     <asp:Image ID="ajustes_imagen_empresa" runat="server" />
                                </div>
                                <div class="select">
                                    <label for="profile-pic">Foto de perfil</label>
                                </div>
                            </div>
                            <div class="popup-head">
                                <div class="title">Ajustes de empresa</div>
                            </div>
                            <div class="popup-body">
                                <div class="form">
                                    <asp:TextBox id="ajustes_nombre_empresa" MaxLength="100" type="text" runat="server" class="input" placeholder="Nombre"></asp:TextBox>
                                    <asp:TextBox id="ajustes_apellido_1_empresa" MaxLength="100" type="text" runat="server" class="input" placeholder="Primer apellido"></asp:TextBox>
                                    <asp:TextBox id="ajustes_apellido_2_empresa" MaxLength="100" type="text" runat="server" class="input" placeholder="Segundo apellido"></asp:TextBox>
                                    <asp:TextBox id="ajustes_password_1_empresa" type="password" runat="server" class="input" placeholder="Introduzca contraseña"></asp:TextBox>
                                    <asp:TextBox id="ajustes_password_2_empresa" type="password" runat="server" class="input" placeholder="Introduzca de nuevo la contraseña"></asp:TextBox>
                                    <asp:TextBox id="ajustes_cif_empresa" type="text" runat="server" class="input" placeholder="CIF"></asp:TextBox>
                                    <asp:TextBox id="ajustes_direccion_empresa" type="text" runat="server" class="input" MaxLength="45" placeholder="Direccion"></asp:TextBox>
                                    <asp:TextBox id="ajustes_facebook_empresa" type="text" runat="server" class="input" MaxLength="100" placeholder="Facebook"></asp:TextBox>
                                    <asp:TextBox id="ajustes_twitter_empresa" type="text" runat="server" class="input" MaxLength="100" placeholder="Twitter"></asp:TextBox>
                                    <asp:FileUpload id="ajustes_imagen_empresa_mode" type="file" runat="server" class="input" placeholder="Foto de perfil"></asp:FileUpload>

                                    <div class="destination-col">
                                        <div class="label">Pais</div>
                                        <div class="select_wrap">
                                            <asp:DropDownList ID="listaPaises_ajustes_empresa" class="input" style="width:100%; height:50px; margin-bottom: 20px;" runat="server">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                    <asp:Label id="salida_ajustes_empresa" style="float:left; margin-bottom: 30px; margin-top: 30px" runat="server"></asp:Label>
                                    <asp:Button id="modificacion_ajustes_empresa" class="submit button" onClick="modificarEmpresa" runat="server" Text="Modificar empresa" validationgroup="GrupoDeAjustesEmpresa"/>

                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="ajustes_cif_empresa" ErrorMessage="CIF requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" validationgroup="GrupoDeAjustesEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="([a-z]|[A-Z]|[0-9])[0-9]{7}([a-z]|[A-Z]|[0-9])"  ControlToValidate="ajustes_cif_empresa" ErrorMessage="Formato de CIF incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px" runat="server" ControlToValidate="ajustes_direccion_empresa" ErrorMessage="Direccion de sede requerida."></asp:RequiredFieldValidator>


                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" validationgroup="GrupoDeAjustesEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"  ControlToValidate="ajustes_password_1_empresa" ErrorMessage="La contraseña debe tener entre 4 y 100 caracteres entre letras y numeros."> </asp:RegularExpressionValidator>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" validationgroup="GrupoDeAjustesEmpresa" ControlToCompare="ajustes_password_1_empresa" ControlToValidate="ajustes_password_2_empresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ForeColor="red" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="ajustes_nombre_empresa" ErrorMessage="Nombre requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator12" validationgroup="GrupoDeAjustesEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="ajustes_nombre_empresa" ErrorMessage="Formato de nombre incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="ajustes_apellido_1_empresa" ErrorMessage="Primer apellido requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator13" validationgroup="GrupoDeAjustesEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="ajustes_apellido_1_empresa" ErrorMessage="Formato de primer apellido incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="ajustes_apellido_2_empresa" ErrorMessage="Segundo apellido requerido"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator14" validationgroup="GrupoDeAjustesEmpresa" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 20px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^([A-z][A-Za-z]*\s+[A-Za-z]*)|([A-z][A-Za-z]*)$"  ControlToValidate="ajustes_apellido_2_empresa" ErrorMessage="Formato de segundo apellido incorrecto."> </asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="ajustes_password_1_empresa" ErrorMessage="Contraseña requerida"></asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" validationgroup="GrupoDeAjustesEmpresa" ForeColor="Red" style="float:left; margin-left: 10px; margin-bottom: 10px; margin-top: 10px" runat="server" ControlToValidate="ajustes_password_2_empresa" ErrorMessage="Repetición de contraseña requerida"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="close"></div>
                </div>
         <div class="popup book-now-popup" id="book-now">
            <div class="scroll">
            <div class="scroll_wrap">
                <div class="popup-head">
                    <div class="title">Reserva Ahora</div>
                </div>
                <div class="popup-body">
                    <div class="tour-title">
                        <div class="img">
                            <img src="../../assets/img/Logo_Principal.png" alt="">
                        </div>
                        <div class="tour-name">
                            Bienvenido a la zona de reservas. ¡No te arrepentiras!
                        </div>
                    </div>
                    <div class="tour-info">
                      
                            <div class="date_div">
                                
                                    Introduzca los siguientes datos, y por su seguridad le enviaremos un correo para su confirmacion.
                            </div>
                            

                    </div>
                    <div class="form">

                        <input type="text" class="input" placeholder="Fecha de inicio del viaje (aa/bb/cccc) ">
                        <input type="text" class="input" placeholder="Introduce tu nombre">
                        <input type="text" class="input" placeholder="Introduce tus apellidos">
                        <input type="email" class="input" placeholder="Introduce tu correro de contacto">
                        <input type="tel" class="input" placeholder="Teléfono de contacto">
                        <textarea class="textarea" placeholder="Direccion"></textarea>
                        <textarea class="textarea" placeholder= "¿Algún extra que debamos de saber?"></textarea>
                        <button class="submit button js-submit"> Reserva con un click | <b>$356</b></button>
                    </div>
                </div>
            </div>
        </div>
            <div class="close"></div>
    </div>
    </form>
</body>

    <script src="/assets/js/jquery.min.js"></script>
    <script src="/assets/js/jquery-ui.min.js"></script>
    <script src="/assets/js/lightgallery.js"></script>
    <script src="/assets/js/jquery.mousewheel.min.js"></script>
    <script src="/assets/js/slick.min.js"></script>
    <script src="/assets/js/hammer.js"></script>
    <script src="/assets/js/scripts.js"></script>


</html>