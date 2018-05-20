using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class RentaModel
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public string Vehiculo { get; set; }
        public string  Cliente { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public decimal? MontoDiario { get; set; }
        public int? Dias { get; set; }
        public string Comentario { get; set; }
        public decimal? MontoTotal { get; set; }
        public string Estado { get; set; }
    }
}
