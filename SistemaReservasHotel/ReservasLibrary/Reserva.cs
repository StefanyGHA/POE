using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasLibrary
{
    public class Reserva
    {
        public string NombreCliente { get; set; }
        public string TipoHabitacion { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
