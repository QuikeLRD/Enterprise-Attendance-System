namespace AsitenciaEmpresaProyectoFinal
{
    partial class Registro_Contadores
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
            this.AsistenConta = new System.Windows.Forms.Button();
            this.TicketCont = new System.Windows.Forms.Button();
            this.ErroresCont = new System.Windows.Forms.TextBox();
            this.fechaCont = new System.Windows.Forms.Label();
            this.HoraCont = new System.Windows.Forms.Label();
            this.FechaHoraCont = new System.Windows.Forms.Timer(this.components);
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
            this.label1.Location = new System.Drawing.Point(53, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(218, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 27);
            this.textBox1.TabIndex = 1;
            // 
            // AsistenConta
            // 
            this.AsistenConta.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AsistenConta.Location = new System.Drawing.Point(55, 208);
            this.AsistenConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsistenConta.Name = "AsistenConta";
            this.AsistenConta.Size = new System.Drawing.Size(167, 43);
            this.AsistenConta.TabIndex = 2;
            this.AsistenConta.Text = "Registrar asistencia";
            this.AsistenConta.UseVisualStyleBackColor = true;
            this.AsistenConta.Click += new System.EventHandler(this.AsistenConta_Click);
            // 
            // TicketCont
            // 
            this.TicketCont.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketCont.Location = new System.Drawing.Point(53, 441);
            this.TicketCont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicketCont.Name = "TicketCont";
            this.TicketCont.Size = new System.Drawing.Size(367, 41);
            this.TicketCont.TabIndex = 3;
            this.TicketCont.Text = "Generar ticket para acceder a la bodega de datos";
            this.TicketCont.UseVisualStyleBackColor = true;
            this.TicketCont.Click += new System.EventHandler(this.TicketCont_Click);
            // 
            // ErroresCont
            // 
            this.ErroresCont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErroresCont.Location = new System.Drawing.Point(491, 455);
            this.ErroresCont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErroresCont.Name = "ErroresCont";
            this.ErroresCont.Size = new System.Drawing.Size(265, 27);
            this.ErroresCont.TabIndex = 4;
            // 
            // fechaCont
            // 
            this.fechaCont.AutoSize = true;
            this.fechaCont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaCont.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaCont.Location = new System.Drawing.Point(444, 218);
            this.fechaCont.Name = "fechaCont";
            this.fechaCont.Size = new System.Drawing.Size(57, 23);
            this.fechaCont.TabIndex = 5;
            this.fechaCont.Text = "Fecha";
            // 
            // HoraCont
            // 
            this.HoraCont.AutoSize = true;
            this.HoraCont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HoraCont.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraCont.Location = new System.Drawing.Point(708, 218);
            this.HoraCont.Name = "HoraCont";
            this.HoraCont.Size = new System.Drawing.Size(48, 23);
            this.HoraCont.TabIndex = 6;
            this.HoraCont.Text = "Hora";
            // 
            // FechaHoraCont
            // 
            this.FechaHoraCont.Enabled = true;
            this.FechaHoraCont.Tick += new System.EventHandler(this.FechaHoraCont_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(416, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Esatdo";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(78, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Esatdo";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(461, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(461, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Su nuevo saldo es de: ";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Se le hará un descuento  por:  ";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Cascadia Code Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(563, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hora de entrada: 9:30: Am";
            // 
            // Registro_Contadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoraCont);
            this.Controls.Add(this.fechaCont);
            this.Controls.Add(this.ErroresCont);
            this.Controls.Add(this.TicketCont);
            this.Controls.Add(this.AsistenConta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro_Contadores";
            this.Text = "Registro Contadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AsistenConta;
        private Button TicketCont;
        private TextBox ErroresCont;
        private Label fechaCont;
        private Label HoraCont;
        private System.Windows.Forms.Timer FechaHoraCont;
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