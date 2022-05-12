using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Experiencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENViajes experiencia = new ENViajes();
            List<ENViajes> experiencias = new List<ENViajes>();
            experiencia.mostrarExperiencias(experiencias);
            Console.WriteLine(experiencias);
        }

    }
}