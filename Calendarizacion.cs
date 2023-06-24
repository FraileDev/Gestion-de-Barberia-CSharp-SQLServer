using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberH.clases;
using BarberH.CRUDs;
using BarberH.conexion;

namespace BarberH
{
    public partial class Calendarizacion : Form
    {
        
        public Calendarizacion()
        {
            InitializeComponent();
            mostrarGrid();
        }
        public void mostrarGrid()
        {
            DataTable horarios = horarioCRUD.listar();
            DataTable actividades = actividadCRUD.listar();
            if (horarios == null && actividades == null)
            {
                MessageBox.Show("No se logró acceder a los datos de la base de datos");
            }
            else
            {
                dataGridView1.DataSource = horarios;
                dataGridView2.DataSource = actividades;
                Console.WriteLine("Datos consultados");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int celda = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[celda].Selected = true;
                DespliegueHorario f = new DespliegueHorario();
                f.horarioN = new horario(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                f.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //string fechaHorario = maskedTextBox1.Text;
            try
            {
                string fechaHorario = Convert.ToDateTime(maskedTextBox1.Text).ToString("yyyy-MM-dd");
                DB_Conexion conectar = new DB_Conexion();
                SqlCommand llenarDgv = new SqlCommand("Select * from dbo.horario where Fecha = '" + fechaHorario + "'", conectar.AbrirConexion());
                SqlDataAdapter da = new SqlDataAdapter(llenarDgv);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conectar.CerrarConexion();
            }
            catch (Exception)
            {

                MessageBox.Show("Inserte un dato valido");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fechaActividad = Convert.ToDateTime(maskedTextBox2.Text).ToString("yyyy-MM-dd");
            DB_Conexion conectar = new DB_Conexion();
            SqlCommand llenarDgv = new SqlCommand("Select * from dbo.actividad where Fecha = '" + fechaActividad + "'", conectar.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(llenarDgv);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conectar.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DespliegueHorario f = new DespliegueHorario();
            f.Visible = true;
            //this.Dispose(false);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            mostrarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int celda = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[celda].Selected = true;
                string fechaEli = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString()).ToString("yyyy-MM-dd");
                horarioCRUD.eliminar(dataGridView1.CurrentRow.Cells[0].Value.ToString(), fechaEli);
                mostrarGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DespliegueActividad2 f2 = new DespliegueActividad2();
            f2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int celda = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows[celda].Selected = true;
                DespliegueActividad2 f2 = new DespliegueActividad2();
                f2.actividadN = new actividad(dataGridView2.CurrentRow.Cells[0].Value.ToString(), dataGridView2.CurrentRow.Cells[1].Value.ToString(), dataGridView2.CurrentRow.Cells[2].Value.ToString(), Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value.ToString()));
                f2.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int celda = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows[celda].Selected = true;
                string fechaEli = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value.ToString()).ToString("yyyy-MM-dd");
                actividadCRUD.eliminar(dataGridView2.CurrentRow.Cells[0].Value.ToString(), dataGridView2.CurrentRow.Cells[1].Value.ToString(),  fechaEli);
                mostrarGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            mostrarGrid();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            mostrarGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.ShowDialog();
        }
    }
}
