﻿using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class ProductosDA
    {

        readonly string cadena = "Server=localhost; Port=3306;Database=Ejercicio3;Uid=root;Pwd=madrid12;";
        MySqlConnection conn;
        MySqlCommand cmd;
        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();
            try
            {
                string sql = "SELECT * FROM producto";
                conn = new MySqlConnection(cadena);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

            }
            return lista;


        }

        public bool InsertarProducto(Producto producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@Codigo,@Precio,@Existencia,@Descripcion,@Imagen);";
                conn = new MySqlConnection(cadena);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
             
            }
            catch (Exception)
            {

            }
            return inserto;
        }


        public bool ModificarProducto(Producto producto)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE producto SET Codigo= @Codigo, Descripcion=@Descripcion, "+
                    "Precio=@Precio,Existencia=@Existencia, Imagen=@Imagen WHERE Codigo=@Codigo;";
                conn=new MySqlConnection(cadena);
                conn.Open();
                cmd=new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo",producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();

            }
            catch(Exception)
            {

            }
            return modifico;

        }

        public bool EliminarProducto(string codigo)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM producto WHERE Codigo=@Codigo;";
                conn = new MySqlConnection(cadena);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.ExecuteNonQuery();
                elimino = true;
                 conn.Close();

            }
            catch (Exception ex)
            {

            }
            return elimino;
        }

        public byte [] SeleccionarImagen(string codigo)
        {
            byte[] _imagen = new byte[0];
            try
            {
                string sql = "Select Imagen from producto WHERE Codigo=@Codigo;";
                conn = new MySqlConnection(cadena);
                conn.Open();
                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo",codigo);
             ;
                cmd.ExecuteNonQuery();
               MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _imagen = (byte[])reader["Imagen"];

                }
                conn.Close();




            }
            catch (Exception)
            {

               
            }
            return _imagen;
        }



}

}
