﻿using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Tienda
    {
        public static List<Tienda> ObtenerTiendas()
        {
            List<Tienda> rptListaUsuario = new List<Tienda>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerTienda", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaUsuario.Add(new Tienda()
                        {
                            IdTienda = Convert.ToInt32(dr["IdTienda"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            NIT = dr["NIT"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Activo = Convert.ToBoolean(dr["Activo"].ToString())

                        });
                    }
                    dr.Close();

                    return rptListaUsuario;

                }
                catch (Exception)
                {
                    rptListaUsuario = null;
                    return rptListaUsuario;
                }
            }
        }

        public static bool RegistrarTienda(Tienda oTienda)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarTienda", oConexion);
                    cmd.Parameters.AddWithValue("Nombre", oTienda.Nombre);
                    cmd.Parameters.AddWithValue("Nit", oTienda.NIT);
                    cmd.Parameters.AddWithValue("Direccion", oTienda.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", oTienda.Telefono);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }


        public static bool ModificarTienda(Tienda oTienda)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_ModificarTienda", oConexion);
                    cmd.Parameters.AddWithValue("IdTienda", oTienda.IdTienda);
                    cmd.Parameters.AddWithValue("Nombre", oTienda.Nombre);
                    cmd.Parameters.AddWithValue("Nit", oTienda.NIT);
                    cmd.Parameters.AddWithValue("Direccion", oTienda.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", oTienda.Telefono);
                    cmd.Parameters.AddWithValue("Activo", oTienda.Activo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public static bool EliminarTienda(int IdTienda)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_EliminarTienda", oConexion);
                    cmd.Parameters.AddWithValue("IdTienda", IdTienda);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }
    }
}
