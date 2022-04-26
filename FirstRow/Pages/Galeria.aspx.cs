using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Galeria : System.Web.UI.Page
    {

        //Genera todos los paisses
        //TODO si no es correcto cambiarlo por los de la base de datos
        public static List<string> GetCountry()
        {

            List<string> list = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures | CultureTypes.SpecificCultures);

            foreach (CultureInfo info in cultures)
            {
                try
                {
                    RegionInfo info2 = new RegionInfo(info.LCID);
                    if (!list.Contains(info2.EnglishName))
                    {

                        list.Add(info2.EnglishName);

                    }
                }
                catch (Exception e) 
                { 
                }

            }
            return list;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*List<string> paises=GetCountry();
            paises.Sort();
            Destino.DataSource = paises;
            Destino.DataBind();
            Destino.Items.Insert(0, "Destino");
            */
            //Hacer un bucle para cargar todas las galerias.
        }

        protected void VerMas_Click(object sender, EventArgs e)
        {
            //Cargar mas elementos de la galeria
        }

        /*
        protected void Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiado de filtrado
        }
        */
    }
}