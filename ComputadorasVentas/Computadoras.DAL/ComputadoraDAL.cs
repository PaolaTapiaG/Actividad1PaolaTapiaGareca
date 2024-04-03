using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadoras.MODELOS;

namespace Computadoras.DAL
{
    public class ComputadoraDAL
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from Computadoras";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarComputadoraDal(Computador computadora)
        {
            string consulta = "insert into Computadoras values('" + computadora.Nombre + "'," +
                                                         "'" + computadora.Descripcion + "'," +
                                                         "" + computadora.Precio + "," +
                                                         "'" + computadora.FechaFabricacion + "' )";
            conexion.Ejecutar(consulta);
        }
        Computador c = new Computador();
        public Computador ObtenerComputadoraIdDal(int id)
        {
            string consulta = "select * from Computadoras where id=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "table");
            if (tabla.Rows.Count > 0)
            {
                c.ID = Convert.ToInt32(tabla.Rows[0]["id"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                c.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                c.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafabricacion"]);

            }
            return c;
        }
        public void EditarComputadoraDal(Computador c)
        {
            string consulta = "update Computadoras set nombre='" + c.Nombre + "'," +
                                                        "descripcion='" + c.Descripcion + "'," +
                                                        "precio=" + c.Precio + "," +
                                                        "fechafabricacion='" + c.FechaFabricacion + "' " +
                                                "where id=" + c.ID;
            conexion.Ejecutar(consulta);
        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from Computadoras where id=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
