using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCO_VSNET_CSHARP_001
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> miListado = new List<string>();
            miListado.Add("Manolito1");
            miListado.Add("Manolito2");
            Session["var"] = miListado;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {




        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}