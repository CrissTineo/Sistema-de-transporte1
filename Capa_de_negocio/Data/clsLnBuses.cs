using Capa_de_negocio.Data.Models;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Capa_de_negocio.Data
{
	public class clsLnBuses
	{


		public void Cargar(ref clsBeBuses oBeBuses, DataRow dr)
		{
			try
			{
				oBeBuses.ID_Buses = Convert.ToInt32(dr["ID_Buses"]);
				oBeBuses.Marca = string.IsNullOrEmpty(dr["Marca"].ToString()) == true ? "" : dr["Marca"].ToString();
				oBeBuses.Modelo = string.IsNullOrEmpty(dr["Modelo"].ToString()) == true ? "" : dr["Modelo"].ToString();
				oBeBuses.Placa = string.IsNullOrEmpty(dr["Placa"].ToString()) == true ? "" : dr["Placa"].ToString();
				oBeBuses.Año = string.IsNullOrEmpty(dr["Año"].ToString()) == true ? "" : dr["Año"].ToString();
				oBeBuses.Color = string.IsNullOrEmpty(dr["Color"].ToString()) == true ? "" : dr["Color"].ToString();
				oBeBuses.ID_Chofer = Convert.ToInt32(dr["ID_Chofer"]);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeBuses oBeBuses)
		{
			try
			{
				string sp = "SpBusesInsertar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@MARCA", oBeBuses.Marca));
				cmd.Parameters.Add(new SqlParameter("@MODELO", oBeBuses.Modelo));
				cmd.Parameters.Add(new SqlParameter("@PLACA", oBeBuses.Placa));
				cmd.Parameters.Add(new SqlParameter("@AÑO", oBeBuses.Año));
				cmd.Parameters.Add(new SqlParameter("@COLOR", oBeBuses.Color));
				cmd.Parameters.Add(new SqlParameter("@ID_CHOFER", oBeBuses.ID_Chofer));

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

		public int Actualizar(ref clsBeBuses oBeBuses)
		{
			try
			{
				string sp = "SpBusesActualizar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_BUSES", oBeBuses.ID_Buses));
				cmd.Parameters.Add(new SqlParameter("@MARCA", oBeBuses.Marca));
				cmd.Parameters.Add(new SqlParameter("@MODELO", oBeBuses.Modelo));
				cmd.Parameters.Add(new SqlParameter("@PLACA", oBeBuses.Placa));
				cmd.Parameters.Add(new SqlParameter("@AÑO", oBeBuses.Año));
				cmd.Parameters.Add(new SqlParameter("@COLOR", oBeBuses.Color));
				cmd.Parameters.Add(new SqlParameter("@ID_CHOFER", oBeBuses.ID_Chofer));

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

		public int Eliminar(ref clsBeBuses oBeBuses)
		{
			try
			{
				string sp = "SpBusesEliminar";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@ID_BUSES", oBeBuses.ID_Buses));

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
				string sp = "SpBusesListar";

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

		public bool Obtener(ref clsBeBuses oBeBuses)
		{
			try
			{
				string sp = "SpBusesObtener";

				SqlConnection cnn = new SqlConnection(ConexionDB.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@ID_BUSES", oBeBuses.ID_Buses));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeBuses, dt.Rows[0]);
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
