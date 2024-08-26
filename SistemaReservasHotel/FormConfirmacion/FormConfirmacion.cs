using ReservasLibrary;

namespace formConfirmacion

{
    public partial class FormConfirmacion : Form
    {
        public event EventHandler ReservaConfirmada;
        public Reserva reserva;

        public FormConfirmacion(Reserva reserva)
        {
            InitializeComponent();
            this.reserva = reserva;

            //información de la reserva en los labels
            labelNombreCliente.Text = reserva.NombreCliente;
            labelTipoHabitacion.Text = reserva.TipoHabitacion;
            labelFechaEntrada.Text = reserva.FechaEntrada.ToShortDateString();
            labelFechaSalida.Text = reserva.FechaSalida.ToShortDateString();

            // botón Confirmar
            btnConfirmar.Click += new EventHandler(btnConfirmar_Click);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Disparar evento ReservaConfirmada
            ReservaConfirmada?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Reserva Confirmada");
            this.Close();
        }

        private void FormConfirmacion_Load(object sender, EventArgs e)
        {

        }
    }
}
