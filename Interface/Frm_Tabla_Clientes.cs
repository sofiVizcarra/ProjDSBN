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
    public partial class Frm_Tabla_Clientes : Form
    {
        BDPrincipal Link_BD = new BDPrincipal();
        static string busq = "";
        int flag = 0, upline = 0;
        //NuevoContrato nuevocontrato;
        Frm_Home_Omega Localcontene;
        Frm_Mantenimiento_Clientes MantenimientoCli;
        Frm_Boleta_Principal Nboleta;
        Frm_Factura_Principal NFactura;
        public Frm_Tabla_Clientes(Frm_Mantenimiento_Clientes disp)
        {
            InitializeComponent();
            MantenimientoCli = disp;
        }
        public Frm_Tabla_Clientes()
        {
            InitializeComponent();
        }
        public Frm_Tabla_Clientes(Frm_Home_Omega Refconten)
        {
            InitializeComponent();
            Localcontene = Refconten;
            MantenimientoCli = new Frm_Mantenimiento_Clientes(Localcontene);
            MantenimientoCli.MdiParent = Localcontene;
            MantenimientoCli.Show();
        }
        public void setUpline(int ln, Frm_Boleta_Principal NBoleta)
        {
            upline = ln;
            Nboleta = NBoleta;
        }
        public void setUpline(int ln, Frm_Factura_Principal Nfactura)
        {
            upline = ln;
            NFactura = Nfactura;
        }
        private void btn_selec_cli_Click(object sender, EventArgs e)
        {
            if (upline == 0)
            {
                if (dataGrid_CLIENTES.VisibleRowCount != 0)
                {
                    object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                    string codigo = selectedItem.ToString();
                    //codigo = dataTable.Rows[dataGrid_CLIENTES.CurrentRowIndex][0].ToString();
                    // DisplayCliente a = new DisplayCliente();
                    // a.MdiParent = contene;
                    // a.Show();
                    //this.Dispose();
                    MantenimientoCli.LoadbyTxtCodigo(codigo);
                    this.Close();
                    this.Dispose();
                }
            }
            //Llama nuevo boleta
            if (upline == 1)
            {
                object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                string codigo = selectedItem.ToString();
                Nboleta.Show();
                Nboleta.LoadbyTxtCodigo(codigo,"Clientes");
                this.Dispose();
                upline = 0;
            }
            //Llama nuevo factura
            if (upline == 2)
            {
                object selectedItem = dataGrid_CLIENTES[dataGrid_CLIENTES.CurrentCell.RowNumber, 0];
                string codigo = selectedItem.ToString();
                NFactura.Show();
                NFactura.LoadbyTxtCodigo(codigo,"Clientes");
                this.Dispose();
                upline = 0;
            }
        }

        private void TablaClientes_Load(object sender, EventArgs e)
        {
            dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaClienteBy("CliNom", "");
            cmb_busqtipo.SelectedIndex = 0;
        }

        private void cmb_busqtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_busqtipo.SelectedIndex)
            {
                case 0:
                    busq = "CliNom";
                    break;
                case 1:
                    busq = "CliRUC";
                    break;
                case 2:
                    busq = "CliDir";
                    break;
                case 3:
                    busq = "CliDepa";
                    break;
                case 4:
                    busq = "CliTelef";
                    break;
                case 5:
                    busq = "CliEmail";
                    break;
                case 6:
                    {
                        busq = "ACTIVI";
                        //dataTable = Link_BD.Busq_CadenaCliente("ACTIVI", "1");
                        dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaClienteBy("ACTIVI", "1");
                        flag = 1;
                        break;
                    }
                case 7:
                    {
                        //dataTable = Link_BD.Busq_CadenaCliente("ACTIVI", "0");
                        dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaClienteBy("ACTIVI", "0");
                        busq = "ACTIVI";
                        flag = 1;
                        break;
                    }
            }
            if (flag == 0)
            {
                //dataTable = Link_BD.BuscarCliente(busq);
                dataGrid_CLIENTES.DataSource = BDPrincipal.BuscarCliente(busq);
            }
            flag = 0;
        }

        private void txt_busqcli_TextChanged(object sender, EventArgs e)
        {
            if (cmb_busqtipo.SelectedIndex == 6)
                dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaActivi(txt_busqcli.Text, "1");
            else if (cmb_busqtipo.SelectedIndex == 7)
                dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaActivi(txt_busqcli.Text, "0");
            else
                dataGrid_CLIENTES.DataSource = BDPrincipal.Busq_CadenaClienteBy(busq, txt_busqcli.Text);
        }
    }
}
