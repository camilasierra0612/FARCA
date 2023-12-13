namespace Servicio_actas_farmaceuticas
{
    partial class Menu_opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_opciones));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresarDatosProveedor = new System.Windows.Forms.Button();
            this.btnRegistroLaboratorio = new System.Windows.Forms.Button();
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnIngresoActas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(395, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresarDatosProveedor
            // 
            this.btnIngresarDatosProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresarDatosProveedor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatosProveedor.Location = new System.Drawing.Point(465, 256);
            this.btnIngresarDatosProveedor.Name = "btnIngresarDatosProveedor";
            this.btnIngresarDatosProveedor.Size = new System.Drawing.Size(309, 53);
            this.btnIngresarDatosProveedor.TabIndex = 8;
            this.btnIngresarDatosProveedor.Text = "Ingresar datos de proveedores";
            this.btnIngresarDatosProveedor.UseVisualStyleBackColor = true;
            this.btnIngresarDatosProveedor.Click += new System.EventHandler(this.btnIngresarDatosProveedor_Click);
            // 
            // btnRegistroLaboratorio
            // 
            this.btnRegistroLaboratorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroLaboratorio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroLaboratorio.Location = new System.Drawing.Point(465, 172);
            this.btnRegistroLaboratorio.Name = "btnRegistroLaboratorio";
            this.btnRegistroLaboratorio.Size = new System.Drawing.Size(309, 53);
            this.btnRegistroLaboratorio.TabIndex = 7;
            this.btnRegistroLaboratorio.Text = "Registrar laboratorios";
            this.btnRegistroLaboratorio.UseVisualStyleBackColor = true;
            this.btnRegistroLaboratorio.Click += new System.EventHandler(this.btnRegistroLaboratorio_Click);
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistroProducto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProducto.Location = new System.Drawing.Point(113, 256);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(309, 53);
            this.btnRegistroProducto.TabIndex = 6;
            this.btnRegistroProducto.Text = "Registrar productos";
            this.btnRegistroProducto.UseVisualStyleBackColor = true;
            this.btnRegistroProducto.Click += new System.EventHandler(this.btnRegistroProducto_Click);
            // 
            // btnIngresoActas
            // 
            this.btnIngresoActas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresoActas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoActas.Location = new System.Drawing.Point(113, 172);
            this.btnIngresoActas.Name = "btnIngresoActas";
            this.btnIngresoActas.Size = new System.Drawing.Size(309, 53);
            this.btnIngresoActas.TabIndex = 5;
            this.btnIngresoActas.Text = "Ingresar actas";
            this.btnIngresoActas.UseVisualStyleBackColor = true;
            this.btnIngresoActas.Click += new System.EventHandler(this.btnIngresoActas_Click);
            // 
            // Menu_opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 469);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresarDatosProveedor);
            this.Controls.Add(this.btnRegistroLaboratorio);
            this.Controls.Add(this.btnRegistroProducto);
            this.Controls.Add(this.btnIngresoActas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_opciones";
            this.Text = "Menú de opciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresarDatosProveedor;
        private System.Windows.Forms.Button btnRegistroLaboratorio;
        private System.Windows.Forms.Button btnRegistroProducto;
        private System.Windows.Forms.Button btnIngresoActas;
    }
}