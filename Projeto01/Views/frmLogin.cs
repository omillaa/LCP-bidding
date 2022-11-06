using Projeto01.Model;
using Projeto01.Repositórios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Instancia dos forms
        frmPrincipal frmPrin = new frmPrincipal();
        RepUserManager ru = new RepUserManager();

        private void button1_Click(object sender, EventArgs e)
        {
            //UserManager User = ru.Get(txtLoginEmail.Text, txtLoginSenha.Text);
            //if (User != null)
           // {
               // frmPrin.lbUsuario.Text = User.Nome;
                frmPrin.ShowDialog();

           // }
           // else
              //  lbAlert.Visible = true;


        }

        private void btnChamaCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.SelectedTab = tabCadastro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChamaLogin_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl.SelectedTab = tabLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
