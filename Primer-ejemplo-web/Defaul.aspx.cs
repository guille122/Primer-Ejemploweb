using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Primer_ejemplo_web
{
    public partial class Defaul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                
             
                if ( Session["listaDirecciones"] == null)
                {
                    NegocioDirecciones negocio = new NegocioDirecciones();
                    Session.Add("listaDirecciones", negocio.listar());
                }
            
                // instanciamos la lista , se la pasamos al datagrivview y lo ejecutamos con el metodo databin(),para mostrarlo
                dgvDirecciones.DataSource = Session["listaDirecciones"];
                dgvDirecciones.DataBind();
            
            
        }

        protected void dgvDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvDirecciones.SelectedDataKey.Value.ToString();

            Response.Redirect("Formulario.aspx?id=" + id);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx");
        }
    }
}