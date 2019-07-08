namespace ReplicadorScripts.WinForm
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtCabeceras = new System.Windows.Forms.TextBox();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContenido);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtContenido
            // 
            this.txtContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContenido.Location = new System.Drawing.Point(3, 16);
            this.txtContenido.MaxLength = 1000000;
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(442, 153);
            this.txtContenido.TabIndex = 2;
            // 
            // txtCabeceras
            // 
            this.txtCabeceras.Location = new System.Drawing.Point(13, 13);
            this.txtCabeceras.Multiline = true;
            this.txtCabeceras.Name = "txtCabeceras";
            this.txtCabeceras.Size = new System.Drawing.Size(236, 148);
            this.txtCabeceras.TabIndex = 1;
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(256, 13);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(174, 20);
            this.txtSeparador.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(256, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 339);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.txtCabeceras);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtCabeceras;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Button btnGenerar;
    }
}