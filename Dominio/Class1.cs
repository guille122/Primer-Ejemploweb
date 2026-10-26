using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class direcciones
    {
        public int id { get;set;  }
        public string calle { get; set; }

        public int altura { get; set; }

        public bool visitado { get; set; }

        public int habitantes { get; set; }
    }
}
