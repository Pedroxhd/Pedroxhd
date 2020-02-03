namespace práctica_1_pa
{
	partial class ejercicio1
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
			this.lblExamen1 = new System.Windows.Forms.Label();
			this.lblExamen2 = new System.Windows.Forms.Label();
			this.lblExamen3 = new System.Windows.Forms.Label();
			this.txtExamen1 = new System.Windows.Forms.TextBox();
			this.txtExamen2 = new System.Windows.Forms.TextBox();
			this.txtExamen3 = new System.Windows.Forms.TextBox();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.txtPromedio = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblExamen1
			// 
			this.lblExamen1.AutoSize = true;
			this.lblExamen1.Location = new System.Drawing.Point(40, 36);
			this.lblExamen1.Name = "lblExamen1";
			this.lblExamen1.Size = new System.Drawing.Size(54, 13);
			this.lblExamen1.TabIndex = 0;
			this.lblExamen1.Text = "Examen 1";
			this.lblExamen1.Click += new System.EventHandler(this.lblExamen1_Click);
			// 
			// lblExamen2
			// 
			this.lblExamen2.AutoSize = true;
			this.lblExamen2.Location = new System.Drawing.Point(40, 77);
			this.lblExamen2.Name = "lblExamen2";
			this.lblExamen2.Size = new System.Drawing.Size(54, 13);
			this.lblExamen2.TabIndex = 1;
			this.lblExamen2.Text = "Examen 2";
			this.lblExamen2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblExamen3
			// 
			this.lblExamen3.AutoSize = true;
			this.lblExamen3.Location = new System.Drawing.Point(40, 118);
			this.lblExamen3.Name = "lblExamen3";
			this.lblExamen3.Size = new System.Drawing.Size(54, 13);
			this.lblExamen3.TabIndex = 2;
			this.lblExamen3.Text = "Examen 3";
			this.lblExamen3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtExamen1
			// 
			this.txtExamen1.Location = new System.Drawing.Point(104, 33);
			this.txtExamen1.Name = "txtExamen1";
			this.txtExamen1.Size = new System.Drawing.Size(100, 20);
			this.txtExamen1.TabIndex = 3;
			// 
			// txtExamen2
			// 
			this.txtExamen2.Location = new System.Drawing.Point(104, 74);
			this.txtExamen2.Name = "txtExamen2";
			this.txtExamen2.Size = new System.Drawing.Size(100, 20);
			this.txtExamen2.TabIndex = 4;
			// 
			// txtExamen3
			// 
			this.txtExamen3.Location = new System.Drawing.Point(104, 115);
			this.txtExamen3.Name = "txtExamen3";
			this.txtExamen3.Size = new System.Drawing.Size(100, 20);
			this.txtExamen3.TabIndex = 5;
			// 
			// lblPromedio
			// 
			this.lblPromedio.AutoSize = true;
			this.lblPromedio.Location = new System.Drawing.Point(40, 177);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(51, 13);
			this.lblPromedio.TabIndex = 6;
			this.lblPromedio.Text = "Promedio";
			// 
			// txtPromedio
			// 
			this.txtPromedio.Location = new System.Drawing.Point(104, 174);
			this.txtPromedio.Name = "txtPromedio";
			this.txtPromedio.ReadOnly = true;
			this.txtPromedio.Size = new System.Drawing.Size(100, 20);
			this.txtPromedio.TabIndex = 7;
			this.txtPromedio.TextChanged += new System.EventHandler(this.txtPromedio_TextChanged);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(28, 227);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(109, 227);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 9;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(190, 227);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// ejercicio1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtPromedio);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.txtExamen3);
			this.Controls.Add(this.txtExamen2);
			this.Controls.Add(this.txtExamen1);
			this.Controls.Add(this.lblExamen3);
			this.Controls.Add(this.lblExamen2);
			this.Controls.Add(this.lblExamen1);
			this.Name = "ejercicio1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblExamen1;
		private System.Windows.Forms.Label lblExamen2;
		private System.Windows.Forms.Label lblExamen3;
		private System.Windows.Forms.TextBox txtExamen1;
		private System.Windows.Forms.TextBox txtExamen2;
		private System.Windows.Forms.TextBox txtExamen3;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.TextBox txtPromedio;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
	}
}

