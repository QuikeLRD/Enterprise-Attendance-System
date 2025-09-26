namespace AsitenciaEmpresaProyectoFinal
{
    partial class Registro_Limpieza
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
            this.RegAsisLimp = new System.Windows.Forms.Button();
            this.TicketLimp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fechaLimp = new System.Windows.Forms.Label();
            this.horaLimp = new System.Windows.Forms.Label();
            this.FechaHoraLimp = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 27);
            this.textBox1.TabIndex = 1;
            // 
            // RegAsisLimp
            // 
            this.RegAsisLimp.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegAsisLimp.Location = new System.Drawing.Point(44, 201);
            this.RegAsisLimp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegAsisLimp.Name = "RegAsisLimp";
            this.RegAsisLimp.Size = new System.Drawing.Size(173, 40);
            this.RegAsisLimp.TabIndex = 2;
            this.RegAsisLimp.Text = "Registrar asistencia";
            this.RegAsisLimp.UseVisualStyleBackColor = true;
            this.RegAsisLimp.Click += new System.EventHandler(this.RegAsisLimp_Click);
            // 
            // TicketLimp
            // 
            this.TicketLimp.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketLimp.Location = new System.Drawing.Point(370, 472);
            this.TicketLimp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicketLimp.Name = "TicketLimp";
            this.TicketLimp.Size = new System.Drawing.Size(321, 36);
            this.TicketLimp.TabIndex = 3;
            this.TicketLimp.Text = "Generar ticket ";
            this.TicketLimp.UseVisualStyleBackColor = true;
            this.TicketLimp.Click += new System.EventHandler(this.TicketLimp_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 481);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "¿Necesita algo?";
            // 
            // fechaLimp
            // 
            this.fechaLimp.AutoSize = true;
            this.fechaLimp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaLimp.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaLimp.Location = new System.Drawing.Point(398, 218);
            this.fechaLimp.Name = "fechaLimp";
            this.fechaLimp.Size = new System.Drawing.Size(57, 23);
            this.fechaLimp.TabIndex = 5;
            this.fechaLimp.Text = "Fecha";
            // 
            // horaLimp
            // 
            this.horaLimp.AutoSize = true;
            this.horaLimp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horaLimp.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaLimp.Location = new System.Drawing.Point(732, 218);
            this.horaLimp.Name = "horaLimp";
            this.horaLimp.Size = new System.Drawing.Size(48, 23);
            this.horaLimp.TabIndex = 6;
            this.horaLimp.Text = "Hora";
            // 
            // FechaHoraLimp
            // 
            this.FechaHoraLimp.Enabled = true;
            this.FechaHoraLimp.Tick += new System.EventHandler(this.FechaHoraLimp_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(404, 297);
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
            this.label7.Location = new System.Drawing.Point(66, 297);
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
            this.label6.Location = new System.Drawing.Point(449, 393);
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
            this.label5.Location = new System.Drawing.Point(449, 354);
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
            this.label4.Location = new System.Drawing.Point(66, 393);
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
            this.label3.Location = new System.Drawing.Point(66, 349);
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
            this.label2.Location = new System.Drawing.Point(572, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hora de entrada: 7:00 Am";
            // 
            // Registro_Limpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horaLimp);
            this.Controls.Add(this.fechaLimp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TicketLimp);
            this.Controls.Add(this.RegAsisLimp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro_Limpieza";
            this.Text = "Registro del personal de limpieza";
            this.Load += new System.EventHandler(this.Registro_Limpieza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button RegAsisLimp;
        private Button TicketLimp;
        private TextBox textBox2;
        private Label fechaLimp;
        private Label horaLimp;
        private System.Windows.Forms.Timer FechaHoraLimp;
        public TextBox textBox1;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}