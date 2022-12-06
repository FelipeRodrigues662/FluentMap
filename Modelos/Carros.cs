using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace VendaDeCarrosFluentMap.Modelos
{
  
    public class Carros
    {
       
        public int Id { get; private set; }

        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }

        public double Valor { get; set; }

        public int EstadoDeVendaId { get; set; }
        public EstadoDeVenda EstadoDeVenda { get; set; }
    }
}
