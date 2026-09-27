using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.CodeDom;


namespace taller_de_moto
{
    

    public partial class CLIENTE : Form
    {
       
        Turnos enviar = new Turnos();//opcion de envio datos para registro de motos(motos)
         

         public string num;
         string pos;
       
       



        public CLIENTE()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          



        }


        private void btnguardar_Click(object sender, EventArgs e)

        {
            string codigo;
            string num;
            string telefono;
       
            codigo = txtcodigo.Text;
            num = txtnombre.Text;
            telefono = txttelefono.Text;
           



            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(DataGridView1);
            file.Cells[0].Value = txtcodigo.Text;
            file.Cells[1].Value = txtnombre.Text;
            file.Cells[2].Value = txttelefono.Text;

            DataGridView1.Rows.Add(file);
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
         

            pos = pos + 1;
            MessageBox.Show("Registro exitosomente");

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea eliminar cliente", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow);
                }
            }

            catch
            {












            }
        }

        

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea Modificar", "Modicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridView1.BeginEdit(true);


                }
            }
            catch {
            
            
            }

       ;

          }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncarnet_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "1" + pos;
        }

        private void btnbuscar_Click(object sender, EventArgs e)

        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtyoyo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lBLCODIGO_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
