using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDeDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista =new List<Usuario>();
            using (SqlConnection conexion=new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    string query = "Select ID_Usuario,Documento,NombreCompleto,Correo,Clave,Estado From Usuario";
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.CommandType = CommandType.Text;
                    
                    conexion.Open();
                    using(SqlDataReader reader= command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
                                Documento = reader["Documento"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            });
                        }
                    }

                }catch(Exception ex)
                {
                    lista=new List<Usuario>();
                }

            }
            return lista;
        }

    }
}
