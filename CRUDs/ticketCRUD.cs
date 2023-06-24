using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberH.clases;
using BarberH.conexion;


namespace BarberH.CRUDs
{
    class ticketCRUD
    {
        public static string ultimoTicket()
        {
            try
            {
                DB_Conexion con = new DB_Conexion();
                SqlCommand ultimoTicket = new SqlCommand("SELECT MAX(id_ticket) ult_ticket FROM dbo.ticket", con.AbrirConexion());
                string ulti = (ultimoTicket.ExecuteScalar()).ToString();
                con.CerrarConexion();
                return ulti;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static bool GuardarTicket(ticket e)
        {
            try
            {
                string totalFinal = Convert.ToString(e.total_final1).Replace(",", ".");
                string totalVenta = Convert.ToString(e.total_venta1).Replace(",", ".");
                string descuento = Convert.ToString(e.descuento1).Replace(",", ".");
                string recibido = Convert.ToString(e.recibido1).Replace(",", ".");
                string cambio = Convert.ToString(e.cambio1).Replace(",", ".");
                string fecha = e.fecha1.ToString("yyyy-MM-dd");
                string hora = e.fecha1.TimeOfDay.ToString();
                DB_Conexion con = new DB_Conexion();
                string sql = "INSERT INTO ticket VALUES ('" + e.id_ticket1 + "', '" + e.id_producto1 + "', '" + e.unitario1.Replace(",", ".") + "', '" + e.cantidadPP1 + "','" + e.totalPP1.Replace(",", ".") + "', '"+ fecha + "', '" + hora + "', '" + totalVenta + "', '" + descuento + "', '" + recibido + "', '" + cambio + "', '" + totalFinal + "')";
                SqlCommand comando = new SqlCommand(sql, con.AbrirConexion());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.CerrarConexion();
                    return true;
                }
                else
                {
                    con.CerrarConexion();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static double TotalVenta() //Solo funciona si existe almenos 1 valor total en la fecha actual, si es NULL dara error
                                          //Se pudiera arreglar al cambiar/reemplazar el valor NULL que da en la bdd a un valor 0
        {
            double vacio = 0;
            DB_Conexion con = new DB_Conexion();
            String query = "SELECT SUM(total_venta) AS 'Total de venta' FROM ticket where fecha = convert(varchar, getdate(), 23);";
            SqlCommand total = new SqlCommand(query, con.AbrirConexion());
            String sum_Ventas = (total.ExecuteScalar()).ToString();
            if (sum_Ventas != "") {
                double total_venta = Convert.ToDouble(total);
                con.CerrarConexion();
                return total_venta;
            }
            else
            {
                vacio = 0.1111;
                return vacio;
            }
            
           
        }

        public static double TotalDescuento()//Solo funciona si existe almenos 1 valor en la fecha actual, si es NULL dara error
                                             //Se pudiera arreglar al cambiar/reemplazar el valor NULL que da en la bdd a un valor 0
        {
            DB_Conexion con = new DB_Conexion();
            SqlCommand descuento = new SqlCommand("SELECT SUM(descuento) AS 'Descuento' FROM ticket where fecha = convert(varchar, getdate(), 23);", con.AbrirConexion());
            double total_descuento = Convert.ToDouble(descuento.ExecuteScalar());
            con.CerrarConexion();
            return total_descuento;
        }
    }
}
