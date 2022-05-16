using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Experiencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENViajes ENexperiencia = new ENViajes();
            List<ENViajes> experiencias = new List<ENViajes>();
            ENexperiencia.mostrarExperiencias(experiencias);

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



                if (Session["empresa"] != null)
                {
                    crear_experiencia.Visible = true;
                    crear_experiencia.InnerHtml = "Agrega una experiencia";
                }
                else
                {
                    crear_experiencia.Visible = false;
                }

            }
        }
    }
}