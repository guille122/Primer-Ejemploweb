using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Primer_ejemplo_web
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            
                dropList.Items.Add("1");
                dropList.Items.Add("2");
                dropList.Items.Add("3");
                dropList.Items.Add("4");
                dropList.Items.Add("Mas de 4");
            

            if (Request.QueryString["id"] != null)
            {
                if (!IsPostBack)
                {
                    
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    List<direcciones> temporal = (List<direcciones>)Session["listaDirecciones"];
                    direcciones seleccionado = temporal.Find(x => x.id == id);
                    txtDireccion.Text = seleccionado.calle;
                    txtAltura.Text = seleccionado.altura.ToString();
                    txtId.Text = seleccionado.id.ToString();
                    dropList.SelectedValue = seleccionado.habitantes.ToString();
                    chkVisitado.Checked = seleccionado.visitado;
                    txtId.ReadOnly = true;
                    btnAceptar.Enabled = false;
                }

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            direcciones d = new direcciones();
            int alturaTemporal;
            int idTemporal;
            if(string.IsNullOrWhiteSpace(txtId.Text)|| !int.TryParse(txtId.Text,out idTemporal))
            {
                lblError.Text = "Solo puede agregar numeros ...";
                lblError.Visible = true;
                return;
            }
            d.id = idTemporal;
            if(string.IsNullOrWhiteSpace(txtAltura.Text) || !int.TryParse(txtAltura.Text,out alturaTemporal))
            {
                lblErrorAltura.Text = "Solo puede agregar numeros...";
                lblErrorAltura.Visible = true;
                return;
            }
            d.altura = alturaTemporal;
            d.calle = txtDireccion.Text;
            d.habitantes = int.Parse(dropList.SelectedValue);
            d.visitado =chkVisitado.Checked;
            //Forma larga de referenciar en la lista de session
            //((List<direcciones>)Session["listaDirecciones"]).Add(d);

            //Forma corta
            List<direcciones> temporal = (List < direcciones > )Session["listaDirecciones"];
            temporal.Add(d);

            Response.Redirect("Defaul.aspx");

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(Request.QueryString["id"].ToString());
            List<direcciones> temporal = (List<direcciones>)Session["listaDirecciones"];
            direcciones agregar = temporal.Find(x => x.id == id);
            int alturaTemporal;
            if (string.IsNullOrWhiteSpace(txtAltura.Text) || !int.TryParse(txtAltura.Text, out alturaTemporal))
            {
                lblErrorAltura.Text = "Solo puede agregar numeros...";
                lblErrorAltura.Visible = true;
                return;
            }
            agregar.altura = alturaTemporal;
            agregar.calle = txtDireccion.Text;
            agregar.habitantes = int.Parse(dropList.SelectedValue);
            agregar.visitado = chkVisitado.Checked;
            
            
            
            Response.Redirect("Defaul.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            List<direcciones> temporal = (List<direcciones>)Session["listaDirecciones"];
            direcciones eliminar =temporal.Find(x => x.id == id);
            temporal.Remove(eliminar);
            Response.Redirect("Defaul.aspx");
        }
    }
}