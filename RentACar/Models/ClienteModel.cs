using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Numero Tarjeta")]
        public string NoTarjeta{ get; set; }
        [DisplayName("Limite Credito")]
        public decimal? LimiteCredito { get; set; }
        [DisplayName("Tipo de Persona")]
        public string TipoPersona { get; set; }
        public string Estado { get; set; }

    }
}
