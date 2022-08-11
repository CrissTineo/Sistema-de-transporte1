using System.Data.SqlClient;
using System.Windows;
using System;


namespace Capa_de_negocio.Data.Models
{

	public class clsBeBuses : ICloneable
	{

		private int mID_Buses = 0;
		private string mMarca = "";
		private string mModelo = "";
		private string mPlaca = "";
		private string mAño = "";
		private string mColor = "";
		private int mID_Chofer = 0;

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

		public string Marca
		{
			get
			{
				return mMarca;
			}
			set
			{
				mMarca = value;
			}
		}

		public string Modelo
		{
			get
			{
				return mModelo;
			}
			set
			{
				mModelo = value;
			}
		}

		public string Placa
		{
			get
			{
				return mPlaca;
			}
			set
			{
				mPlaca = value;
			}
		}

		public string Año
		{
			get
			{
				return mAño;
			}
			set
			{
				mAño = value;
			}
		}

		public string Color
		{
			get
			{
				return mColor;
			}
			set
			{
				mColor = value;
			}
		}

		public int ID_Chofer
		{
			get
			{
				return mID_Chofer;
			}
			set
			{
				mID_Chofer = value;
			}
		}

		public clsBeBuses()
		{
		}

		public clsBeBuses(ref int ID_Buses, string Marca, string Modelo, string Placa, string Año, string Color, int ID_Chofer)
		{
			
		    mID_Buses = ID_Buses;
			mMarca = Marca;
			mModelo = Modelo;
			mPlaca = Placa;
			mAño = Año;
			mColor = Color;
			mID_Chofer = ID_Chofer;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}

