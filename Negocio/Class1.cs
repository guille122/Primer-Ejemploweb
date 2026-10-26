using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioDirecciones
    {

        public List<direcciones> listar()
        {
            List<direcciones> lista = new List<direcciones>();
            lista.Add(new direcciones());
            lista.Add(new direcciones());
            lista[0].id = 1;
            lista[0].calle = "Eduardo costa";
            lista[0].altura = 815;
            lista[0].habitantes = 3;
            lista[0].visitado = true;

            lista[1].id = 2;
            lista[1].calle = "Charcas";
            lista[1].altura = 1883;
            lista[1].habitantes = 4;
            lista[1].visitado = false;

            return lista;
        }

        
    }
}
