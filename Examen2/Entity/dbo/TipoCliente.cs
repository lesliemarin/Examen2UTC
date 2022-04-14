using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.dbo
{
    public class TipoClienteEntity: DBEntity
    {
        public int? IdTipoCliente { get; set; }
        public string NombreTipoCliente { get; set; }



    }
}
