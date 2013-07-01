using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Frm_Home_Omega : Form
    {
        Frm_Login login;
        Frm_Mantenimiento_Clientes mant_cli;
        Frm_Boleta_Principal NuevaBoleta;
        Frm_Factura_Principal NuevaFactura;
        Frm_Tabla_Clientes tablacli;
        Frm_Mantenimiento_Productos mant_pro;
        Frm_Tabla_Productos tablapro;
        Frm_Ingreso_Producto_Almacen ingresoalmacen_obj;
        Frm_Maestro_Proveedores NProveedor;
        public Frm_Home_Omega(string nombre, Frm_Login log)
        {
            InitializeComponent();
            lbl_nombre.Text = "Bienvenido: " + nombre;
            login = log;
           
            //menurapido = new MenuAccesoRapido(this);
            /*tablapro = new TablaProductos(this);
            mant_pro = new MantenimientoProductos(this);
            tablacli = new TablaClientes(this);
            NuevaBoleta = new BoletaPrincipal(this);
            mant_cli = new MantenimientoCliente(this);*/
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cambiar_Contraseña nPass = new Frm_Cambiar_Contraseña();
            nPass.ShowDialog();

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
            this.Dispose();
        }

        private void Frm_HomeOmega_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void Frm_HomeOmega_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro de Cerrar su Sesion?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void MenuProductosnuevo_Click(object sender, EventArgs e)
        {
            mant_pro = new Frm_Mantenimiento_Productos(this);
            mant_pro.MdiParent = this;
            mant_pro.Show();
        }

        private void menutablaproductos_Click(object sender, EventArgs e)
        {
            tablapro = new Frm_Tabla_Productos(this);
            tablapro.ShowDialog();
        }

        private void ingresoAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresoalmacen_obj = new Frm_Ingreso_Producto_Almacen(this);
            ingresoalmacen_obj.MdiParent = this;
            ingresoalmacen_obj.Show();
        }

        private void MenuClientesNuevo_Click(object sender, EventArgs e)
        {
            mant_cli = new Frm_Mantenimiento_Clientes(this);
            mant_cli.MdiParent = this;
            //a.LayoutMdi(MdiLayout.ArrangeIcons);
            mant_cli.Show();
        }

        private void MenuClientesTabla_Click(object sender, EventArgs e)
        {
            tablacli = new Frm_Tabla_Clientes(this);
            tablacli.ShowDialog();
        }

        private void MenuFacturaNuevo_Click(object sender, EventArgs e)
        {
            NuevaFactura = new Frm_Factura_Principal(this);
            NuevaFactura.MdiParent = this;
            NuevaFactura.Show();
        }

        private void MenuBoletaNuevo_Click(object sender, EventArgs e)
        {
            NuevaBoleta = new Frm_Boleta_Principal(this);
            NuevaBoleta.MdiParent = this;
            NuevaBoleta.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant_cli = new Frm_Mantenimiento_Clientes(this);
            mant_cli.MdiParent = this;
            //a.LayoutMdi(MdiLayout.ArrangeIcons);
            mant_cli.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mant_pro = new Frm_Mantenimiento_Productos(this);
            mant_pro.MdiParent = this;
            mant_pro.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NProveedor = new Frm_Maestro_Proveedores(this);
            NProveedor.MdiParent = this;
            NProveedor.Show();
        }






    }
}
