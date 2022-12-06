using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeCarrosFluentMap.Modelos
{
    public class EstadoDeVenda
    {
        public int Id { get; private set; }
        public Boolean Vendido { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
