namespace AsitenciaEmpresaProyectoFinal
{
    partial class Contadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contadores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTrabCont = new System.Windows.Forms.TextBox();
            this.IngresarCont = new System.Windows.Forms.Button();
            this.AdvertenciaCont = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(382, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero de trabajador:";
            // 
            // NumTrabCont
            // 
            this.NumTrabCont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumTrabCont.Location = new System.Drawing.Point(478, 296);
            this.NumTrabCont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumTrabCont.Name = "NumTrabCont";
            this.NumTrabCont.Size = new System.Drawing.Size(247, 27);
            this.NumTrabCont.TabIndex = 2;
            this.NumTrabCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumTrabCont_KeyPress);
            // 
            // IngresarCont
            // 
            this.IngresarCont.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarCont.Location = new System.Drawing.Point(397, 380);
            this.IngresarCont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarCont.Name = "IngresarCont";
            this.IngresarCont.Size = new System.Drawing.Size(102, 44);
            this.IngresarCont.TabIndex = 3;
            this.IngresarCont.Text = "Ingresar";
            this.IngresarCont.UseVisualStyleBackColor = true;
            this.IngresarCont.Click += new System.EventHandler(this.IngresarCont_Click);
            // 
            // AdvertenciaCont
            // 
            this.AdvertenciaCont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdvertenciaCont.Location = new System.Drawing.Point(313, 463);
            this.AdvertenciaCont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdvertenciaCont.Name = "AdvertenciaCont";
            this.AdvertenciaCont.Size = new System.Drawing.Size(259, 27);
            this.AdvertenciaCont.TabIndex = 4;
            this.AdvertenciaCont.Visible = false;
            // 
            // Contadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.AdvertenciaCont);
            this.Controls.Add(this.IngresarCont);
            this.Controls.Add(this.NumTrabCont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Contadores";
            this.Text = "Bienvenido contador";
            this.Load += new System.EventHandler(this.Contadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox NumTrabCont;
        private Button IngresarCont;
        private TextBox AdvertenciaCont;
    }
}