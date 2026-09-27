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

    public partial class Turnos : Form
    {
        private string hora;
        public string phora {
            set{

                hora = value;
            }
            
        }

        servicio emisor = new servicio();




        string ve;
       
       

        public Turnos()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }




        private void cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthora.Text = "";
            cbocliente.Text = "";
            cbo_servicio.Text = "";
            cbo_profecional.Text = "";
            cboestado.Text = "";
            dTPfecha.Text = "";





        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           
            

          
        }

        private void btnerror_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea eliminar registro de motos", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    datagridturno.Rows.Remove(datagridturno.CurrentRow);
                }
            }

            catch
            {












            }
        }

        private void cbo_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void culsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void datagridmotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea Modificar", "Modicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    datagridturno.BeginEdit(true);


                }
            }
            catch
            {


            }
        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
