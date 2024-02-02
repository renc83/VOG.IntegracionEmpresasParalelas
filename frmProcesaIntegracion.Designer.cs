
namespace VOG.IntegracionEmpresasParalelas
{
	partial class frmProcesaIntegracion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesaIntegracion));
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtDocDesde = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
			this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
			this.txtDocHasta = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.label10 = new System.Windows.Forms.Label();
			this.txtParalela = new System.Windows.Forms.TextBox();
			this.txtBDproductivo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnBuscar = new System.Windows.Forms.ToolStripButton();
			this.btnProbarConexion = new System.Windows.Forms.ToolStripButton();
			this.btnSalir = new System.Windows.Forms.ToolStripButton();
			this.rdTodos = new System.Windows.Forms.RadioButton();
			this.rdFiltros = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbtotaldocumentos = new System.Windows.Forms.Label();
			this.PanelBuscar = new System.Windows.Forms.Panel();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabDocumento = new System.Windows.Forms.TabPage();
			this.dtDatos = new System.Windows.Forms.DataGridView();
			this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabCorrelativos = new System.Windows.Forms.TabPage();
			this.dtCorrelativos = new System.Windows.Forms.DataGridView();
			this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SOPNUMBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chkFecha = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbIDDOC = new System.Windows.Forms.ComboBox();
			this.chkDocumento = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.PanelBuscar.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabDocumento.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtDatos)).BeginInit();
			this.tabCorrelativos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtCorrelativos)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel2.Controls.Add(this.txtDocDesde, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtFechaDesde, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.dtFechaHasta, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtDocHasta, 3, 1);
			this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(128, 117);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 59);
			this.tableLayoutPanel2.TabIndex = 11;
			// 
			// txtDocDesde
			// 
			this.txtDocDesde.Location = new System.Drawing.Point(91, 31);
			this.txtDocDesde.Name = "txtDocDesde";
			this.txtDocDesde.Size = new System.Drawing.Size(107, 20);
			this.txtDocDesde.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(4, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 25);
			this.label8.TabIndex = 0;
			this.label8.Text = "Rango Doc.:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(4, 1);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 25);
			this.label12.TabIndex = 0;
			this.label12.Text = "Fecha Desde:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(205, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Fecha Hasta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtFechaDesde
			// 
			this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaDesde.Location = new System.Drawing.Point(91, 4);
			this.dtFechaDesde.Name = "dtFechaDesde";
			this.dtFechaDesde.Size = new System.Drawing.Size(107, 20);
			this.dtFechaDesde.TabIndex = 7;
			this.dtFechaDesde.Value = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
			// 
			// dtFechaHasta
			// 
			this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaHasta.Location = new System.Drawing.Point(301, 4);
			this.dtFechaHasta.Name = "dtFechaHasta";
			this.dtFechaHasta.Size = new System.Drawing.Size(107, 20);
			this.dtFechaHasta.TabIndex = 8;
			// 
			// txtDocHasta
			// 
			this.txtDocHasta.Location = new System.Drawing.Point(301, 31);
			this.txtDocHasta.Name = "txtDocHasta";
			this.txtDocHasta.Size = new System.Drawing.Size(107, 20);
			this.txtDocHasta.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(205, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Doc Hasta:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblusuario,
            this.lblPC,
            this.lblVersion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 521);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(662, 22);
			this.statusStrip1.TabIndex = 12;
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
			this.lblVersion.Size = new System.Drawing.Size(41, 17);
			this.lblVersion.Text = "V.1.0.0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 110);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "Filtros:";
			// 
			// txtParalela
			// 
			this.txtParalela.Location = new System.Drawing.Point(127, 59);
			this.txtParalela.Name = "txtParalela";
			this.txtParalela.ReadOnly = true;
			this.txtParalela.Size = new System.Drawing.Size(295, 20);
			this.txtParalela.TabIndex = 25;
			// 
			// txtBDproductivo
			// 
			this.txtBDproductivo.Location = new System.Drawing.Point(127, 82);
			this.txtBDproductivo.Name = "txtBDproductivo";
			this.txtBDproductivo.ReadOnly = true;
			this.txtBDproductivo.Size = new System.Drawing.Size(295, 20);
			this.txtBDproductivo.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(16, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "Empresa Paralela:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(16, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 28;
			this.label3.Text = "Empresa Productivo:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.btnProbarConexion,
            this.btnSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(662, 50);
			this.toolStrip1.TabIndex = 29;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(86, 47);
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnProbarConexion
			// 
			this.btnProbarConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnProbarConexion.Image")));
			this.btnProbarConexion.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProbarConexion.Name = "btnProbarConexion";
			this.btnProbarConexion.Size = new System.Drawing.Size(99, 47);
			this.btnProbarConexion.Text = "Transferir";
			this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
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
			// rdTodos
			// 
			this.rdTodos.AutoSize = true;
			this.rdTodos.Checked = true;
			this.rdTodos.Location = new System.Drawing.Point(59, 126);
			this.rdTodos.Name = "rdTodos";
			this.rdTodos.Size = new System.Drawing.Size(55, 17);
			this.rdTodos.TabIndex = 30;
			this.rdTodos.TabStop = true;
			this.rdTodos.Text = "Todos";
			this.rdTodos.UseVisualStyleBackColor = true;
			this.rdTodos.CheckedChanged += new System.EventHandler(this.rdTodos_CheckedChanged);
			// 
			// rdFiltros
			// 
			this.rdFiltros.AutoSize = true;
			this.rdFiltros.Location = new System.Drawing.Point(59, 152);
			this.rdFiltros.Name = "rdFiltros";
			this.rdFiltros.Size = new System.Drawing.Size(52, 17);
			this.rdFiltros.TabIndex = 31;
			this.rdFiltros.Text = "Filtros";
			this.rdFiltros.UseVisualStyleBackColor = true;
			this.rdFiltros.CheckedChanged += new System.EventHandler(this.rdFiltros_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(428, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// lbtotaldocumentos
			// 
			this.lbtotaldocumentos.AutoSize = true;
			this.lbtotaldocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtotaldocumentos.ForeColor = System.Drawing.Color.MediumBlue;
			this.lbtotaldocumentos.Location = new System.Drawing.Point(454, 493);
			this.lbtotaldocumentos.Name = "lbtotaldocumentos";
			this.lbtotaldocumentos.Size = new System.Drawing.Size(175, 20);
			this.lbtotaldocumentos.TabIndex = 33;
			this.lbtotaldocumentos.Text = "Total Documentos: 0";
			// 
			// PanelBuscar
			// 
			this.PanelBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelBuscar.Controls.Add(this.lblMensaje);
			this.PanelBuscar.Location = new System.Drawing.Point(96, 153);
			this.PanelBuscar.Name = "PanelBuscar";
			this.PanelBuscar.Size = new System.Drawing.Size(392, 142);
			this.PanelBuscar.TabIndex = 34;
			this.PanelBuscar.Visible = false;
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensaje.Location = new System.Drawing.Point(121, 65);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(144, 25);
			this.lblMensaje.TabIndex = 0;
			this.lblMensaje.Text = "Buscando....";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabDocumento);
			this.tabControl1.Controls.Add(this.tabCorrelativos);
			this.tabControl1.Location = new System.Drawing.Point(12, 208);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(638, 280);
			this.tabControl1.TabIndex = 35;
			// 
			// tabDocumento
			// 
			this.tabDocumento.Controls.Add(this.dtDatos);
			this.tabDocumento.Location = new System.Drawing.Point(4, 22);
			this.tabDocumento.Name = "tabDocumento";
			this.tabDocumento.Padding = new System.Windows.Forms.Padding(3);
			this.tabDocumento.Size = new System.Drawing.Size(630, 254);
			this.tabDocumento.TabIndex = 0;
			this.tabDocumento.Text = "Documentos";
			this.tabDocumento.UseVisualStyleBackColor = true;
			// 
			// dtDatos
			// 
			this.dtDatos.AllowUserToAddRows = false;
			this.dtDatos.AllowUserToDeleteRows = false;
			this.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.documento,
            this.tipo,
            this.fecha,
            this.cliente,
            this.status});
			this.dtDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtDatos.Location = new System.Drawing.Point(3, 3);
			this.dtDatos.Name = "dtDatos";
			this.dtDatos.RowHeadersVisible = false;
			this.dtDatos.Size = new System.Drawing.Size(624, 248);
			this.dtDatos.TabIndex = 1;
			// 
			// Nro
			// 
			this.Nro.HeaderText = "#";
			this.Nro.Name = "Nro";
			this.Nro.ReadOnly = true;
			this.Nro.Width = 30;
			// 
			// documento
			// 
			this.documento.HeaderText = "Documento";
			this.documento.Name = "documento";
			this.documento.ReadOnly = true;
			// 
			// tipo
			// 
			this.tipo.HeaderText = "Tipo";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			this.tipo.Width = 110;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			this.fecha.Width = 70;
			// 
			// cliente
			// 
			this.cliente.HeaderText = "Cliente";
			this.cliente.Name = "cliente";
			this.cliente.ReadOnly = true;
			this.cliente.Width = 200;
			// 
			// status
			// 
			this.status.HeaderText = "Status";
			this.status.Name = "status";
			this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// tabCorrelativos
			// 
			this.tabCorrelativos.Controls.Add(this.dtCorrelativos);
			this.tabCorrelativos.Location = new System.Drawing.Point(4, 22);
			this.tabCorrelativos.Name = "tabCorrelativos";
			this.tabCorrelativos.Padding = new System.Windows.Forms.Padding(3);
			this.tabCorrelativos.Size = new System.Drawing.Size(630, 254);
			this.tabCorrelativos.TabIndex = 1;
			this.tabCorrelativos.Text = "Ultimos Correlativos";
			this.tabCorrelativos.UseVisualStyleBackColor = true;
			// 
			// dtCorrelativos
			// 
			this.dtCorrelativos.AllowUserToAddRows = false;
			this.dtCorrelativos.AllowUserToDeleteRows = false;
			this.dtCorrelativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtCorrelativos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila,
            this.DOCID,
            this.SOPNUMBE});
			this.dtCorrelativos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtCorrelativos.Location = new System.Drawing.Point(3, 3);
			this.dtCorrelativos.Name = "dtCorrelativos";
			this.dtCorrelativos.ReadOnly = true;
			this.dtCorrelativos.RowHeadersVisible = false;
			this.dtCorrelativos.Size = new System.Drawing.Size(624, 248);
			this.dtCorrelativos.TabIndex = 0;
			// 
			// Fila
			// 
			this.Fila.HeaderText = "#";
			this.Fila.Name = "Fila";
			this.Fila.ReadOnly = true;
			this.Fila.Width = 40;
			// 
			// DOCID
			// 
			this.DOCID.HeaderText = "ID Documento";
			this.DOCID.Name = "DOCID";
			this.DOCID.ReadOnly = true;
			this.DOCID.Width = 120;
			// 
			// SOPNUMBE
			// 
			this.SOPNUMBE.HeaderText = "Correlativo";
			this.SOPNUMBE.Name = "SOPNUMBE";
			this.SOPNUMBE.ReadOnly = true;
			this.SOPNUMBE.Width = 120;
			// 
			// chkFecha
			// 
			this.chkFecha.AutoSize = true;
			this.chkFecha.Checked = true;
			this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFecha.Location = new System.Drawing.Point(548, 126);
			this.chkFecha.Name = "chkFecha";
			this.chkFecha.Size = new System.Drawing.Size(15, 14);
			this.chkFecha.TabIndex = 36;
			this.chkFecha.UseVisualStyleBackColor = true;
			this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98438F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01563F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cmbIDDOC, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(128, 175);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 28);
			this.tableLayoutPanel1.TabIndex = 37;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "ID Documento:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbIDDOC
			// 
			this.cmbIDDOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIDDOC.FormattingEnabled = true;
			this.cmbIDDOC.Location = new System.Drawing.Point(91, 4);
			this.cmbIDDOC.Name = "cmbIDDOC";
			this.cmbIDDOC.Size = new System.Drawing.Size(153, 21);
			this.cmbIDDOC.TabIndex = 39;
			// 
			// chkDocumento
			// 
			this.chkDocumento.AutoSize = true;
			this.chkDocumento.Location = new System.Drawing.Point(548, 152);
			this.chkDocumento.Name = "chkDocumento";
			this.chkDocumento.Size = new System.Drawing.Size(15, 14);
			this.chkDocumento.TabIndex = 38;
			this.chkDocumento.UseVisualStyleBackColor = true;
			this.chkDocumento.CheckedChanged += new System.EventHandler(this.chkDocumento_CheckedChanged);
			// 
			// frmProcesaIntegracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 543);
			this.Controls.Add(this.chkDocumento);
			this.Controls.Add(this.PanelBuscar);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.chkFecha);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lbtotaldocumentos);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rdFiltros);
			this.Controls.Add(this.rdTodos);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBDproductivo);
			this.Controls.Add(this.txtParalela);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "frmProcesaIntegracion";
			this.Text = "Integración Empresas";
			this.Load += new System.EventHandler(this.frmProcesaIntegracion_Load);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.PanelBuscar.ResumeLayout(false);
			this.PanelBuscar.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabDocumento.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtDatos)).EndInit();
			this.tabCorrelativos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtCorrelativos)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox txtDocDesde;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblusuario;
		private System.Windows.Forms.ToolStripStatusLabel lblPC;
		private System.Windows.Forms.ToolStripStatusLabel lblVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtFechaDesde;
		private System.Windows.Forms.DateTimePicker dtFechaHasta;
		private System.Windows.Forms.TextBox txtDocHasta;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtParalela;
		private System.Windows.Forms.TextBox txtBDproductivo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnBuscar;
		private System.Windows.Forms.ToolStripButton btnProbarConexion;
		private System.Windows.Forms.ToolStripButton btnSalir;
		private System.Windows.Forms.RadioButton rdTodos;
		private System.Windows.Forms.RadioButton rdFiltros;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbtotaldocumentos;
		private System.Windows.Forms.Panel PanelBuscar;
		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabDocumento;
		private System.Windows.Forms.DataGridView dtDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.TabPage tabCorrelativos;
		private System.Windows.Forms.DataGridView dtCorrelativos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOCID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SOPNUMBE;
		private System.Windows.Forms.CheckBox chkFecha;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkDocumento;
		private System.Windows.Forms.ComboBox cmbIDDOC;
	}
}