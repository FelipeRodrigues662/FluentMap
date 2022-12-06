using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeCarrosFluentMap.Modelos
{
    public class Modelo
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }
}
