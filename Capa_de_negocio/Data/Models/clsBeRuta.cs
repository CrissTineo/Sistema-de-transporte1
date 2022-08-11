using System.Data.SqlClient;
using System.Windows;
using System;


namespace Capa_de_negocio.Data.Models
{
	public class clsBeRuta : ICloneable
	{

		private int mID_ruta = 0;
		private int mID_Buses = 0;
		private string mRuta = "";
		private DateTime mHora_llegada = DateTime.Now;

		public int ID_ruta
		{
			get
			{
				return mID_ruta;
			}
			set
			{
				mID_ruta = value;
			}
		}

		public int ID_Buses
		{
			get
			{
				return mID_Buses;
			}
			set
			{
				mID_Buses = value;
			}
		}

		public string Ruta
		{
			get
			{
				return mRuta;
			}
			set
			{
				mRuta = value;
			}
		}

		public DateTime Hora_llegada
		{
			get
			{
				return mHora_llegada;
			}
			set
			{
				mHora_llegada = value;
			}
		}

		public clsBeRuta()
		{
		}

		public clsBeRuta(ref int ID_ruta, int ID_Buses, string Ruta, DateTime Hora_llegada)
		{
			
		    mID_ruta = ID_ruta;
			mID_Buses = ID_Buses;
			mRuta = Ruta;
			mHora_llegada = Hora_llegada;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}


