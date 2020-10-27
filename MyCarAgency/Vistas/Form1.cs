using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UserModel usuarios = new UserModel();
            usuarios.AltaUsuario(txtLoginUser.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text), txtRole.Text);
        }
    }
}
