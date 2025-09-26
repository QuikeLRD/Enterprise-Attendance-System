namespace AsitenciaEmpresaProyectoFinal
{
    partial class Limpieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Limpieza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumTrabajaLimpieza = new System.Windows.Forms.Label();
            this.NumLimpieza = new System.Windows.Forms.TextBox();
            this.IngresarLimpieza = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(393, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 127);
            this.panel1.TabIndex = 0;
            // 
            // NumTrabajaLimpieza
            // 
            this.NumTrabajaLimpieza.AutoSize = true;
            this.NumTrabajaLimpieza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumTrabajaLimpieza.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTrabajaLimpieza.Location = new System.Drawing.Point(206, 327);
            this.NumTrabajaLimpieza.Name = "NumTrabajaLimpieza";
            this.NumTrabajaLimpieza.Size = new System.Drawing.Size(269, 23);
            this.NumTrabajaLimpieza.TabIndex = 1;
            this.NumTrabajaLimpieza.Text = "Ingrese el numero de trabajador:";
            // 
            // NumLimpieza
            // 
            this.NumLimpieza.Location = new System.Drawing.Point(473, 327);
            this.NumLimpieza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumLimpieza.Name = "NumLimpieza";
            this.NumLimpieza.Size = new System.Drawing.Size(217, 27);
            this.NumLimpieza.TabIndex = 2;
            this.NumLimpieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumLimpieza_KeyPress);
            // 
            // IngresarLimpieza
            // 
            this.IngresarLimpieza.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarLimpieza.Location = new System.Drawing.Point(414, 397);
            this.IngresarLimpieza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarLimpieza.Name = "IngresarLimpieza";
            this.IngresarLimpieza.Size = new System.Drawing.Size(91, 45);
            this.IngresarLimpieza.TabIndex = 3;
            this.IngresarLimpieza.Text = "Ingresar";
            this.IngresarLimpieza.UseVisualStyleBackColor = true;
            this.IngresarLimpieza.Click += new System.EventHandler(this.IngresarLimpieza_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 503);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // Limpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.IngresarLimpieza);
            this.Controls.Add(this.NumLimpieza);
            this.Controls.Add(this.NumTrabajaLimpieza);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Limpieza";
            this.Text = "Bienvenido personal de limpieza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label NumTrabajaLimpieza;
        private TextBox NumLimpieza;
        private Button IngresarLimpieza;
        private TextBox textBox2;
    }
}