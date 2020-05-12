namespace apparcial2
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtIngresarDUI = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labNombreDePersona = new System.Windows.Forms.Label();
            this.labBeneficiario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abmin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngresarDUI
            // 
            this.txtIngresarDUI.AllowDrop = true;
            this.txtIngresarDUI.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIngresarDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresarDUI.Location = new System.Drawing.Point(104, 211);
            this.txtIngresarDUI.Name = "txtIngresarDUI";
            this.txtIngresarDUI.Size = new System.Drawing.Size(394, 20);
            this.txtIngresarDUI.TabIndex = 1;
            this.txtIngresarDUI.Text = "Ingresa tu numero de DUI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(218, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta quién de tu familia es el beneficiario del apoyo";
            // 
            // labNombreDePersona
            // 
            this.labNombreDePersona.AutoSize = true;
            this.labNombreDePersona.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreDePersona.Location = new System.Drawing.Point(57, 345);
            this.labNombreDePersona.Name = "labNombreDePersona";
            this.labNombreDePersona.Size = new System.Drawing.Size(60, 16);
            this.labNombreDePersona.TabIndex = 4;
            this.labNombreDePersona.Text = "Nombre";
            this.labNombreDePersona.UseWaitCursor = true;
            this.labNombreDePersona.Visible = false;
            // 
            // labBeneficiario
            // 
            this.labBeneficiario.AutoSize = true;
            this.labBeneficiario.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBeneficiario.Location = new System.Drawing.Point(368, 346);
            this.labBeneficiario.Name = "labBeneficiario";
            this.labBeneficiario.Size = new System.Drawing.Size(187, 15);
            this.labBeneficiario.TabIndex = 5;
            this.labBeneficiario.Text = "Eres beneficiario de los $300";
            this.labBeneficiario.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::apparcial2.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(257, 413);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(55, 13);
            this.labResultado.TabIndex = 7;
            this.labResultado.Text = "Resultado";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(607, 462);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labBeneficiario);
            this.Controls.Add(this.labNombreDePersona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIngresarDUI);
            this.Controls.Add(this.button1);
            this.Name = "frmConsulta";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIngresarDUI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNombreDePersona;
        private System.Windows.Forms.Label labBeneficiario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labResultado;
    }
}

