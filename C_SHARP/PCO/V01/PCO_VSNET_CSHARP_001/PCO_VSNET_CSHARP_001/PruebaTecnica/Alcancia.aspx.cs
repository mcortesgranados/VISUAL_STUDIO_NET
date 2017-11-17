using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCO_VSNET_CSHARP_001.PruebaTecnica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Alcancia alcancia = new Alcancia();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            alcancia = (Alcancia)Session["alcancia"];
            if (alcancia != null)
            {
                foreach(Denominacion denominacion in alcancia.l_denominaciones)
                {
                    ListItem listItem = new ListItem();
                    listItem.Text = denominacion.getNombreDenominacion();
                    listItem.Value = denominacion.getNombreDenominacion();
                    this.DropDownList1.Items.Add(listItem);

                }
            }

        }

        protected void Button_AGREGAR_DENOMINACION_Click(object sender, EventArgs e)
        {
            alcancia = (Alcancia)Session["alcancia"];
            if (alcancia == null)
            {
                alcancia = new Alcancia();
                Session["alcancia"] = alcancia;
            }

            String nombreDenominacion = this.TextBox_DENOMINACION.Text;
            Denominacion denominacion = new Denominacion(nombreDenominacion);
            alcancia = (Alcancia)Session["alcancia"];
            alcancia.agregarDenominacion(denominacion);
            Session["alcancia"] = alcancia;
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}