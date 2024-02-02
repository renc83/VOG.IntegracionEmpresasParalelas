using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Controller;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas
{
	public partial class frmConfParalelas : Form
	{
        cCompanyParalela Companias = new cCompanyParalela();
		public frmConfParalelas()
		{
			InitializeComponent();
		}

		private void frmConfParalelas_Load(object sender, EventArgs e)
		{
            this.CenterToScreen();
            lblPC.Text = Environment.MachineName.ToString().ToUpper();
            lblusuario.Text = SystemInformation.UserName.ToString().ToUpper();
            CargarDatos();
            txtDescripcion.DataBindings.Add("Text", SourceComParalelas, "Descripcion");
            txtConexionGp.DataBindings.Add("Text", SourceComParalelas, "Conexion");
            txtEmail.DataBindings.Add("Text", SourceComParalelas, "Correo");
            txtID.DataBindings.Add("Text", SourceComParalelas, "ROW_ID");           
            txtBDDestino.DataBindings.Add("Text", SourceComParalelas, "BDDestino");
            lblVersion.Text = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
            txtServidorDestino.Text = sysGlobales.conexionprincipal.ServerName;
        }

        internal void CargarDatos()
        {
            List<eCompanyParalela> ListParalelas = Companias.ListarEmpresasParalelas();
            SourceComParalelas.DataSource = ListParalelas;
            SourceComParalelas.MoveFirst();
        }

        private void separarconexion()
        {
            //string[] separadasgp;
            if (txtConexionGp.Text.Length > 0)
            {
                clsServerConection sConexion = new clsServerConection();
                sConexion= JsonConvert.DeserializeObject<clsServerConection>(txtConexionGp.Text);
                txtServerGp.Text = sConexion.ServerName ;
                txtBDGp.Text = sConexion.DatabaseName;
                txtUsuarioGp.Text = sConexion.UsuarioID;
                txtPasswordGp.Text = sConexion.Password;  
            }
            else {
                txtServerGp.Text = "";
                txtBDGp.Text = "";
                txtUsuarioGp.Text = "";
                txtPasswordGp.Text = "";
            }
            txtPrueba.Text = "0";
            
        }

        private void unirconexion()
        {
            if (String.IsNullOrEmpty(txtServerGp.Text)
                 || String.IsNullOrEmpty(txtUsuarioGp.Text)
                 || String.IsNullOrEmpty(txtPasswordGp.Text)
                 || String.IsNullOrEmpty(txtBDGp.Text)
                 || String.IsNullOrEmpty(txtDescripcion.Text))
            {  }
            else
            {
                clsServerConection sConexion = new clsServerConection();
                sConexion.ServerName = txtServerGp.Text;
                sConexion.DatabaseName = txtBDGp.Text;
                sConexion.UsuarioID = txtUsuarioGp.Text;
                sConexion.Password = txtPasswordGp.Text;
                txtConexionGp.Text = JsonConvert.SerializeObject(sConexion);
            }
        }

        private int Validar()
        {
            int control = 0;
            if (String.IsNullOrEmpty(txtServerGp.Text) 
                 || String.IsNullOrEmpty(txtUsuarioGp.Text) 
                 || String.IsNullOrEmpty(txtPasswordGp.Text)
                 || String.IsNullOrEmpty(txtBDGp.Text)
                 || String.IsNullOrEmpty(txtDescripcion.Text))
            { control = 1; }

            if (txtPrueba.Text == "0") {
                MessageBox.Show("No se ha Validado la Conexion", "Integracion Empresas");
                control = 1;
            }
            return control;
        }

        private void LimpiarVentana() {
            txtDescripcion.Text = "";
            txtServerGp.Text = "";
            txtBDGp.Text = "";
            txtUsuarioGp.Text = "";
            txtPasswordGp.Text = "";
            txtConexionGp.Text = "";
            txtEmail.Text = "";
            txtPrueba.Text = "0";
            txtID.Text = "0";
            txtActiva.Text = "1";
            txtBDDestino.Text = "";
        }

		private void btnNuevo_Click(object sender, EventArgs e)
		{
            LimpiarVentana();
            eCompanyParalela registro = new eCompanyParalela();
            SourceComParalelas.Add(registro);
            SourceComParalelas.MoveLast();
            txtDescripcion.Focus();
            txtID.Text = "0";
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            int val = Validar();
            if (val == 0)
            {
                eCompanyParalela paralela = new eCompanyParalela();
                paralela.Descripcion = txtDescripcion.Text;
                paralela.Conexion = txtConexionGp.Text;
                paralela.Correo = txtEmail.Text;
                paralela.BDDestino = txtBDDestino.Text;
                paralela.Usuario = lblusuario.Text;
                paralela.ROW_ID = txtID.Text;
                respuesta =Companias.GuardaEmpresaParalela(paralela);
                MessageBox.Show(respuesta.sMensaje, "Integracion Empresas");
                CargarDatos();
            }
            else {
                MessageBox.Show("Error: Faltan Datos.", "Integracion Empresas");
            }
		}

		private void txtConexionGp_TextChanged(object sender, EventArgs e)
		{
            separarconexion();
		}
	

		private void btnEliminar_Click(object sender, EventArgs e)
		{
            if (!String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                DialogResult result = MessageBox.Show("Desea Eliminar al Registro: " + txtDescripcion.Text + " ?", "Suminox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    clsMsjRespuesta respuesta = new clsMsjRespuesta();
                    respuesta = Companias.EliminaEmpresaParalela(Convert.ToInt32(txtID.Text));
                    CargarDatos();
                    MessageBox.Show(respuesta.sMensaje);
                }
            }
        }

		private void btnProbarConexion_Click(object sender, EventArgs e)
		{
            unirconexion();
            clsServerConection DatosConexion = new clsServerConection();
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            DatosConexion.ServerName = txtServerGp.Text;
            DatosConexion.DatabaseName = txtBDGp.Text;
            DatosConexion.UsuarioID = txtUsuarioGp.Text;
            DatosConexion.Password = txtPasswordGp.Text;
            respuesta = Companias.ValidaConexion(DatosConexion);
            MessageBox.Show(respuesta.sMensaje);
            txtPrueba.Text = respuesta.sError == 0 ? "1" : "1";
        }


		private void txtServerGp_Validated(object sender, EventArgs e)
		{
            unirconexion();
        }

		private void txtBDGp_Validated(object sender, EventArgs e)
		{
            unirconexion();
        }

		private void txtUsuarioGp_Validated(object sender, EventArgs e)
		{
            unirconexion();
        }

		private void txtPasswordGp_Validated(object sender, EventArgs e)
		{
            unirconexion();
        }

		private void btnSalir_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
