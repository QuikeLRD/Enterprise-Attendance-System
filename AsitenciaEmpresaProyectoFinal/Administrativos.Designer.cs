namespace AsitenciaEmpresaProyectoFinal
{
    partial class Administrativos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTrabajadorAdmin = new System.Windows.Forms.TextBox();
            this.IngresarAdmin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(339, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero de trabajador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NumTrabajadorAdmin
            // 
            this.NumTrabajadorAdmin.Location = new System.Drawing.Point(403, 395);
            this.NumTrabajadorAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumTrabajadorAdmin.Name = "NumTrabajadorAdmin";
            this.NumTrabajadorAdmin.Size = new System.Drawing.Size(179, 27);
            this.NumTrabajadorAdmin.TabIndex = 2;
            this.NumTrabajadorAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumTrabajadorAdmin_KeyPress);
            // 
            // IngresarAdmin
            // 
            this.IngresarAdmin.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarAdmin.Location = new System.Drawing.Point(339, 513);
            this.IngresarAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarAdmin.Name = "IngresarAdmin";
            this.IngresarAdmin.Size = new System.Drawing.Size(99, 41);
            this.IngresarAdmin.TabIndex = 3;
            this.IngresarAdmin.Text = "Ingresar";
            this.IngresarAdmin.UseVisualStyleBackColor = true;
            this.IngresarAdmin.Click += new System.EventHandler(this.IngresarAdmin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 593);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // Administrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 732);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.IngresarAdmin);
            this.Controls.Add(this.NumTrabajadorAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrativos";
            this.Text = "Bienvenido administrador";
            this.Load += new System.EventHandler(this.Administrativos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox NumTrabajadorAdmin;
        private Button IngresarAdmin;
        private TextBox textBox2;
    }
}