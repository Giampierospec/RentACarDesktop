using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class InspeccionModel
    {
        public int Id { get; set; }
        public string Vehiculo { get; set; }
        public string Cliente { get; set; }

        [DisplayName("Tiene Ralladuras")]

        public bool? Ralladuras { get; set; }
        [DisplayName("Cantidad Combustible")]
        public decimal? CantidadCombustible { get; set; }
        [DisplayName("Tiene Goma Respuesta")]
        public bool? GomaRespuesta { get; set; }
        [DisplayName("Tiene Gato")]
        public bool? Gato { get; set; }
        [DisplayName("Tiene Roturas")]
        public bool? RoturasCristal { get; set; }
        [DisplayName("Estado Gomas")]
        public string EstadoGomas { get; set; }
        public DateTime? Fecha { get; set; }
        public string Empleado { get; set; }
        public string Estado { get; set; }
    }
}
