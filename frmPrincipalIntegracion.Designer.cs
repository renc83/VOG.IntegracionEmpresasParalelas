
namespace VOG.IntegracionEmpresasParalelas
{
	partial class frmPrincipalIntegracion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalIntegracion));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtEmpresas = new System.Windows.Forms.DataGridView();
			this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServidorParalelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BDParalela = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServidorProductivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BDProductivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.procesar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAgregar = new System.Windows.Forms.ToolStripButton();
			this.btnSalir = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresas)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblusuario,
            this.lblPC,
            this.lblVersion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 377);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(730, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblusuario
			// 
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.Size = new System.Drawing.Size(60, 17);
			this.lblusuario.Text = "lblUsuario";
			// 
			// lblPC
			// 
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(35, 17);
			this.lblPC.Text = "lblPC";
			// 
			// lblVersion
			// 
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(92, 17);
			this.lblVersion.Text = "V.1.1.0 29012024";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtEmpresas);
			this.groupBox1.Location = new System.Drawing.Point(12, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(705, 291);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Empresas";
			// 
			// dtEmpresas
			// 
			this.dtEmpresas.AllowUserToAddRows = false;
			this.dtEmpresas.AllowUserToDeleteRows = false;
			this.dtEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.ServidorParalelo,
            this.BDParalela,
            this.ServidorProductivo,
            this.BDProductivo,
            this.procesar});
			this.dtEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtEmpresas.Location = new System.Drawing.Point(3, 16);
			this.dtEmpresas.Name = "dtEmpresas";
			this.dtEmpresas.RowHeadersVisible = false;
			this.dtEmpresas.Size = new System.Drawing.Size(699, 272);
			this.dtEmpresas.TabIndex = 0;
			this.dtEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpresas_CellContentClick);
			// 
			// Nro
			// 
			this.Nro.HeaderText = "#";
			this.Nro.Name = "Nro";
			this.Nro.ReadOnly = true;
			this.Nro.Width = 30;
			// 
			// ServidorParalelo
			// 
			this.ServidorParalelo.HeaderText = "Servidor Paralelo";
			this.ServidorParalelo.Name = "ServidorParalelo";
			this.ServidorParalelo.ReadOnly = true;
			this.ServidorParalelo.Width = 180;
			// 
			// BDParalela
			// 
			this.BDParalela.HeaderText = "BD Paralela";
			this.BDParalela.Name = "BDParalela";
			this.BDParalela.ReadOnly = true;
			this.BDParalela.Width = 120;
			// 
			// ServidorProductivo
			// 
			this.ServidorProductivo.HeaderText = "Servidor Productivo";
			this.ServidorProductivo.Name = "ServidorProductivo";
			this.ServidorProductivo.ReadOnly = true;
			this.ServidorProductivo.Width = 180;
			// 
			// BDProductivo
			// 
			this.BDProductivo.HeaderText = "BD Productivo";
			this.BDProductivo.Name = "BDProductivo";
			this.BDProductivo.ReadOnly = true;
			this.BDProductivo.Width = 120;
			// 
			// procesar
			// 
			this.procesar.HeaderText = "Procesar";
			this.procesar.Name = "procesar";
			this.procesar.Width = 60;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(730, 50);
			this.toolStrip1.TabIndex = 25;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(113, 47);
			this.btnAgregar.Text = "Conexiones";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(73, 47);
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// frmPrincipalIntegracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 399);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "frmPrincipalIntegracion";
			this.Text = "Integración Empresas Paralelas";
			this.Load += new System.EventHandler(this.frmInterfazIntegracion_Load);
			this.Enter += new System.EventHandler(this.frmPrincipalIntegracion_Enter);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresas)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblusuario;
		private System.Windows.Forms.ToolStripStatusLabel lblPC;
		private System.Windows.Forms.ToolStripStatusLabel lblVersion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dtEmpresas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServidorParalelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn BDParalela;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServidorProductivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn BDProductivo;
		private System.Windows.Forms.DataGridViewButtonColumn procesar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAgregar;
		private System.Windows.Forms.ToolStripButton btnSalir;
	}
}