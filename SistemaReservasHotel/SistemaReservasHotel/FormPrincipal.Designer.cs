namespace SistemaReservasHotel
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreCliente = new Label();
            tipoHabitacion = new Label();
            fechaEntrada = new Label();
            fechaSalida = new Label();
            txtNombre = new TextBox();
            comboBoxTipoHabitacion = new ComboBox();
            dateTimePickerEntrada = new DateTimePicker();
            dateTimePickerSalida = new DateTimePicker();
            hotelRe = new Label();
            btnCrearReserva = new Button();
            SuspendLayout();
            // 
            // nombreCliente
            // 
            nombreCliente.AutoSize = true;
            nombreCliente.Location = new Point(231, 106);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(110, 15);
            nombreCliente.TabIndex = 0;
            nombreCliente.Text = "Nombre del Cliente";
            // 
            // tipoHabitacion
            // 
            tipoHabitacion.AutoSize = true;
            tipoHabitacion.Location = new Point(234, 174);
            tipoHabitacion.Name = "tipoHabitacion";
            tipoHabitacion.Size = new Size(107, 15);
            tipoHabitacion.TabIndex = 1;
            tipoHabitacion.Text = "Tipo de Habitación";
            // 
            // fechaEntrada
            // 
            fechaEntrada.AutoSize = true;
            fechaEntrada.Location = new Point(234, 230);
            fechaEntrada.Name = "fechaEntrada";
            fechaEntrada.Size = new Size(97, 15);
            fechaEntrada.TabIndex = 2;
            fechaEntrada.Text = "Fecha de Entrada";
            // 
            // fechaSalida
            // 
            fechaSalida.AutoSize = true;
            fechaSalida.Location = new Point(243, 295);
            fechaSalida.Name = "fechaSalida";
            fechaSalida.Size = new Size(88, 15);
            fechaSalida.TabIndex = 3;
            fechaSalida.Text = "Fecha de Salida";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(359, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // comboBoxTipoHabitacion
            // 
            comboBoxTipoHabitacion.FormattingEnabled = true;
            comboBoxTipoHabitacion.Items.AddRange(new object[] { "Individual", "Suite", "Doble" });
            comboBoxTipoHabitacion.Location = new Point(359, 166);
            comboBoxTipoHabitacion.Name = "comboBoxTipoHabitacion";
            comboBoxTipoHabitacion.Size = new Size(121, 23);
            comboBoxTipoHabitacion.TabIndex = 5;
            // 
            // dateTimePickerEntrada
            // 
            dateTimePickerEntrada.Location = new Point(359, 222);
            dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            dateTimePickerEntrada.Size = new Size(219, 23);
            dateTimePickerEntrada.TabIndex = 6;
            // 
            // dateTimePickerSalida
            // 
            dateTimePickerSalida.Location = new Point(359, 289);
            dateTimePickerSalida.Name = "dateTimePickerSalida";
            dateTimePickerSalida.Size = new Size(219, 23);
            dateTimePickerSalida.TabIndex = 7;
            // 
            // hotelRe
            // 
            hotelRe.AutoSize = true;
            hotelRe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hotelRe.Location = new Point(209, 33);
            hotelRe.Name = "hotelRe";
            hotelRe.Size = new Size(346, 20);
            hotelRe.TabIndex = 8;
            hotelRe.Text = "Sistema de reservas de habitaciones en un Hotel";
            // 
            // btnCrearReserva
            // 
            btnCrearReserva.Location = new Point(384, 350);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(75, 23);
            btnCrearReserva.TabIndex = 9;
            btnCrearReserva.Text = "Reservar";
            btnCrearReserva.UseVisualStyleBackColor = true;
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearReserva);
            Controls.Add(hotelRe);
            Controls.Add(dateTimePickerSalida);
            Controls.Add(dateTimePickerEntrada);
            Controls.Add(comboBoxTipoHabitacion);
            Controls.Add(txtNombre);
            Controls.Add(fechaSalida);
            Controls.Add(fechaEntrada);
            Controls.Add(tipoHabitacion);
            Controls.Add(nombreCliente);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreCliente;
        private Label tipoHabitacion;
        private Label fechaEntrada;
        private Label fechaSalida;
        private TextBox txtNombre;
        private ComboBox comboBoxTipoHabitacion;
        private DateTimePicker dateTimePickerEntrada;
        private DateTimePicker dateTimePickerSalida;
        private Label hotelRe;
        private Button btnCrearReserva;
    }
}
