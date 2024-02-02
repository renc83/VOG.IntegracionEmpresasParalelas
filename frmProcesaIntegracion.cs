using Microsoft.Dynamics.GP.eConnect.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Controller;
using VOG.IntegracionEmpresasParalelas.Entities;

namespace VOG.IntegracionEmpresasParalelas
{
	public partial class frmProcesaIntegracion : Form
	{
		int IDparalela;
		cSalesDocParalelo controllerParalelo = new cSalesDocParalelo();
		cSalesDocProductivo controllerProductivo = new cSalesDocProductivo();
		clsServerConection sConexionParalela = new clsServerConection();
		List<eFacturasParalela> ListadoFacturas = new List<eFacturasParalela>();
		List<eFacturasProductivo> ListadoCorrelativos = new List<eFacturasProductivo>();

		public frmProcesaIntegracion(int ROW_ID)
		{
			InitializeComponent();
			IDparalela = ROW_ID;
		}

		private void frmProcesaIntegracion_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();
			lblPC.Text = Environment.MachineName.ToString().ToUpper();
			lblusuario.Text = SystemInformation.UserName.ToString().ToUpper();
			lblVersion.Text = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
			cmbIDDOC.Items.Clear();
			cmbIDDOC.Items.Add("Todos");
			cmbIDDOC.SelectedIndex = 0;
			BuscaConexionParalela(IDparalela);
			BuscaConexionProductivo();
			HabilitaFiltros(false);
		}

		internal void HabilitaFiltros(bool flag) {
			txtDocDesde.Enabled = flag;
			txtDocHasta.Enabled = flag;
			dtFechaDesde.Enabled = flag;
			dtFechaHasta.Enabled = flag;
			cmbIDDOC.Enabled = flag;
			chkDocumento.Enabled = flag;
			chkDocumento.Checked = flag;
			chkFecha.Enabled = flag;
			chkFecha.Checked = flag;
			cmbIDDOC.SelectedIndex = 0;
		}

		private void rdFiltros_CheckedChanged(object sender, EventArgs e)
		{
			HabilitaFiltros(true);
		}

		private void rdTodos_CheckedChanged(object sender, EventArgs e)
		{
			HabilitaFiltros(false);
		}

		private void BuscaConexionParalela(int id) {
			cCompanyParalela Companias = new cCompanyParalela();
			eCompanyParalela EmpParalela = Companias.BuscarEmpresaParalela(id);
			sConexionParalela = JsonConvert.DeserializeObject<clsServerConection>(EmpParalela.Conexion);
			txtParalela.Text = $"Servidor: {sConexionParalela.ServerName} - BD: {sConexionParalela.DatabaseName}"; // EmpParalela.Conexion;
			sysGlobales.conexionproductivo.DatabaseName = EmpParalela.BDDestino;
		}

		internal void BuscaConexionProductivo() {
			txtBDproductivo.Text = $"Servidor: {sysGlobales.conexionproductivo.ServerName} - BD: {sysGlobales.conexionproductivo.DatabaseName}"; // EmpParalela.Conexion;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			PanelBuscar.Visible = true;
			lblMensaje.Text = "Buscando...";
			ListadoFacturas.Clear();
			ListadoFacturas=BuscarRegistros();
			LlenarGrid(ListadoFacturas);
			lbtotaldocumentos.Text=$"Total Documentos: {ListadoFacturas.Count()}";
			PanelBuscar.Visible = false;
		}

		internal List<eFacturasParalela> BuscarRegistros() {			
			eFiltro filtro = new eFiltro();
			ListadoCorrelativos = controllerProductivo.ListarUltFacturasProductivo();
			if (cmbIDDOC.SelectedItem.ToString() != "Todos") {
				ListadoCorrelativos = ListadoCorrelativos.Where(x => x.DOCID == cmbIDDOC.SelectedItem.ToString()).ToList();
			}			
			LlenarGridCOrrelativo(ListadoCorrelativos);

			if (rdFiltros.Checked)
			{
				if (chkFecha.Checked)
				{
					filtro.FechaDesde = dtFechaDesde.Value.ToString("yyyyMMdd");
					filtro.FechaHasta = dtFechaHasta.Value.ToString("yyyyMMdd");
				}
				if (chkDocumento.Checked)
				{
					filtro.DocDesde = txtDocDesde.Text;
					filtro.DocHasta = txtDocHasta.Text;
				}
			}
			foreach (eFacturasProductivo item in ListadoCorrelativos)
			{
				filtro.DOCID = item.DOCID;
				filtro.UltimoDocumento = item.SOPNUMBE;
				List<eFacturasParalela> ListFacturas = new List<eFacturasParalela>();
				ListFacturas = controllerParalelo.ListarFacturasParalelo(filtro, sConexionParalela);
				foreach (var iFact in ListFacturas)
				{
					ListadoFacturas.Add(iFact);
				}
			}
			return ListadoFacturas;
		}

