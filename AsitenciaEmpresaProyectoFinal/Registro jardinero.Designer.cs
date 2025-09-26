namespace AsitenciaEmpresaProyectoFinal
{
    partial class Registro_jardinero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AsistenJardi = new System.Windows.Forms.Button();
            this.ticketJardi = new System.Windows.Forms.Button();
            this.ErrorJardin = new System.Windows.Forms.TextBox();
            this.fechaJardin = new System.Windows.Forms.Label();
            this.horajardin = new System.Windows.Forms.Label();
            this.FechaHoraJardin = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 27);
            this.textBox1.TabIndex = 1;
            // 
            // AsistenJardi
            // 
            this.AsistenJardi.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AsistenJardi.Location = new System.Drawing.Point(56, 193);
            this.AsistenJardi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsistenJardi.Name = "AsistenJardi";
            this.AsistenJardi.Size = new System.Drawing.Size(214, 41);
            this.AsistenJardi.TabIndex = 2;
            this.AsistenJardi.Text = "Registrar asistencia";
            this.AsistenJardi.UseVisualStyleBackColor = true;
            this.AsistenJardi.Click += new System.EventHandler(this.AsistenJardi_Click);
            // 
            // ticketJardi
            // 
            this.ticketJardi.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketJardi.Location = new System.Drawing.Point(389, 457);
            this.ticketJardi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticketJardi.Name = "ticketJardi";
            this.ticketJardi.Size = new System.Drawing.Size(349, 40);
            this.ticketJardi.TabIndex = 3;
            this.ticketJardi.Text = "Generar ticket ";
            this.ticketJardi.UseVisualStyleBackColor = true;
            this.ticketJardi.Click += new System.EventHandler(this.ticketJardi_Click);
            // 
            // ErrorJardin
            // 
            this.ErrorJardin.Location = new System.Drawing.Point(54, 470);
            this.ErrorJardin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErrorJardin.Name = "ErrorJardin";
            this.ErrorJardin.Size = new System.Drawing.Size(246, 27);
            this.ErrorJardin.TabIndex = 4;
            this.ErrorJardin.Text = "¿Necesitas algo?";
            // 
            // fechaJardin
            // 
            this.fechaJardin.AutoSize = true;
            this.fechaJardin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fechaJardin.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaJardin.Location = new System.Drawing.Point(490, 202);
            this.fechaJardin.Name = "fechaJardin";
            this.fechaJardin.Size = new System.Drawing.Size(57, 23);
            this.fechaJardin.TabIndex = 5;
            this.fechaJardin.Text = "Fecha";
            // 
            // horajardin
            // 
            this.horajardin.AutoSize = true;
            this.horajardin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.horajardin.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horajardin.Location = new System.Drawing.Point(764, 204);
            this.horajardin.Name = "horajardin";
            this.horajardin.Size = new System.Drawing.Size(48, 23);
            this.horajardin.TabIndex = 6;
            this.horajardin.Text = "Hora";
            // 
            // FechaHoraJardin
            // 
            this.FechaHoraJardin.Enabled = true;
            this.FechaHoraJardin.Tick += new System.EventHandler(this.FechaHoraJardin_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(419, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Esatdo";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(81, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Esatdo";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(464, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(464, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Su nuevo saldo es de: ";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Se le hará un descuento  por:  ";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(552, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hora de entrada: 7:00 Am";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(779, 468);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(94, 29);
            this.Salir.TabIndex = 29;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Registro_jardinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horajardin);
            this.Controls.Add(this.fechaJardin);
            this.Controls.Add(this.ErrorJardin);
            this.Controls.Add(this.ticketJardi);
            this.Controls.Add(this.AsistenJardi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro_jardinero";
            this.Text = "Registro de jardineros";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AsistenJardi;
        private Button ticketJardi;
        private TextBox ErrorJardin;
        private Label fechaJardin;
        private Label horajardin;
        private System.Windows.Forms.Timer FechaHoraJardin;
        public TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Salir;
    }
}