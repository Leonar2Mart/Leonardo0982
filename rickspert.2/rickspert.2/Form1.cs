using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rickspert._2
{
    public partial class Form1 : Form
    {

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        public Form1()
        {
            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String analista = textAnalista.Text;
            String riesgo = textRiesgo.Text;
            String dano = textDano.Text;


            int rowIndex = dataGridView1.Rows.Add();
            
            dataGridView1.Rows[rowIndex].Cells["ID"].Value = rowIndex+1;
            dataGridView1.Rows[rowIndex].Cells["Analista"].Value = analista;
            dataGridView1.Rows[rowIndex].Cells["Riesgo"].Value = riesgo;
            dataGridView1.Rows[rowIndex].Cells["Daño"].Value = dano;


            textAnalista.Text = "";
            textRiesgo.Text = "";
            textDano.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
