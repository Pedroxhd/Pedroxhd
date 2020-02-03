namespace práctica_1_pa
{
	partial class ejercicio2
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
			this.lblDecimal = new System.Windows.Forms.Label();
			this.grpEquivaleA = new System.Windows.Forms.GroupBox();
			this.lblOctal = new System.Windows.Forms.Label();
			this.lblHexadecimal = new System.Windows.Forms.Label();
			this.txtDecimal = new System.Windows.Forms.TextBox();
			this.txtBinario = new System.Windows.Forms.TextBox();
			this.txtOctal = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtHexadecimal = new System.Windows.Forms.TextBox();
			this.lblBinario = new System.Windows.Forms.Label();
			this.grpEquivaleA.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDecimal
			// 
			this.lblDecimal.AutoSize = true;
			this.lblDecimal.Location = new System.Drawing.Point(36, 44);
			this.lblDecimal.Name = "lblDecimal";
			this.lblDecimal.Size = new System.Drawing.Size(48, 13);
			this.lblDecimal.TabIndex = 0;
			this.lblDecimal.Text = "Decimal:";
			this.lblDecimal.Click += new System.EventHandler(this.label1_Click);
			// 
			// grpEquivaleA
			// 
			this.grpEquivaleA.Controls.Add(this.txtHexadecimal);
			this.grpEquivaleA.Controls.Add(this.txtOctal);
			this.grpEquivaleA.Controls.Add(this.txtBinario);
			this.grpEquivaleA.Controls.Add(this.lblHexadecimal);
			this.grpEquivaleA.Controls.Add(this.lblOctal);
			this.grpEquivaleA.Controls.Add(this.lblBinario);
			this.grpEquivaleA.Location = new System.Drawing.Point(39, 84);
			this.grpEquivaleA.Name = "grpEquivaleA";
			this.grpEquivaleA.Size = new System.Drawing.Size(236, 129);
			this.grpEquivaleA.TabIndex = 1;
			this.grpEquivaleA.TabStop = false;
			this.grpEquivaleA.Text = "Equivale a:";
			// 
			// lblOctal
			// 
			this.lblOctal.AutoSize = true;
			this.lblOctal.Location = new System.Drawing.Point(20, 64);
			this.lblOctal.Name = "lblOctal";
			this.lblOctal.Size = new System.Drawing.Size(35, 13);
			this.lblOctal.TabIndex = 1;
			this.lblOctal.Text = "Octal:";
			this.lblOctal.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblHexadecimal
			// 
			this.lblHexadecimal.AutoSize = true;
			this.lblHexadecimal.Location = new System.Drawing.Point(20, 94);
			this.lblHexadecimal.Name = "lblHexadecimal";
			this.lblHexadecimal.Size = new System.Drawing.Size(71, 13);
			this.lblHexadecimal.TabIndex = 2;
			this.lblHexadecimal.Text = "Hexadecimal:";
			this.lblHexadecimal.Click += new System.EventHandler(this.lblHexadecimal_Click);
			// 
			// txtDecimal
			// 
			this.txtDecimal.Location = new System.Drawing.Point(94, 41);
			this.txtDecimal.Name = "txtDecimal";
			this.txtDecimal.Size = new System.Drawing.Size(100, 20);
			this.txtDecimal.TabIndex = 3;
			// 
			// txtBinario
			// 
			this.txtBinario.Location = new System.Drawing.Point(97, 28);
			this.txtBinario.Name = "txtBinario";
			this.txtBinario.ReadOnly = true;
			this.txtBinario.Size = new System.Drawing.Size(100, 20);
			this.txtBinario.TabIndex = 4;
			// 
			// txtOctal
			// 
			this.txtOctal.Location = new System.Drawing.Point(97, 61);
			this.txtOctal.Name = "txtOctal";
			this.txtOctal.ReadOnly = true;
			this.txtOctal.Size = new System.Drawing.Size(100, 20);
			this.txtOctal.TabIndex = 5;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(39, 231);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(119, 231);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(200, 231);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtHexadecimal
			// 
			this.txtHexadecimal.Location = new System.Drawing.Point(97, 91);
			this.txtHexadecimal.Name = "txtHexadecimal";
			this.txtHexadecimal.ReadOnly = true;
			this.txtHexadecimal.Size = new System.Drawing.Size(100, 20);
			this.txtHexadecimal.TabIndex = 6;
			this.txtHexadecimal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// lblBinario
			// 
			this.lblBinario.AutoSize = true;
			this.lblBinario.Location = new System.Drawing.Point(20, 31);
			this.lblBinario.Name = "lblBinario";
			this.lblBinario.Size = new System.Drawing.Size(42, 13);
			this.lblBinario.TabIndex = 0;
			this.lblBinario.Text = "Binario:";
			this.lblBinario.Click += new System.EventHandler(this.label2_Click);
			// 
			// ejercicio2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 273);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.txtDecimal);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.grpEquivaleA);
			this.Controls.Add(this.lblDecimal);
			this.Name = "ejercicio2";
			this.Text = "ejercicio2";
			this.grpEquivaleA.ResumeLayout(false);
			this.grpEquivaleA.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDecimal;
		private System.Windows.Forms.GroupBox grpEquivaleA;
		private System.Windows.Forms.Label lblHexadecimal;
		private System.Windows.Forms.Label lblOctal;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.TextBox txtOctal;
		private System.Windows.Forms.TextBox txtBinario;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtHexadecimal;
		private System.Windows.Forms.Label lblBinario;
	}
}