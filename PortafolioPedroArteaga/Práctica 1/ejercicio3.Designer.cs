namespace práctica_1_pa
{
    partial class ejercicio3
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
            this.btnCacular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInversionistas = new System.Windows.Forms.Label();
            this.lblPorcentajes = new System.Windows.Forms.Label();
            this.lblTotalInversión = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txtPorcentaje1 = new System.Windows.Forms.TextBox();
            this.txtPorcentaje2 = new System.Windows.Forms.TextBox();
            this.txtPorcentaje3 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCacular
            // 
            this.btnCacular.Location = new System.Drawing.Point(36, 212);
            this.btnCacular.Name = "btnCacular";
            this.btnCacular.Size = new System.Drawing.Size(75, 23);
            this.btnCacular.TabIndex = 0;
            this.btnCacular.Text = "Calcular";
            this.btnCacular.UseVisualStyleBackColor = true;
            this.btnCacular.Click += new System.EventHandler(this.btnCacular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(117, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(198, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblInversionistas
            // 
            this.lblInversionistas.AutoSize = true;
            this.lblInversionistas.Location = new System.Drawing.Point(40, 26);
            this.lblInversionistas.Name = "lblInversionistas";
            this.lblInversionistas.Size = new System.Drawing.Size(71, 13);
            this.lblInversionistas.TabIndex = 3;
            this.lblInversionistas.Text = "Inversionistas";
            // 
            // lblPorcentajes
            // 
            this.lblPorcentajes.AutoSize = true;
            this.lblPorcentajes.Location = new System.Drawing.Point(165, 26);
            this.lblPorcentajes.Name = "lblPorcentajes";
            this.lblPorcentajes.Size = new System.Drawing.Size(63, 13);
            this.lblPorcentajes.TabIndex = 4;
            this.lblPorcentajes.Text = "Porcentajes";
            // 
            // lblTotalInversión
            // 
            this.lblTotalInversión.AutoSize = true;
            this.lblTotalInversión.Location = new System.Drawing.Point(40, 154);
            this.lblTotalInversión.Name = "lblTotalInversión";
            this.lblTotalInversión.Size = new System.Drawing.Size(76, 13);
            this.lblTotalInversión.TabIndex = 5;
            this.lblTotalInversión.Text = "Total inversión";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(43, 54);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(43, 82);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 7;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(43, 109);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 8;
            // 
            // txtPorcentaje1
            // 
            this.txtPorcentaje1.Location = new System.Drawing.Point(168, 54);
            this.txtPorcentaje1.Name = "txtPorcentaje1";
            this.txtPorcentaje1.ReadOnly = true;
            this.txtPorcentaje1.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje1.TabIndex = 9;
            // 
            // txtPorcentaje2
            // 
            this.txtPorcentaje2.Location = new System.Drawing.Point(168, 82);
            this.txtPorcentaje2.Name = "txtPorcentaje2";
            this.txtPorcentaje2.ReadOnly = true;
            this.txtPorcentaje2.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje2.TabIndex = 10;
            // 
            // txtPorcentaje3
            // 
            this.txtPorcentaje3.Location = new System.Drawing.Point(168, 109);
            this.txtPorcentaje3.Name = "txtPorcentaje3";
            this.txtPorcentaje3.ReadOnly = true;
            this.txtPorcentaje3.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje3.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(43, 170);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(21, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "1:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(21, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 13);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "2:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(21, 112);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(16, 13);
            this.lbl3.TabIndex = 15;
            this.lbl3.Text = "3:";
            // 
            // ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPorcentaje3);
            this.Controls.Add(this.txtPorcentaje2);
            this.Controls.Add(this.txtPorcentaje1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblTotalInversión);
            this.Controls.Add(this.lblPorcentajes);
            this.Controls.Add(this.lblInversionistas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCacular);
            this.Name = "ejercicio3";
            this.Text = "ejercicio3";
            this.Load += new System.EventHandler(this.ejercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCacular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblInversionistas;
        private System.Windows.Forms.Label lblPorcentajes;
        private System.Windows.Forms.Label lblTotalInversión;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txtPorcentaje1;
        private System.Windows.Forms.TextBox txtPorcentaje2;
        private System.Windows.Forms.TextBox txtPorcentaje3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
    }
}