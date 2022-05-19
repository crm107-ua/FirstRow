using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            ENEmpresa empresa = new ENEmpresa();
            usuario.nickname = RouteData.Values["nickname"].ToString();
            empresa.nickname = RouteData.Values["nickname"].ToString();

            if (usuario.readUsuario())
            {
                user_text.InnerText = "@" + usuario.nickname;

                if (empresa.readEmpresa())
                {
                    tipo_text.InnerText = "Perfil de Empresa";
                    user_text.InnerText += " te saluda desde " + empresa.pais.name;
                    mode_text.InnerText = "Estas son sus experiencias disponibles";
                    mostrarExperiencias(false, empresa.nickname);
                }
                else
                {
                    tipo_text.InnerText = "Perfil de Usuario";
                    mode_text.InnerText = "Experiencias vividas";
                    mostrarExperiencias(true, usuario.nickname);
                }
            }
            else
            {
                noExiste();
            }
        }

        private void noExiste()
        {
            tipo_text.InnerText = "";
            user_text.InnerText = "";
            mode_text.InnerText = "El usuario no existe en FirstRow";
        }

        private void mostrarExperiencias(bool mode, string nickname)
        {
            ENViajes ENexperiencia = new ENViajes();
            List<ENViajes> experiencias = new List<ENViajes>();

            if (mode)
            {
                ENexperiencia.mostrarExperienciasUsuario(experiencias,nickname);
                if(experiencias.Count == 0)
                {
                    mode_text.InnerText = "Esta usuario no ha vivido experiencias todavía";
                }
            }
            else
            {
                ENexperiencia.mostrarExperienciasEmpresa(experiencias, nickname);
                if (experiencias.Count == 0)
                {
                    mode_text.InnerText = "Esta empresa no tiene experiencias todavía";
                }
            }


            foreach (ENViajes experiencia in experiencias)
            {

                HyperLink a_tag_general = new HyperLink();
                a_tag_general.CssClass = "tour_item";
                a_tag_general.NavigateUrl = "/experiencia/" + experiencia.Slug;
                a_tag_general.Attributes.Add("style", "background-image: url(/Media/Experiencias/" + experiencia.Background + ")");

                HtmlGenericControl tour_item_top = new HtmlGenericControl("div");
                tour_item_top.Attributes.Add("class", "tour_item_top");

                HtmlGenericControl country = new HtmlGenericControl("p");
                country.Attributes.Add("class", "country");

                HtmlGenericControl texto_pais = new HtmlGenericControl("span");
                texto_pais.InnerText = experiencia.Pais.name;

                HtmlGenericControl tour_item_bottom = new HtmlGenericControl("div");
                tour_item_bottom.Attributes.Add("class", "tour_item_bottom");

                HtmlGenericControl _title = new HtmlGenericControl("h3");
                _title.Attributes.Add("class", "_title");
                _title.InnerText = experiencia.Titulo;

                HtmlGenericControl _info = new HtmlGenericControl("div");
                _info.Attributes.Add("class", "_info");

                HtmlGenericControl _info_left = new HtmlGenericControl("div");
                _info_left.Attributes.Add("class", "_info_left");

                HtmlGenericControl days = new HtmlGenericControl("div");
                days.Attributes.Add("class", "days");
                days.InnerText = experiencia.Dias + "dias |";

                HtmlGenericControl cost = new HtmlGenericControl("div");
                cost.Attributes.Add("class", "cost");
                cost.InnerText = experiencia.Precio + "€";

                HtmlGenericControl _info_right = new HtmlGenericControl("div");
                _info_right.Attributes.Add("class", "_info_right");

                HtmlGenericControl rating_text = new HtmlGenericControl("p");
                rating_text.Attributes.Add("class", "rating-text");
                rating_text.InnerText = experiencia.Comentarios.Count.ToString() + " Comentarios";

                HtmlGenericControl shadow = new HtmlGenericControl("div");
                shadow.Attributes.Add("class", "shadow js-shadow");

                _info_left.Controls.Add(days);
                _info_left.Controls.Add(cost);
                _info.Controls.Add(_info_left);
                _info_right.Controls.Add(rating_text);
                _info.Controls.Add(_info_right);
                _info.Controls.Add(_info_right);

                tour_item_bottom.Controls.Add(_title);
                tour_item_bottom.Controls.Add(_info);

                country.Controls.Add(texto_pais);
                tour_item_top.Controls.Add(country);

                a_tag_general.Controls.Add(tour_item_top);
                a_tag_general.Controls.Add(tour_item_bottom);

                mostrar_experiencias.Controls.Add(a_tag_general);
            }
        }
    }
}