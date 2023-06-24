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
using System.Data.SqlClient;


namespace BarberH
{
    public partial class FormCajachica : Form
    {
        DB_Conexion db = new DB_Conexion();

        public FormCajachica()
        {
            InitializeComponent();
        }

        private void FormCajachica_Load(object sender, EventArgs e)
        {
            NombreBarbero();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            llenarGrid();
            IngresosTotalesPorCortes();
            OtrosIngresos();
            TotalIngresos();
            fechaDiaria();
            CajaInicial();


        }

        public void fechaDiaria()
        {
            try
            {
                string fecha = Convert.ToDateTime(maskedTextBox1.Text).ToString("yyyy-MM-dd");
                DB_Conexion conectar = new DB_Conexion();
                SqlCommand llenarDgv = new SqlCommand("SELECT id_barbero as 'ID del barbero', nombre_barbero as 'Nombre del barbero', tipo_servicio as 'Tipo de servicio', fecha as 'Fecha', precio as 'Precio' FROM servicio where Fecha = '" + fecha + "'", conectar.AbrirConexion());
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
        public void llenarGrid()
        {
            string fecha = maskedTextBox1.Text;
            DataTable datos = AgregarDatosServicio.listar(fecha);
            if (datos == null)
            {
                MessageBox.Show("No se logró acceder a los datos de la base de datos");
            }
            else
            {
                dataGridView1.DataSource = datos;
                Console.WriteLine("Datos consultados");
            }
        }
        public void NombreBarbero()
        {
            try
            {
                string query = "SELECT id_barbero, nombre FROM barbero;";
                SqlCommand mostrar = new SqlCommand(query, db.AbrirConexion());
                SqlDataReader reader = mostrar.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("nombre", typeof(string));
                dt.Load(reader);
                cboBarberos.DataSource = dt;
                cboBarberos.DisplayMember = "nombre";
                cboBarberos.ValueMember = "id_barbero";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Hide();
            men.ShowDialog();
        }

        private void IngresosTotalesPorCortes()
        {
            double totalVenta = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                totalVenta += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            textBox1.Text = totalVenta.ToString();
        }

        private void OtrosIngresos()
        {
            double otros_ingresos = ticketCRUD.TotalVenta();
            if (otros_ingresos == 0.1111)
            {
                textBox3.Text = "0";
            }
            else
            {
                textBox3.Text = otros_ingresos.ToString();
            }
        }

        private void CajaInicial() //Mantenimiento - ligada a Fondo general 
        {
            string cajaInicial = CajaDiariaCRUD.mostrar(maskedTextBox1.Text);
            textBox2.Text = cajaInicial;
        }

        private void TotalIngresos() //Ver detalles en tickerCRUD (NULL = ERROR)
        {
            
            textBox2.Text = "0";
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                decimal total_ingresos = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text);
                textBox4.Text = total_ingresos.ToString();
            }
            else
            {
                MessageBox.Show("Patron incorrecto");
            }
          
        }

        private void ComisionGeneral()
        {
            double ingresos_cortes = Convert.ToDouble(textBox1.Text);
            ingresos_cortes = Convert.ToDouble(ingresos_cortes * 0.50);
            textBox5.Text = ingresos_cortes.ToString();
        }

        private void Descuento() //Ver detalles en tickerCRUD (NULL = ERROR)
        {
            double descuentos = ticketCRUD.TotalDescuento();
            textBox7.Text = descuentos.ToString();
        }

        private void TotalEgresos()
        {
            double total_ingresos = Convert.ToDouble(textBox5.Text + textBox7.Text);
            textBox6.Text = total_ingresos.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComisionGeneral();
            //Descuento();
            //TotalEgresos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comision();
        }
        private void Comision()
        {
            try
            {
                string fecha = maskedTextBox1.Text;
                string query = "SELECT nombre_barbero, SUM(precio) * 0.50 AS 'Comision de barbero' FROM servicio where fecha = '" + fecha + "' GROUP BY nombre_barbero;";
                SqlCommand mostrar = new SqlCommand(query, db.AbrirConexion());
                SqlDataReader reader = mostrar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0) + "  -  " + "$" + reader.GetDouble(1));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
    }
}