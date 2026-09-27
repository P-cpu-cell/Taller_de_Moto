using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_de_moto
{
    public partial class Menu : Form
    {   //VARIABLE PUBLICA
       

        public Menu()
        {
            InitializeComponent();
            
        }
      

        private void usToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            CLIENTE form = new CLIENTE();
            form.ShowDialog();
        }

       

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnanterior_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Turnos form = new Turnos();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PROFECIONAL from = new PROFECIONAL();
            from.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ESPECIALIDAD from = new ESPECIALIDAD();
            from.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            servicio from = new servicio();
            from.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MATERIALES from = new MATERIALES();
            from.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PAGOS from = new PAGOS();
            from.ShowDialog();
        }
    }
}
