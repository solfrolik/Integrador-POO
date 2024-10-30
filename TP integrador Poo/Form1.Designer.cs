namespace TP_integrador_Poo
{
   partial class Form1
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
         this.lstPersonas = new System.Windows.Forms.ListBox();
         this.lblNombre = new System.Windows.Forms.Label();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.lblApellido = new System.Windows.Forms.Label();
         this.txtApellido = new System.Windows.Forms.TextBox();
         this.lblDNI = new System.Windows.Forms.Label();
         this.txtDNI = new System.Windows.Forms.TextBox();
         this.btnAlta = new System.Windows.Forms.Button();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.lblFechaAlta = new System.Windows.Forms.Label();
         this.txtAntiguedad = new System.Windows.Forms.TextBox();
         this.lblAntiguedad = new System.Windows.Forms.Label();
         this.dTPFechaAlta = new System.Windows.Forms.DateTimePicker();
         this.SuspendLayout();
         // 
         // lstPersonas
         // 
         this.lstPersonas.FormattingEnabled = true;
         this.lstPersonas.ItemHeight = 16;
         this.lstPersonas.Location = new System.Drawing.Point(391, 31);
         this.lstPersonas.Name = "lstPersonas";
         this.lstPersonas.Size = new System.Drawing.Size(361, 372);
         this.lstPersonas.TabIndex = 0;
         // 
         // lblNombre
         // 
         this.lblNombre.AutoSize = true;
         this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNombre.Location = new System.Drawing.Point(56, 57);
         this.lblNombre.Name = "lblNombre";
         this.lblNombre.Size = new System.Drawing.Size(78, 22);
         this.lblNombre.TabIndex = 1;
         this.lblNombre.Text = "Nombre:";
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(168, 59);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(144, 22);
         this.txtNombre.TabIndex = 2;
         // 
         // lblApellido
         // 
         this.lblApellido.AutoSize = true;
         this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblApellido.Location = new System.Drawing.Point(56, 115);
         this.lblApellido.Name = "lblApellido";
         this.lblApellido.Size = new System.Drawing.Size(79, 22);
         this.lblApellido.TabIndex = 3;
         this.lblApellido.Text = "Apellido:";
         // 
         // txtApellido
         // 
         this.txtApellido.Location = new System.Drawing.Point(168, 117);
         this.txtApellido.Name = "txtApellido";
         this.txtApellido.Size = new System.Drawing.Size(144, 22);
         this.txtApellido.TabIndex = 4;
         // 
         // lblDNI
         // 
         this.lblDNI.AutoSize = true;
         this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDNI.Location = new System.Drawing.Point(89, 172);
         this.lblDNI.Name = "lblDNI";
         this.lblDNI.Size = new System.Drawing.Size(45, 22);
         this.lblDNI.TabIndex = 5;
         this.lblDNI.Text = "DNI:";
         // 
         // txtDNI
         // 
         this.txtDNI.Location = new System.Drawing.Point(168, 172);
         this.txtDNI.Name = "txtDNI";
         this.txtDNI.Size = new System.Drawing.Size(144, 22);
         this.txtDNI.TabIndex = 6;
         // 
         // btnAlta
         // 
         this.btnAlta.Location = new System.Drawing.Point(60, 355);
         this.btnAlta.Name = "btnAlta";
         this.btnAlta.Size = new System.Drawing.Size(98, 48);
         this.btnAlta.TabIndex = 7;
         this.btnAlta.Text = "ALTA";
         this.btnAlta.UseVisualStyleBackColor = true;
         this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
         // 
         // btnBuscar
         // 
         this.btnBuscar.Location = new System.Drawing.Point(252, 355);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(98, 48);
         this.btnBuscar.TabIndex = 8;
         this.btnBuscar.Text = "BUSCAR";
         this.btnBuscar.UseVisualStyleBackColor = true;
         this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
         // 
         // lblFechaAlta
         // 
         this.lblFechaAlta.AutoSize = true;
         this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFechaAlta.Location = new System.Drawing.Point(34, 227);
         this.lblFechaAlta.Name = "lblFechaAlta";
         this.lblFechaAlta.Size = new System.Drawing.Size(101, 22);
         this.lblFechaAlta.TabIndex = 9;
         this.lblFechaAlta.Text = "Fecha Alta:";
         // 
         // txtAntiguedad
         // 
         this.txtAntiguedad.Location = new System.Drawing.Point(168, 283);
         this.txtAntiguedad.Name = "txtAntiguedad";
         this.txtAntiguedad.Size = new System.Drawing.Size(200, 22);
         this.txtAntiguedad.TabIndex = 10;
         // 
         // lblAntiguedad
         // 
         this.lblAntiguedad.AutoSize = true;
         this.lblAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblAntiguedad.Location = new System.Drawing.Point(34, 281);
         this.lblAntiguedad.Name = "lblAntiguedad";
         this.lblAntiguedad.Size = new System.Drawing.Size(106, 22);
         this.lblAntiguedad.TabIndex = 11;
         this.lblAntiguedad.Text = "Antiguedad:";
         // 
         // dTPFechaAlta
         // 
         this.dTPFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dTPFechaAlta.Location = new System.Drawing.Point(168, 227);
         this.dTPFechaAlta.Name = "dTPFechaAlta";
         this.dTPFechaAlta.Size = new System.Drawing.Size(144, 22);
         this.dTPFechaAlta.TabIndex = 12;
         this.dTPFechaAlta.Value = new System.DateTime(2024, 5, 19, 12, 18, 29, 0);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dTPFechaAlta);
         this.Controls.Add(this.lblAntiguedad);
         this.Controls.Add(this.txtAntiguedad);
         this.Controls.Add(this.lblFechaAlta);
         this.Controls.Add(this.btnBuscar);
         this.Controls.Add(this.btnAlta);
         this.Controls.Add(this.txtDNI);
         this.Controls.Add(this.lblDNI);
         this.Controls.Add(this.txtApellido);
         this.Controls.Add(this.lblApellido);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.lblNombre);
         this.Controls.Add(this.lstPersonas);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lstPersonas;
      private System.Windows.Forms.Label lblNombre;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.Label lblApellido;
      private System.Windows.Forms.TextBox txtApellido;
      private System.Windows.Forms.Label lblDNI;
      private System.Windows.Forms.TextBox txtDNI;
      private System.Windows.Forms.Button btnAlta;
      private System.Windows.Forms.Button btnBuscar;
      private System.Windows.Forms.Label lblFechaAlta;
      private System.Windows.Forms.TextBox txtAntiguedad;
      private System.Windows.Forms.Label lblAntiguedad;
      private System.Windows.Forms.DateTimePicker dTPFechaAlta;
   }
}

