using Capa_de_negocio.Data.Models;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Capa_de_negocio.Data
{
	public class clsLnChofer
	{


		public void Cargar(ref clsBeChofer oBeChofer, DataRow dr)
		{
			try
			{
				oBeChofer.ID_Chofer = Convert.ToInt32(dr["ID_Chofer"]);
				oBeChofer.Nombre = string.IsNullOrEmpty(dr["Nombre"].ToString()) == true ? "" : dr["Nombre"].ToString();
				oBeChofer.Apellido = string.IsNullOrEmpty(dr["Apellido"].ToString()) == true ? "" : dr["Apellido"].ToString();
				oBeChofer.Cedula = string.IsNullOrEmpty(dr["Cedula"].ToString()) == true ? "" : dr["Cedula"].ToString();
				oBeChofer.Fecha_de_nacimiento = string.IsNullOrEmpty(dr["Fecha_de_nacimiento"].ToString()) == true ? "" : dr["Fecha_de_nacimiento"].ToString();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeChofer oBeChofer)
		{
			try
			{
				string sp = "SpChoferInsertar";


				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeChofer.Nombre));
				cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeChofer.Apellido));
				cmd.Parameters.Add(new SqlParameter("@CEDULA", oBeChofer.Cedula));
				cmd.Parameters.Add(new SqlParameter("@FECHA_DE_NACIMIENTO", oBeChofer.Fecha_de_nacimiento));

				rowsAffected =  cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close(); 

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Actualizar(ref clsBeChofer oBeChofer)
		{
			try
			{
				string sp = "SpChoferActualizar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_CHOFER", oBeChofer.ID_Chofer));
				cmd.Parameters.Add(new SqlParameter("@NOMBRE", oBeChofer.Nombre));
				cmd.Parameters.Add(new SqlParameter("@APELLIDO", oBeChofer.Apellido));
				cmd.Parameters.Add(new SqlParameter("@CEDULA", oBeChofer.Cedula));
				cmd.Parameters.Add(new SqlParameter("@FECHA_DE_NACIMIENTO", oBeChofer.Fecha_de_nacimiento));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Eliminar(ref clsBeChofer oBeChofer)
		{
			try
			{
				string sp = "SpChoferEliminar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_CHOFER", oBeChofer.ID_Chofer));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public DataTable Listar()
		{
			try
			{
				string sp = "SpChoferListar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);

				DataTable dt = new DataTable();
				dad.Fill(dt);

				return dt;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Obtener(ref clsBeChofer oBeChofer)
		{
			try
			{
				string sp = "SpChoferObtener";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@ID_CHOFER", oBeChofer.ID_Chofer));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeChofer, dt.Rows[0]);
				}
				else
				{
					throw new Exception("No se pudo obtener el registro");
				}

				return true;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		
  }

}
