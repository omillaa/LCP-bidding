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
        frmPrincipal frmPrincipal = null;

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal = new frmPrincipal();
            frmPrincipal.lbUsuario.Text = txtEmail.Text;
            frmPrincipal.Show();

        }
    }
}