		internal void LlenarGrid(List<eFacturasParalela> ListDatos)
		{
			dtDatos.Rows.Clear();
			if (ListDatos.Count == 0)
			{
				MessageBox.Show("Archivo Vacio");
			}
			else
			{
				int i = 1;
				foreach (SOPTransactionType linea in ListDatos)
				{
					dtDatos.Rows.Add();
					int fila = dtDatos.Rows.Count - 1;
					dtDatos["Nro", fila].Value = i ;
					dtDatos["documento", fila].Value = linea.taSopHdrIvcInsert.SOPNUMBE;
					dtDatos["tipo", fila].Value = linea.taSopHdrIvcInsert.DOCID;
					dtDatos["fecha", fila].Value = Convert.ToDateTime(linea.taSopHdrIvcInsert.DOCDATE).ToString("dd/MM/yyyy");
					dtDatos["cliente", fila].Value = linea.taSopHdrIvcInsert.CUSTNAME;
					dtDatos["status", fila].Value = "";
					i++;
				}
			}
		}

		internal void LlenarGridCOrrelativo(List<eFacturasProductivo> ListDatos)
		{
			ListDatos = ListDatos.OrderBy(x=> x.SOPNUMBE).ToList();
			dtCorrelativos.Rows.Clear();
			if (ListDatos.Count == 0)
			{
				//MessageBox.Show("Archivo Vacio");
			}
			else
			{
				int i = 1;
				foreach (eFacturasProductivo linea in ListDatos)
				{
					dtCorrelativos.Rows.Add();
					int fila = dtCorrelativos.Rows.Count - 1;
					dtCorrelativos["Fila", fila].Value = i;
					dtCorrelativos["DOCID", fila].Value = linea.DOCID;
					dtCorrelativos["SOPNUMBE", fila].Value = linea.SOPNUMBE;
					cmbIDDOC.Items.Add(linea.DOCID);
					i++;
				}
			}
		}

		internal void LlenarGrid(SOPTransactionType ListDatos,string mensaje)
		{
			dtDatos.Rows.Add();
			int fila = dtDatos.Rows.Count - 1;
			dtDatos["Nro", fila].Value = fila;
			dtDatos["documento", fila].Value = ListDatos.taSopHdrIvcInsert.SOPNUMBE;
			dtDatos["tipo", fila].Value = ListDatos.taSopHdrIvcInsert.DOCID;
			dtDatos["fecha", fila].Value = Convert.ToDateTime(ListDatos.taSopHdrIvcInsert.DOCDATE).ToString("dd/MM/yyyy");
			dtDatos["cliente", fila].Value = ListDatos.taSopHdrIvcInsert.CUSTNAME;
			dtDatos["status", fila].Value = mensaje;
		}

		private void btnProbarConexion_Click(object sender, EventArgs e)
		{
			List<string> ListResultados = new List<string>();
			List<string> ListErrores = new List<string>();
			string txtLinea;
			txtLinea = ($"*************Integracion Empresas Paralelas*********");
			ListResultados.Add(txtLinea);
			txtLinea = ($"Origen Empresa Paralela:{txtParalela.Text}");
			ListResultados.Add(txtLinea);
			txtLinea = ($"Destino Empresa Productivo:{txtBDproductivo.Text}");
			ListResultados.Add(txtLinea);

			PanelBuscar.Visible = true;
			lblMensaje.Text = "Buscando...";
			ListadoFacturas.Clear();
			ListadoFacturas = BuscarRegistros();
			dtDatos.Rows.Clear();
			int iDoc = 0;
			if (ListadoFacturas.Count>0) {
				ListErrores = validarIntegracion(ListadoFacturas);
				if (ListErrores.Count==0)
				{
					lblMensaje.Text = $"Procesando...{iDoc}/{ListadoFacturas.Count}";
					foreach (eFacturasParalela documento in ListadoFacturas)
					{
						iDoc++;
						lblMensaje.Text = $"Procesando...{iDoc}/{ListadoFacturas.Count}";
						clsMsjRespuesta respuesta = new clsMsjRespuesta();
						respuesta = ProcesarDocumentos(documento);
						LlenarGrid(documento, respuesta.sMensaje);
						txtLinea = ($"#{iDoc},{documento.taSopHdrIvcInsert.SOPNUMBE} , {documento.taSopHdrIvcInsert.DOCID} , " +
								   $"{documento.taSopHdrIvcInsert.DOCDATE} , {documento.taSopHdrIvcInsert.CUSTNMBR} , {documento.taSopHdrIvcInsert.CUSTNAME} , " +
								   $"****{respuesta.sMensaje}***");
						ListResultados.Add(txtLinea);
					}
					GeneraTxt(ListResultados);
				}
				else {
					MessageBox.Show($"No se puede integrar. Existen Errores.");
					GeneraTxt(ListErrores);
				}
					

			}
			else {
				MessageBox.Show("Archivo Vacio","Integracion VOG");
			}
			PanelBuscar.Visible = false;
		}

