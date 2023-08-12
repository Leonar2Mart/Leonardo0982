using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rickspert._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PasarDatosDeDataGridView();
        }

        private void PasarDatosDeDataGridView()
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            if (form1 != null)
            {
                DataGridView DataGridView1 = form1.DataGridView1;

                if (form1.DataGridView1.Rows.Count > 0)
                {
                    // Limpiar el DataGridView de destino (si es necesario)
                    dataGridViewF.Rows.Clear();

                    // Recorrer las filas del DataGridView de origen y agregarlas al DataGridView de destino
                    foreach (DataGridViewRow fila in DataGridView1.Rows)
                    {
                        // Verificar si la fila no es una fila nueva (fila de edición)
                        if (!fila.IsNewRow)
                        {
                            // Obtener los valores de cada celda de la fila
                            string ID = fila.Cells["ID"].Value.ToString();
                            string Archivo = ""; //fila.Cells["Archivo"].Value.ToString();
                            string Analista = fila.Cells["Analista"].Value.ToString();
                            string Riesgo = fila.Cells["Riesgo"].Value.ToString();
                            string Dano = fila.Cells["Daño"].Value.ToString();

                            // Agregar una nueva fila al DataGridView de destino con los valores obtenidos
                            dataGridViewF.Rows.Add(ID, Archivo, Analista, Riesgo, Dano);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (dataGridViewF.CurrentRow != null && dataGridViewF.CurrentCell != null)
            {
                int rowIndex = dataGridViewF.CurrentCell.RowIndex;
                int columnIndex = dataGridViewF.CurrentCell.ColumnIndex;

                DataGridViewCell cell = dataGridViewF.Rows[rowIndex].Cells[columnIndex];

                // Cambiar el color de fondo de la celda
                cell.Style.BackColor = Color.LightGreen;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dataGridViewF.CurrentRow != null && dataGridViewF.CurrentCell != null)
            {
                int rowIndex = dataGridViewF.CurrentCell.RowIndex;
                int columnIndex = dataGridViewF.CurrentCell.ColumnIndex;

                DataGridViewCell cell = dataGridViewF.Rows[rowIndex].Cells[columnIndex];

                // Cambiar el color de fondo de la celda
                cell.Style.BackColor = Color.LimeGreen;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dataGridViewF.CurrentRow != null && dataGridViewF.CurrentCell != null)
            {
                int rowIndex = dataGridViewF.CurrentCell.RowIndex;
                int columnIndex = dataGridViewF.CurrentCell.ColumnIndex;

                DataGridViewCell cell = dataGridViewF.Rows[rowIndex].Cells[columnIndex];

                // Cambiar el color de fondo de la celda
                cell.Style.BackColor = Color.Gold;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (dataGridViewF.CurrentRow != null && dataGridViewF.CurrentCell != null)
            {
                int rowIndex = dataGridViewF.CurrentCell.RowIndex;
                int columnIndex = dataGridViewF.CurrentCell.ColumnIndex;

                DataGridViewCell cell = dataGridViewF.Rows[rowIndex].Cells[columnIndex];

                // Cambiar el color de fondo de la celda
                cell.Style.BackColor = Color.Orange;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (dataGridViewF.CurrentRow != null && dataGridViewF.CurrentCell != null)
            {
                int rowIndex = dataGridViewF.CurrentCell.RowIndex;
                int columnIndex = dataGridViewF.CurrentCell.ColumnIndex;

                DataGridViewCell cell = dataGridViewF.Rows[rowIndex].Cells[columnIndex];

                // Cambiar el color de fondo de la celda
                cell.Style.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}