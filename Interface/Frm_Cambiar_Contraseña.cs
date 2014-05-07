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
    public partial class Frm_Cambiar_Contraseña : Form
    {
        public Frm_Cambiar_Contraseña()
        {
            InitializeComponent();
        }
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string passact = BDPrincipal.get_CampoUsu("UsuPass");
            if (txt_passACT.Text == passact)
            {
                if (txt_npassRE.Text == txt_npass.Text)
                {
                    BDPrincipal.UpdatePassword(txt_npass.Text);
                    this.Close();
                    this.Dispose();
                }
                else
                    lbl_status1.Text = "No coinciden caracteres..";
            }
            else
            {
                lbl_status1.Text = "Contraseña Incorrecta.";
            }
        }
    }
}
