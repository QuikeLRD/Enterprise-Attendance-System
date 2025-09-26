namespace AsitenciaEmpresaProyectoFinal
{
    partial class Registro_Director_General
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
            this.AsistenBoss = new System.Windows.Forms.Button();
            this.TicketFreeParking = new System.Windows.Forms.Button();
            this.ErroresJefe = new System.Windows.Forms.TextBox();
            this.fechaJefe = new System.Windows.Forms.Label();
            this.horajefe = new System.Windows.Forms.Label();
            this.FechaHoraJefe = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(207, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 1;
            // 
            // AsistenBoss
            // 
            this.AsistenBoss.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AsistenBoss.Location = new System.Drawing.Point(73, 207);
            this.AsistenBoss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsistenBoss.Name = "AsistenBoss";
            this.AsistenBoss.Size = new System.Drawing.Size(238, 40);
            this.AsistenBoss.TabIndex = 2;
            this.AsistenBoss.Text = "Registrar asitencia";
            this.AsistenBoss.UseVisualStyleBackColor = true;
            this.AsistenBoss.Click += new System.EventHandler(this.AsistenBoss_Click);
            // 
            // TicketFreeParking
            // 
            this.TicketFreeParking.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketFreeParking.Location = new System.Drawing.Point(400, 435);
            this.TicketFreeParking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TicketFreeParking.Name = "TicketFreeParking";
            this.TicketFreeParking.Size = new System.Drawing.Size(290, 43);
            this.TicketFreeParking.TabIndex = 3;
            this.TicketFreeParking.Text = "Ticket para estacionamiento gratis";
            this.TicketFreeParking.UseVisualStyleBackColor = true;
            this.TicketFreeParking.Click += new System.EventHandler(this.TicketFreeParking_Click);
            // 
            // ErroresJefe
            // 
            this.ErroresJefe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErroresJefe.Location = new System.Drawing.Point(43, 444);
            this.ErroresJefe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErroresJefe.Name = "ErroresJefe";
            this.ErroresJefe.Size = new System.Drawing.Size(291, 27);
            this.ErroresJefe.TabIndex = 4;
            this.ErroresJefe.Text = "Desea generar un...";
            // 
            // fechaJefe
            // 
            this.fechaJefe.AutoSize = true;
            this.fechaJefe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaJefe.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaJefe.Location = new System.Drawing.Point(486, 212);
            this.fechaJefe.Name = "fechaJefe";
            this.fechaJefe.Size = new System.Drawing.Size(57, 23);
            this.fechaJefe.TabIndex = 5;
            this.fechaJefe.Text = "Fecha";
            // 
            // horajefe
            // 
            this.horajefe.AutoSize = true;
            this.horajefe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horajefe.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horajefe.Location = new System.Drawing.Point(764, 216);
            this.horajefe.Name = "horajefe";
            this.horajefe.Size = new System.Drawing.Size(48, 23);
            this.horajefe.TabIndex = 6;
            this.horajefe.Text = "Hora";
            // 
            // FechaHoraJefe
            // 
            this.FechaHoraJefe.Enabled = true;
            this.FechaHoraJefe.Tick += new System.EventHandler(this.FechaHoraJefe_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(430, 268);
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
            this.label7.Location = new System.Drawing.Point(92, 268);
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
            this.label6.Location = new System.Drawing.Point(475, 364);
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
            this.label5.Location = new System.Drawing.Point(475, 325);
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
            this.label4.Location = new System.Drawing.Point(92, 364);
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
            this.label3.Location = new System.Drawing.Point(92, 320);
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
            this.label2.Location = new System.Drawing.Point(577, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hora de entrada: 10:00 Am";
  
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(764, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro_Director_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horajefe);
            this.Controls.Add(this.fechaJefe);
            this.Controls.Add(this.ErroresJefe);
            this.Controls.Add(this.TicketFreeParking);
            this.Controls.Add(this.AsistenBoss);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro_Director_General";
            this.Text = "Registro Director General";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AsistenBoss;
        private Button TicketFreeParking;
        private TextBox ErroresJefe;
        private Label fechaJefe;
        private Label horajefe;
        private System.Windows.Forms.Timer FechaHoraJefe;
        public TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}