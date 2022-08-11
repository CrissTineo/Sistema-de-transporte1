using Capa_de_negocio.Data.Models;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Capa_de_negocio.Data
{

	public class clsLnRuta
	{

		public void Cargar(ref clsBeRuta oBeRuta, DataRow dr)
		{
			try
			{
				oBeRuta.ID_ruta = Convert.ToInt32(dr["ID_ruta"]);
				oBeRuta.ID_Buses = Convert.ToInt32(dr["ID_Buses"]);
				oBeRuta.Ruta = string.IsNullOrEmpty(dr["Ruta"].ToString()) == true ? "" : dr["Ruta"].ToString();
				oBeRuta.Hora_llegada = Convert.ToDateTime(dr["Hora_llegada"]);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeRuta oBeRuta)
		{
			try
			{
				string sp = "SpRutaInsertar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand (sp, cnn);

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_BUSES", oBeRuta.ID_Buses));
				cmd.Parameters.Add(new SqlParameter("@RUTA", oBeRuta.Ruta));
				cmd.Parameters.Add(new SqlParameter("@HORA_LLEGADA", oBeRuta.Hora_llegada));

				rowsAffected = cmd.ExecuteNonQuery();
				oBeRuta.ID_ruta = Convert.ToInt32(cmd.Parameters["@ID_RUTA"].Value.ToString());

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Actualizar(ref clsBeRuta oBeRuta)
		{
			try
			{
				string sp = "SpRutaActualizar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand (sp, cnn);

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_RUTA", oBeRuta.ID_ruta));
				cmd.Parameters.Add(new SqlParameter("@ID_BUSES", oBeRuta.ID_Buses));
				cmd.Parameters.Add(new SqlParameter("@RUTA", oBeRuta.Ruta));
				cmd.Parameters.Add(new SqlParameter("@HORA_LLEGADA", oBeRuta.Hora_llegada));

				rowsAffected = cmd.ExecuteNonQuery();

				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Eliminar(ref clsBeRuta oBeRuta)
		{
			try
			{
				string sp = "SpRutaEliminar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand (sp, cnn);

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_RUTA", oBeRuta.ID_ruta));

				rowsAffected = cmd.ExecuteNonQuery();

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
				string sp = "SpRutaListar";

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

		public bool Obtener(ref clsBeRuta oBeRuta)
		{
			try
			{
				string sp = "SpRutaObtener";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@ID_RUTA", oBeRuta.ID_ruta));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeRuta, dt.Rows[0]);
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
