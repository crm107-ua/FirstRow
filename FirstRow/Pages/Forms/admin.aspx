<%@ Page Title="" Language="C#" MasterPageFile="~/White.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="FirstRow.Pages.Forms.Formadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="tour_page_head" style="background-image: url(https://www.xtrafondos.com/descargar.php?id=4621&resolucion=2560x1440)">
      <div class="write_comment" style="margin-top: 15%; margin-bottom: 5%; margin-left: 5%; width: 90%;">
            <div class="top">
                <h3 class="title">Agrega una admin</h3>
            </div>
            <div class="center">
                <asp:TextBox ID="create_admin_title" runat="server" type="text" style=" width:100%" class="input" placeholder="Titulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="titulo_admin_requerido" ControlToValidate="create_admin_title" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" ErrorMessage="*Titulo requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="titulo_admin_formato" ControlToValidate="create_admin_title" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 5px; margin-bottom: 10px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ ]+$" ErrorMessage="*Formato de titulo incorrecto"> </asp:RegularExpressionValidator>

                <asp:TextBox ID="create_admin_descripcion" runat="server" type="text" textMode="MultiLine" style="resize:vertical;" Width="100%" Height="180px" class="textarea" placeholder="Descripcion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="descripcion_admin_requerido" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" ErrorMessage="*Descripcion requerida"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="descripcion_admin_formato" ControlToValidate="create_admin_descripcion" validationgroup="GrupoCrearadmin" style="float:left; margin-left: 10px; margin-top: 10px; margin-bottom: 5px;" runat="server" Display="Dynamic" ForeColor="Red" ValidationExpression="^[-.:,0-9A-Za-zÀ-ÿ\s]+$" ErrorMessage="*Formato de descripcion incorrecto"> </asp:RegularExpressionValidator>

                </div> 
            </div>
            <div class="bottom">
                <asp:Button ID="btnCrea" class="submit button" runat="server" Text="Modificar" OnClick="btnCrea_Click" ValidationGroup="GrupoCrearadmin"/>
                <asp:Label ID="Error" runat="server" Text="" ForeColor="Red" style="float:left; margin-left: 10px; margin-top: 10px;" Visible="false"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>