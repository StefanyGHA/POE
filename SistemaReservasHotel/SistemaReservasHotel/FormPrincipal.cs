using ReservasLibrary;  
using System;
using System.Windows.Forms;

namespace SistemaReservasHotel
{
    public partial class FormPrincipal : Form
    {
        public event EventHandler ReservaCreada;

        public FormPrincipal()
        {
            InitializeComponent();

            // Asignar evento al botón Crear Reserva
            btnCrearReserva.Click += new EventHandler(btnCrearReserva_Click);
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            btnCrearReserva_Click(sender, e, ReservaCreada);
        }

        private void btnCrearReserva_Click(object sender, EventArgs e, EventHandler reservaCreada)
        {
            // Crear objeto de Reserva
            Reserva nuevaReserva = new Reserva
            {
                NombreCliente = txtNombre.Text,
                TipoHabitacion = comboBoxTipoHabitacion.SelectedItem.ToString(),
                FechaEntrada = dateTimePickerEntrada.Value,
                FechaSalida = dateTimePickerSalida.Value
            };
            reservaCreada?.Invoke(this, EventArgs.Empty);

            // Abrir Formulario de Confirmación
            var formConfirmacion = new formConfirmacion.FormConfirmacion(nuevaReserva);
            formConfirmacion.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
