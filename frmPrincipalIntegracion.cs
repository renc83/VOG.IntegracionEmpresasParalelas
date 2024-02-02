using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.Controller;

namespace VOG.IntegracionEmpresasParalelas
{
	public partial class frmPrincipalIntegracion : Form
	{
		public frmPrincipalIntegracion()
		{
			InitializeComponent();
		}

		private void frmInterfazIntegracion_Load(object sender, EventArgs e)
		{
			abreJson();
            this.CenterToScreen();
            lblPC.Text = Environment.MachineName.ToString().ToUpper();
            lblusuario.Text = SystemInformation.UserName.ToString().ToUpper();
            ListarEmpresas();
            lblVersion.Text=$"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
        }

        internal void abreJson()
        {
            clsDataJson data = (clsDataJson)null;
            string RutaJson = Environment.CurrentDirectory + "\\appconfig.json";

            if (!File.Exists(RutaJson))
            {
                Console.WriteLine("Falta Archivo de Configuracion");
            }
            else
            {
                try
                {
                    data = JsonConvert.DeserializeObject<clsDataJson>(File.ReadAllText(RutaJson));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error de Inicialización JSON.{ex.Message}");
                }
            }
            clsServerConection conexionproductivo = new clsServerConection();            
            //cambia segun la empresa destino
            sysGlobales.conexionproductivo = conexionproductivo; //data.ServerName;
            sysGlobales.conexionproductivo.ServerName = data.ServerName;
            sysGlobales.conexionproductivo.DatabaseName = data.DatabaseName;
            sysGlobales.conexionproductivo.UsuarioID = data.UsuarioID;
            sysGlobales.conexionproductivo.Password = data.Password;
            //conexion donde se crea la tabla de conexiones.
            clsServerConection conexionprincipal = new clsServerConection();
            sysGlobales.conexionprincipal = conexionprincipal; //data.ServerName;
            sysGlobales.conexionprincipal.ServerName = data.ServerName;
            sysGlobales.conexionprincipal.DatabaseName = data.DatabaseName;
            sysGlobales.conexionprincipal.UsuarioID = data.UsuarioID;
            sysGlobales.conexionprincipal.Password = data.Password;
        }

        internal void ListarEmpresas() {
            cCompanyParalela Companias = new cCompanyParalela();
            List<eCompanyParalela> ListParalelas = new List<eCompanyParalela>();
            ListParalelas = Companias.ListarEmpresasParalelas();
            LlenarGrid(ListParalelas);
        }

        internal void LlenarGrid(List<eCompanyParalela> ListParalelas) {
            dtEmpresas.Rows.Clear();
            if (ListParalelas.Count == 0)
            {
                MessageBox.Show("Archivo Vacio");
            }
            else
            {
                foreach (eCompanyParalela linea in ListParalelas)
                {
                    dtEmpresas.Rows.Add();
                    int fila = dtEmpresas.Rows.Count - 1;
                    clsServerConection conexion = SeparaConexion(linea.Conexion);
                    dtEmpresas[0, fila].Value = linea.ROW_ID.ToString();
                    dtEmpresas[1, fila].Value = conexion.ServerName;
                    dtEmpresas[2, fila].Value = conexion.DatabaseName;
                    dtEmpresas[3, fila].Value = sysGlobales.conexionproductivo.ServerName;
                    dtEmpresas[4, fila].Value = linea.BDDestino; //sysGlobales.conexionproductivo.DatabaseName;
                    dtEmpresas[5, fila].Value = "►";
                }
            }
        }

        internal clsServerConection SeparaConexion(string strConexion) {
            clsServerConection conexion = new clsServerConection();
            conexion = JsonConvert.DeserializeObject<clsServerConection>(strConexion);
            return conexion;
        }

		private void btnAgregar_Click(object sender, EventArgs e)
		{
            frmConfParalelas paralelas = new frmConfParalelas();
            paralelas.ShowDialog();
            ListarEmpresas();
        }

		private void btnSalir_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void dtEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.ColumnIndex == 5) //ESTADO
            {
                if (dtEmpresas.Rows.Count != e.RowIndex)
                {
                    int row_id = Convert.ToInt32(dtEmpresas[0, e.RowIndex].Value.ToString());
                    frmProcesaIntegracion procesador = new frmProcesaIntegracion(row_id);
                    procesador.ShowDialog();
                }
            }
        }

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void frmPrincipalIntegracion_Enter(object sender, EventArgs e)
		{

        }
	}
}
