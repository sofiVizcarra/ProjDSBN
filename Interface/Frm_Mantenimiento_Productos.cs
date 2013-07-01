using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataServices;

namespace Interface
{
    public partial class Frm_Mantenimiento_Productos : Form
    {
        OpenFileDialog openDlg = new OpenFileDialog();
        public Frm_Mantenimiento_Productos()
        {
            InitializeComponent();
        }
        BDPrincipal Link_BD = new BDPrincipal();
        Frm_Home_Omega Local_contene;
        public Frm_Mantenimiento_Productos(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Local_contene = Refconten;
        }
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            cmbmarca.DataSource = BDPrincipal.MostrarMarca();
            cmbmarca.DisplayMember = "NomMarcas";
            cmbmarca.SelectedIndex = 0;
            cmbmarca.ValueMember = "CodMarca";
            cmbmodelo.DataSource = BDPrincipal.Buscar_Marca(cmbmarca.SelectedValue.ToString());
            cmbmodelo.DisplayMember = "NomModel";
            cmbmodelo.ValueMember = "CodModel";
            txtcod.Text = BDPrincipal.CompletarCeros4(BDPrincipal.LastRegistro("ProCod", "productos"));
        }
        private void btn_busq_cod_Click(object sender, EventArgs e)
        {
            Frm_Tabla_Productos buscarcliente = new Frm_Tabla_Productos();
            buscarcliente.setUpline(0,this);
            buscarcliente.ShowDialog();
        }
        
        private void Limpiar()
        {
            txtcod.Text = BDPrincipal.CompletarCeros4(BDPrincipal.LastRegistro("ProCod", "productos"));
            txtprecio.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
         
            txtunidad.Text = "";
        }
        private void SetBontonesDefault()
        {
            btn_modificarCli.Visible = false;
            btnGrabar.Visible = true;
            btn_atras.Visible = false;
            txtcod.Enabled = true;
            btnClear.Visible = true;
        }
        public void LoadbyTxtCodigo(string codigo)
        {
            txtcod.Text = codigo;
            this.BuscarCodigo();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string modelo = cmbmodelo.SelectedValue.ToString();
            string marca = cmbmarca.SelectedValue.ToString();
            if (txtcod.Text == BDPrincipal.CompletarCeros4(BDPrincipal.LastRegistro("ProCod", "productos")))
            {
                if (BDPrincipal.DisponibleProducto(txtNombre.Text) == true)
                {
                    BDPrincipal.RegistrarProducto(txtcod.Text, txtNombre.Text, txtunidad.Text, txtCosto.Text, txtprecio.Text, txtigv.Text, marca, modelo, openDlg.FileName.Replace("\\", "\\\\"));
                    Limpiar();
                    SetBontonesDefault();
                }
            }
            else
            {
                MessageBox.Show("No modifique el codigo.");
                txtcod.Text = BDPrincipal.CompletarCeros4(BDPrincipal.LastRegistro("ProCod", "productos"));
            }

        }
        private void btn_modificarCli_Click(object sender, EventArgs e)
        {
            string modelo = cmbmodelo.SelectedValue.ToString();
            string marca = cmbmarca.SelectedValue.ToString();
            if (txtcod.Text != "")
            {
                BDPrincipal.UpdateProducto(txtcod.Text, txtNombre.Text, txtunidad.Text, txtCosto.Text, txtprecio.Text, txtigv.Text, marca, modelo, openDlg.FileName.Replace("\\", "\\\\"));
                Limpiar();
                SetBontonesDefault();
            }
            else
            {
                MessageBox.Show("Verifique el Codigo");
            }
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            Limpiar();
            SetBontonesDefault();
        }
        //Metodos Codigo interno
        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
            btn_modificarCli.Visible = false;
            btnGrabar.Visible = true;
            btn_atras.Visible = false;

        }
        private void BuscarCodigo()
        {

            DataTable dt = BDPrincipal.Busq_AllinCadena("ProCod", txtcod.Text.ToString(), "productos");
            if (dt.Rows.Count != 0)
            {
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtunidad.Text = dt.Rows[0][2].ToString();
                cmbmarca.SelectedValue = dt.Rows[0][6].ToString();
                cmbmodelo.SelectedValue = dt.Rows[0][7].ToString();
                txtCosto.Text = dt.Rows[0][3].ToString();
                txtprecio.Text = dt.Rows[0][4].ToString();
                MessageBox.Show("BD: "+dt.Rows[0][8].ToString());
                pictureBox1.ImageLocation = dt.Rows[0][8].ToString();
                if (txtNombre.Text != "")
                {
                    btn_modificarCli.Visible = true;
                    btnGrabar.Visible = false;
                    btnClear.Visible = false;
                    btn_atras.Visible = true;
                    txtcod.Enabled = false;
                }
            }
            else
                MessageBox.Show("Codigo no encontrado");    
        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BuscarCodigo();
            }
        }

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            //openDlg.Filter = "Archivos de imagen(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)";
            openDlg.Filter = "Archivos de Imagen|*.jpg";
            openDlg.Title = "Abrir los archivos Bmp";
            if (openDlg.ShowDialog() == DialogResult.OK) {
                MessageBox.Show(openDlg.FileName);
                pictureBox1.ImageLocation = openDlg.FileName;
            }

        }

        private void cmbmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmarca.SelectedValue != null)
            {
                cmbmodelo.DataSource = BDPrincipal.Buscar_Marca(cmbmarca.SelectedValue.ToString());
                cmbmodelo.DisplayMember = "NomModel";
                cmbmodelo.ValueMember = "CodModel";
            }
        }
    }
}
