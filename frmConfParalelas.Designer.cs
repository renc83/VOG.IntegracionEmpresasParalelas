
namespace VOG.IntegracionEmpresasParalelas
{
	partial class frmConfParalelas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfParalelas));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.navigatorParalelas = new System.Windows.Forms.BindingNavigator(this.components);
			this.SourceComParalelas = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtBDDestino = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsuarioGp = new System.Windows.Forms.TextBox();
			this.txtBDGp = new System.Windows.Forms.TextBox();
			this.txtServerGp = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtPasswordGp = new System.Windows.Forms.TextBox();
			this.txtConexionGp = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnCorreo = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPrueba = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnGuardar = new System.Windows.Forms.ToolStripButton();
			this.btnEliminar = new System.Windows.Forms.ToolStripButton();
			this.btnProbarConexion = new System.Windows.Forms.ToolStripButton();
			this.btnSalir = new System.Windows.Forms.ToolStripButton();
			this.txtActiva = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtServidorDestino = new System.Windows.Forms.TextBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigatorParalelas)).BeginInit();
			this.navigatorParalelas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SourceComParalelas)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblusuario,
            this.lblPC,
            this.lblVersion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 374);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(497, 22);
			this.statusStrip1.TabIndex = 2;
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
			this.lblVersion.Size = new System.Drawing.Size(100, 17);
			this.lblVersion.Text = "V.1.1.0 - 29012024";
			// 
			// navigatorParalelas
			// 
			this.navigatorParalelas.AddNewItem = null;
			this.navigatorParalelas.BindingSource = this.SourceComParalelas;
			this.navigatorParalelas.CountItem = this.bindingNavigatorCountItem;
			this.navigatorParalelas.DeleteItem = null;
			this.navigatorParalelas.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.navigatorParalelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.navigatorParalelas.Location = new System.Drawing.Point(0, 349);
			this.navigatorParalelas.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.navigatorParalelas.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.navigatorParalelas.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.navigatorParalelas.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.navigatorParalelas.Name = "navigatorParalelas";
			this.navigatorParalelas.PositionItem = this.bindingNavigatorPositionItem;
			this.navigatorParalelas.Size = new System.Drawing.Size(497, 25);
			this.navigatorParalelas.TabIndex = 3;
			this.navigatorParalelas.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Posición";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Mover último";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.txtServidorDestino, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.txtUsuarioGp, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.txtBDGp, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.txtServerGp, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txtPasswordGp, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.txtConexionGp, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.txtDescripcion, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtBDDestino, 1, 6);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 91);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 233);
			this.tableLayoutPanel2.TabIndex = 10;
			// 
			// txtBDDestino
			// 
			this.txtBDDestino.Location = new System.Drawing.Point(109, 168);
			this.txtBDDestino.Name = "txtBDDestino";
			this.txtBDDestino.Size = new System.Drawing.Size(205, 20);
			this.txtBDDestino.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "BD Destino";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(4, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Conexión Paralela";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUsuarioGp
			// 
			this.txtUsuarioGp.Location = new System.Drawing.Point(109, 87);
			this.txtUsuarioGp.Name = "txtUsuarioGp";
			this.txtUsuarioGp.Size = new System.Drawing.Size(205, 20);
			this.txtUsuarioGp.TabIndex = 3;
			this.txtUsuarioGp.Validated += new System.EventHandler(this.txtUsuarioGp_Validated);
			// 
			// txtBDGp
			// 
			this.txtBDGp.Location = new System.Drawing.Point(109, 60);
			this.txtBDGp.Name = "txtBDGp";
			this.txtBDGp.Size = new System.Drawing.Size(205, 20);
			this.txtBDGp.TabIndex = 2;
			this.txtBDGp.Validated += new System.EventHandler(this.txtBDGp_Validated);
			// 
			// txtServerGp
			// 
			this.txtServerGp.Location = new System.Drawing.Point(109, 33);
			this.txtServerGp.Name = "txtServerGp";
			this.txtServerGp.Size = new System.Drawing.Size(205, 20);
			this.txtServerGp.TabIndex = 1;
			this.txtServerGp.Validated += new System.EventHandler(this.txtServerGp_Validated);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(4, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Contraseña";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(4, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Usuario";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(4, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 25);
			this.label8.TabIndex = 0;
			this.label8.Text = "Base de Datos";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(4, 30);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 25);
			this.label12.TabIndex = 0;
			this.label12.Text = "Servidor";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPasswordGp
			// 
			this.txtPasswordGp.Location = new System.Drawing.Point(109, 114);
			this.txtPasswordGp.Name = "txtPasswordGp";
			this.txtPasswordGp.PasswordChar = '*';
			this.txtPasswordGp.Size = new System.Drawing.Size(205, 20);
			this.txtPasswordGp.TabIndex = 4;
			this.txtPasswordGp.Validated += new System.EventHandler(this.txtPasswordGp_Validated);
			// 
			// txtConexionGp
			// 
			this.txtConexionGp.Location = new System.Drawing.Point(109, 141);
			this.txtConexionGp.Name = "txtConexionGp";
			this.txtConexionGp.ReadOnly = true;
			this.txtConexionGp.Size = new System.Drawing.Size(205, 20);
			this.txtConexionGp.TabIndex = 4;
			this.txtConexionGp.TextChanged += new System.EventHandler(this.txtConexionGp_TextChanged);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(109, 4);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(205, 20);
			this.txtDescripcion.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nombre Conexion";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BtnCorreo
			// 
			this.BtnCorreo.Location = new System.Drawing.Point(462, 118);
			this.BtnCorreo.Name = "BtnCorreo";
			this.BtnCorreo.Size = new System.Drawing.Size(23, 26);
			this.BtnCorreo.TabIndex = 21;
			this.BtnCorreo.Text = ">";
			this.BtnCorreo.UseVisualStyleBackColor = true;
			this.BtnCorreo.Visible = false;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(442, 92);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(43, 20);
			this.txtEmail.TabIndex = 20;
			this.txtEmail.Text = "Correo";
			this.txtEmail.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(49, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(195, 17);
			this.label10.TabIndex = 22;
			this.label10.Text = "BD Paralela Dynamics GP";
			// 
			// txtPrueba
			// 
			this.txtPrueba.Location = new System.Drawing.Point(320, 61);
			this.txtPrueba.Name = "txtPrueba";
			this.txtPrueba.ReadOnly = true;
			this.txtPrueba.Size = new System.Drawing.Size(24, 20);
			this.txtPrueba.TabIndex = 7;
			this.txtPrueba.Text = "0";
			this.txtPrueba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPrueba.Visible = false;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(350, 61);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(25, 20);
			this.txtID.TabIndex = 23;
			this.txtID.Text = "0";
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnProbarConexion,
            this.btnSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(497, 50);
			this.toolStrip1.TabIndex = 24;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(84, 47);
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(93, 47);
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 47);
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnProbarConexion
			// 
			this.btnProbarConexion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProbarConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnProbarConexion.Image")));
			this.btnProbarConexion.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnProbarConexion.Name = "btnProbarConexion";
			this.btnProbarConexion.Size = new System.Drawing.Size(137, 47);
			this.btnProbarConexion.Text = "Probar Conexion";
			this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(73, 47);
			this.btnSalir.Text = "Salir";
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtActiva
			// 
			this.txtActiva.Location = new System.Drawing.Point(381, 60);
			this.txtActiva.Name = "txtActiva";
			this.txtActiva.ReadOnly = true;
			this.txtActiva.Size = new System.Drawing.Size(43, 20);
			this.txtActiva.TabIndex = 25;
			this.txtActiva.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 23);
			this.label3.TabIndex = 27;
			this.label3.Text = "Servidor Destino";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtServidorDestino
			// 
			this.txtServidorDestino.Location = new System.Drawing.Point(109, 202);
			this.txtServidorDestino.Name = "txtServidorDestino";
			this.txtServidorDestino.ReadOnly = true;
			this.txtServidorDestino.Size = new System.Drawing.Size(205, 20);
			this.txtServidorDestino.TabIndex = 27;
			// 
			// frmConfParalelas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 396);
			this.Controls.Add(this.txtActiva);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.BtnCorreo);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.navigatorParalelas);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.txtPrueba);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConfParalelas";
			this.Text = "Configuracion Empresas";
			this.Load += new System.EventHandler(this.frmConfParalelas_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigatorParalelas)).EndInit();
			this.navigatorParalelas.ResumeLayout(false);
			this.navigatorParalelas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SourceComParalelas)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private System.Windows.Forms.BindingNavigator navigatorParalelas;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUsuarioGp;
		private System.Windows.Forms.TextBox txtBDGp;
		private System.Windows.Forms.TextBox txtServerGp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtPasswordGp;
		private System.Windows.Forms.TextBox txtConexionGp;
		private System.Windows.Forms.Button BtnCorreo;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPrueba;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnGuardar;
		private System.Windows.Forms.ToolStripButton btnEliminar;
		private System.Windows.Forms.ToolStripButton btnProbarConexion;
		private System.Windows.Forms.ToolStripButton btnSalir;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource SourceComParalelas;
		private System.Windows.Forms.TextBox txtActiva;
		private System.Windows.Forms.TextBox txtBDDestino;
		private System.Windows.Forms.TextBox txtServidorDestino;
		private System.Windows.Forms.Label label3;
	}
}