		internal clsMsjRespuesta ProcesarDocumentos(eFacturasParalela Documento) {
			clsMsjRespuesta respuesta = new clsMsjRespuesta();

			var correlativos = ListadoCorrelativos.Where(x => x.DOCID == Documento.taSopHdrIvcInsert.DOCID).FirstOrDefault();
			int index = ListadoCorrelativos.FindIndex(x => x.DOCID == Documento.taSopHdrIvcInsert.DOCID);
			//int index = correlativos.
			string ultimo = SiguienteCorrelativo( ListadoCorrelativos[index].LASTSOPNUMBE);

			if (Documento.taSopHdrIvcInsert.SOPNUMBE == ultimo)
			{
				respuesta = controllerProductivo.ProcesarDocumentos(Documento);
				if (respuesta.sError == 0) { respuesta.sMensaje = "Registro Procesado."; }
				ListadoCorrelativos[index].LASTSOPNUMBE = ultimo;
			}
			else {
				respuesta.sError = 1;
				respuesta.sMensaje = $"Faltan Nro. {ultimo}";
			}
			return respuesta;
		}

		internal void GeneraTxt(List<string> ListadoResultados)
		{
			DialogResult dialogResult = MessageBox.Show($"Desea Guardar Txt con los resultados?", "Integracion Empresas", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				SaveFileDialog SaveFileDialog = new SaveFileDialog();
				SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				if (SaveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string PathLogResult = SaveFileDialog.FileName;
					StreamWriter sw = new StreamWriter(PathLogResult);
					string txtLinea;
					foreach (string linea in ListadoResultados)
					{						
						sw.WriteLine(linea);
					}
					sw.Close();
					MessageBox.Show("Archivo Guardado", "Integracion Empresas");
				}
			}
		}//fin pregunta

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		internal string SiguienteCorrelativo(string correlativo) {
			string siguiente = "";
			int largotxt = correlativo.Length-1;
			string numericotxt = "";
			string numcorrelativo = "";
			string carcorrelativo = "";
			int n=0;
			for (int i = largotxt; i >=0 ; i--)
			{
				var car = correlativo.Substring(i,1);
				if (int.TryParse(car, out n)) //numero
				{
					numcorrelativo = correlativo.Substring(i, (largotxt+1) - i);
					numericotxt+="0";
				}
				else {
					carcorrelativo= correlativo.Substring(0,i+1);
					break;
				}
			}

			int num = Convert.ToInt32(numcorrelativo) + 1;
			string aux1 = String.Concat(numericotxt, num.ToString());
			siguiente = String.Concat(carcorrelativo,aux1.Substring(aux1.Length - numericotxt.Length, numericotxt.Length));
			return siguiente;
		}

		internal List<string> validarIntegracion(List<eFacturasParalela> ListadoFacturas) {
			List<string> ListErrores = new List<string>();
			
			List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert> listDetalles = new List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert>();
			//valida la informacion fiscal
			foreach (var item in ListadoFacturas)
			{
				if (String.IsNullOrEmpty(item.DatosImpuesto.NroDocumento)) {
					ListErrores.Add($"El Documento: {item.taSopHdrIvcInsert.SOPNUMBE},No tiene información Fiscal.");
				}
				foreach (var detalle in item.taSopLineIvcInsert_Items)
				{
					listDetalles.Add(detalle);
				}
				string x = item.taSopHdrIvcInsert.SOPNUMBE;
			}
			//valida el stock por articulo alamacen.
			List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert> listResumen = listDetalles.Where(g => g.QUANTITY > 0)
										 .GroupBy(s => new { s.ITEMNMBR, s.LOCNCODE })
										 .Select(r => new taSopLineIvcInsert_ItemsTaSopLineIvcInsert
										 {
											 ITEMNMBR = r.Key.ITEMNMBR,
											 LOCNCODE = r.Key.LOCNCODE,
											 QUANTITY = r.Sum(d => d.QUANTITY)
										 }).ToList();
			foreach (var articulos in listResumen)
			{
				decimal Disponible = controllerProductivo.ValidarStock(articulos.ITEMNMBR, articulos.LOCNCODE);
				if (articulos.QUANTITY>Disponible) {
					ListErrores.Add($"El Articulo: {articulos.ITEMNMBR},No tiene stock Suficiente. Actual: {Disponible}, Por Integrar:{articulos.QUANTITY}");
				}
			}
			return ListErrores;
		}

		private void chkFecha_CheckedChanged(object sender, EventArgs e)
		{				
			dtFechaDesde.Enabled = chkFecha.Checked;
			dtFechaHasta.Enabled = chkFecha.Checked;
		}

		private void chkDocumento_CheckedChanged(object sender, EventArgs e)
		{
			txtDocDesde.Enabled = chkDocumento.Checked;
			txtDocHasta.Enabled = chkDocumento.Checked;
		}
	}
}
