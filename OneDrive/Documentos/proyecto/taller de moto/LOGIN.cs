using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_de_moto
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            string programa;
            programa = txtusuario.Text;
            string password;
            password = txtclave.Text;
            if (programa.Equals("Sala") & password.Equals("1234"))
              {
               

                this.Hide();
                Menu form = new Menu();
                form.ShowDialog();
                
            }
            else {
                MessageBox.Show("Los datos no estan corecto,intenta nuevamente","Titulo",MessageBoxButtons.OK);
            
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
