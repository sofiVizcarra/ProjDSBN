﻿using System;
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
    public partial class Frm_Ingreso_Producto_Almacen : Form
    {
        string codigoingreso;
        Frm_Home_Omega Local_contene;
        //NuevoContrato nc;
        BDPrincipal Link_BD = new BDPrincipal();
        bool found = false;
        public Frm_Ingreso_Producto_Almacen()
        {
            InitializeComponent();
        }

        public Frm_Ingreso_Producto_Almacen(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Local_contene = Refconten;
        }
        private void btn_buscar_produc_IPA_Click(object sender, EventArgs e)
        {
            Frm_Tabla_Productos buscarcliente = new Frm_Tabla_Productos();
            buscarcliente.setUpline(2, this);
            buscarcliente.ShowDialog();
        }

        private void IngresoProductoAlmacen_Load(object sender, EventArgs e)
        {
            codigoingreso= BDPrincipal.CompletarCeros4(BDPrincipal.LastRegistro("APSCod", "alm_prod_stock"));
            comboBox_almacen.DataSource = BDPrincipal.cmbAlmacen();
            comboBox_almacen.DisplayMember = "AlmNombre";
            comboBox_almacen.ValueMember = "AlmCod";

        }

        public void LoadbyTxtCodigo(string codigo)
        {
            DataTable dt = BDPrincipal.Busq_AllinCadena("ProCod",codigo,"productos");
            txt_codprod.Text = codigo;
            txt_nomprod.Text = dt.Rows[0][1].ToString();
        }

        private void btn_limpiarIPA_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            txt_codprod.Clear();
            txt_nomprod.Clear();
            txt_cant.Clear();
            lblstockactual.Text = "Stock Actual:";
        }

        private void btn_grabarIPA_Click(object sender, EventArgs e)
        {
            if (found == false)
            {
                BDPrincipal.IngresoHistoricoInAlm(codigoingreso, comboBox_almacen.SelectedValue.ToString(), txt_codprod.Text, txt_cant.Text,DateTime.Now.Date.ToString(), Link_BD.get_CampoUsu("UsuCod"));
                BDPrincipal.IngresoStock(codigoingreso, comboBox_almacen.SelectedValue.ToString(), txt_codprod.Text, txt_cant.Text, Link_BD.get_CampoUsu("UsuCod"));
                Limpiar();
            }
            if (found == true)
            {
                BDPrincipal.IngresoHistoricoInAlm(codigoingreso, comboBox_almacen.SelectedValue.ToString(), txt_codprod.Text, txt_cant.Text, DateTime.Now.Date.ToString(), Link_BD.get_CampoUsu("UsuCod"));
                BDPrincipal.UpdateStock(comboBox_almacen.SelectedValue.ToString(), txt_codprod.Text, Int32.Parse(txt_cant.Text), Link_BD.get_CampoUsu("UsuCod"), "agregar");
                Limpiar();
            }
        }

        private void txt_codprod_TextChanged(object sender, EventArgs e)
        {
            int cantidadactual = BDPrincipal.GetStockProducto(comboBox_almacen.SelectedValue.ToString(), txt_codprod.Text);
            if (cantidadactual == -1)
            {
                found = false;
            }
            else
            {
                found = true;
                lblstockactual.Text = "Stock Actual:"+cantidadactual.ToString();
            }
        }
    }
}
