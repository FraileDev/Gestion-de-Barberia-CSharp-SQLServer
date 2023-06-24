using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberH.clases;
using BarberH.CRUDs;
using BarberH.conexion;

namespace BarberH
{
    public partial class FormCliente : Form
    {
        FormRegistro Form;

        private readonly FormCliente _parent;
       

        public FormCliente()
        {
            InitializeComponent();
            Form = new FormRegistro(this);
        }

        public void Display()
        {
            CRUDcliente.BuscarCliente("SELECT id_cliente, barbero, nombre, servicio, temperatura, telefono, fecha FROM cliente", dataGridView1);
        }

        

        private void FormCliente_Shown(object sender, EventArgs e)
        {
            Display();
        }


        private void btNew_Click(object sender, EventArgs e)
        {

            //FormRegistro form = new FormRegistro(this);
            Form.Clear();
            Form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CRUDcliente.BuscarCliente("SELECT id_cliente, barbero, nombre, servicio, temperatura, telefono, fecha FROM cliente WHERE fecha LIKE'%"+ txtSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                Form.Clear();
                Form.id_cliente = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Form.barbero = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Form.nombre = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Form.servicio = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Form.temperatura = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                Form.telefono = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Form.fecha = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                Form.ActualizarInfo();
                string cliente = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string telefono = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Form.nomCli(cliente, telefono);
                Form.ShowDialog(); 
                return;
            }

            if (e.ColumnIndex == 1)
            {
                //eliminar
                if (MessageBox.Show("Desea eliminar la siguiente informacion?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CRUDcliente.EliminarClientee(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.ShowDialog();
        }
    }
}
