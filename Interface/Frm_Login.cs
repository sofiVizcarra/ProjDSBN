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
    public partial class Frm_Login : Form
    {
        //BDPrincipal Link_BD = new BDPrincipal();
        int f = 0;
        public Frm_Login()
        {
            BDPrincipal.carga();
            InitializeComponent();
        }
        private void LoginBTN()
        {
            f = 0;
            if (textBnombre.Text == "" || txtpass.Text == "")
            {
                lbl_status1.Text = "Complete los campos";
                f = 1;// si no ingresamos algun dato entonces no nos permitira continuar entonces tenemos q ingresar todos los datos
            }
            if (f == 0)
            {
                string observer = BDPrincipal.Login(textBnombre.Text, txtpass.Text);
                switch (observer)
                {
                    case "Usuario no existe":
                        {
                            lbl_status1.Text = "Usuario no existe";
                            break;
                        }
                    case "Pass incorrecto":
                        {
                            lbl_status1.Text = "Pass incorrecto";
                            break;
                        }
                    case "OK":
                        {

                            Frm_Home_Omega A = new Frm_Home_Omega(BDPrincipal.get_CampoUsu("UsuNom"),this);
                            A.Show();
                            txtpass.Text = "";
                            this.Hide();
                            lbl_status1.Text = "";
                            break;
                        }
                    case "":
                        {
                            lbl_status1.Text = "Error BD";
                            break;
                        }

                }
            }
        }

        private void textBnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBTN();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginBTN();
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            this.LoginBTN();
        }
    }
    
}
