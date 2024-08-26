namespace formConfirmacion
{
    partial class FormConfirmacion
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
            label1 = new Label();
            labelNombreCliente = new Label();
            labelTipoHabitacion = new Label();
            labelFechaEntrada = new Label();
            labelFechaSalida = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Información de la reserva";
            // 
            // labelNombreCliente
            // 
            labelNombreCliente.AutoSize = true;
            labelNombreCliente.Location = new Point(333, 96);
            labelNombreCliente.Name = "labelNombreCliente";
            labelNombreCliente.Size = new Size(0, 15);
            labelNombreCliente.TabIndex = 1;
            // 
            // labelTipoHabitacion
            // 
            labelTipoHabitacion.AutoSize = true;
            labelTipoHabitacion.Location = new Point(333, 151);
            labelTipoHabitacion.Name = "labelTipoHabitacion";
            labelTipoHabitacion.Size = new Size(0, 15);
            labelTipoHabitacion.TabIndex = 2;
            // 
            // labelFechaEntrada
            // 
            labelFechaEntrada.AutoSize = true;
            labelFechaEntrada.Location = new Point(333, 208);
            labelFechaEntrada.Name = "labelFechaEntrada";
            labelFechaEntrada.Size = new Size(0, 15);
            labelFechaEntrada.TabIndex = 3;
            // 
            // labelFechaSalida
            // 
            labelFechaSalida.AutoSize = true;
            labelFechaSalida.Location = new Point(333, 265);
            labelFechaSalida.Name = "labelFechaSalida";
            labelFechaSalida.Size = new Size(0, 15);
            labelFechaSalida.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(315, 330);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(labelFechaSalida);
            Controls.Add(labelFechaEntrada);
            Controls.Add(labelTipoHabitacion);
            Controls.Add(labelNombreCliente);
            Controls.Add(label1);
            Name = "FormConfirmacion";
            Text = "Form1";
            Load += FormConfirmacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNombreCliente;
        private Label labelTipoHabitacion;
        private Label labelFechaEntrada;
        private Label labelFechaSalida;
        private Button btnConfirmar;
    }
}
