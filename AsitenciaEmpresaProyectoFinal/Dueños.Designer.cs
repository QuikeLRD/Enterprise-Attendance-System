namespace AsitenciaEmpresaProyectoFinal
{
    partial class Dueños
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dueños));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumJefe = new System.Windows.Forms.Label();
            this.NumTrabaJefe = new System.Windows.Forms.TextBox();
            this.IngresarJefe = new System.Windows.Forms.Button();
            this.ErrorJefe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(401, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 131);
            this.panel1.TabIndex = 0;
            // 
            // NumJefe
            // 
            this.NumJefe.AutoSize = true;
            this.NumJefe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumJefe.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumJefe.Location = new System.Drawing.Point(199, 329);
            this.NumJefe.Name = "NumJefe";
            this.NumJefe.Size = new System.Drawing.Size(269, 23);
            this.NumJefe.TabIndex = 1;
            this.NumJefe.Text = "Ingrese el numero de trabajador:";
            // 
            // NumTrabaJefe
            // 
            this.NumTrabaJefe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumTrabaJefe.Location = new System.Drawing.Point(489, 329);
            this.NumTrabaJefe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumTrabaJefe.Name = "NumTrabaJefe";
            this.NumTrabaJefe.Size = new System.Drawing.Size(241, 27);
            this.NumTrabaJefe.TabIndex = 2;
            this.NumTrabaJefe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumTrabaJefe_KeyPress);
            // 
            // IngresarJefe
            // 
            this.IngresarJefe.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarJefe.Location = new System.Drawing.Point(401, 416);
            this.IngresarJefe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarJefe.Name = "IngresarJefe";
            this.IngresarJefe.Size = new System.Drawing.Size(86, 40);
            this.IngresarJefe.TabIndex = 3;
            this.IngresarJefe.Text = "Ingresar";
            this.IngresarJefe.UseVisualStyleBackColor = true;
            this.IngresarJefe.Click += new System.EventHandler(this.IngresarJefe_Click);
            // 
            // ErrorJefe
            // 
            this.ErrorJefe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorJefe.Location = new System.Drawing.Point(299, 492);
            this.ErrorJefe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ErrorJefe.Name = "ErrorJefe";
            this.ErrorJefe.Size = new System.Drawing.Size(275, 27);
            this.ErrorJefe.TabIndex = 4;
            this.ErrorJefe.Visible = false;
            // 
            // Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.ErrorJefe);
            this.Controls.Add(this.IngresarJefe);
            this.Controls.Add(this.NumTrabaJefe);
            this.Controls.Add(this.NumJefe);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dueños";
            this.Text = "Bienvenido -Director General";
            this.Load += new System.EventHandler(this.Dueños_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label NumJefe;
        private TextBox NumTrabaJefe;
        private Button IngresarJefe;
        private TextBox ErrorJefe;
    }
}