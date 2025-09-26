namespace AsitenciaEmpresaProyectoFinal
{
    partial class Jardinero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jardinero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumTrabaJard = new System.Windows.Forms.Label();
            this.NumtrabaJardi = new System.Windows.Forms.TextBox();
            this.IngresarJardi = new System.Windows.Forms.Button();
            this.ErrorJardi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(387, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 129);
            this.panel1.TabIndex = 0;
            // 
            // NumTrabaJard
            // 
            this.NumTrabaJard.AutoSize = true;
            this.NumTrabaJard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumTrabaJard.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTrabaJard.Location = new System.Drawing.Point(208, 312);
            this.NumTrabaJard.Name = "NumTrabaJard";
            this.NumTrabaJard.Size = new System.Drawing.Size(269, 23);
            this.NumTrabaJard.TabIndex = 1;
            this.NumTrabaJard.Text = "Ingrese el numero de trabajador:";
            // 
            // NumtrabaJardi
            // 
            this.NumtrabaJardi.Location = new System.Drawing.Point(483, 308);
            this.NumtrabaJardi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumtrabaJardi.Name = "NumtrabaJardi";
            this.NumtrabaJardi.Size = new System.Drawing.Size(235, 27);
            this.NumtrabaJardi.TabIndex = 2;
            this.NumtrabaJardi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumtrabaJardi_KeyPress);
            // 
            // IngresarJardi
            // 
            this.IngresarJardi.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarJardi.Location = new System.Drawing.Point(405, 411);
            this.IngresarJardi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarJardi.Name = "IngresarJardi";
            this.IngresarJardi.Size = new System.Drawing.Size(86, 43);
            this.IngresarJardi.TabIndex = 3;
            this.IngresarJardi.Text = "Ingresar";
            this.IngresarJardi.UseVisualStyleBackColor = true;
            this.IngresarJardi.Click += new System.EventHandler(this.IngresarJardi_Click);
            // 
            // ErrorJardi
            // 
            this.ErrorJardi.Location = new System.Drawing.Point(304, 496);
            this.ErrorJardi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErrorJardi.Name = "ErrorJardi";
            this.ErrorJardi.Size = new System.Drawing.Size(283, 27);
            this.ErrorJardi.TabIndex = 4;
            this.ErrorJardi.Visible = false;
            // 
            // Jardinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.ErrorJardi);
            this.Controls.Add(this.IngresarJardi);
            this.Controls.Add(this.NumtrabaJardi);
            this.Controls.Add(this.NumTrabaJard);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Jardinero";
            this.Text = "Bienvenido jardinero";
            this.Load += new System.EventHandler(this.Jardinero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label NumTrabaJard;
        private TextBox NumtrabaJardi;
        private Button IngresarJardi;
        private TextBox ErrorJardi;
    }
}