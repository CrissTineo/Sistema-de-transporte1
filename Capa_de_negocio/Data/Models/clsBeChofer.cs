using System.Data.SqlClient;
using System.Windows;
using System;

namespace Capa_de_negocio.Data.Models
{
	public class clsBeChofer : ICloneable
	{

		private int mID_Chofer = 0;
		private string mNombre = "";
		private string mApellido = "";
		private string mCedula = "";
		private string mFecha_de_nacimiento = "";

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

		public string Nombre
		{
			get
			{
				return mNombre;
			}
			set
			{
				mNombre = value;
			}
		}

		public string Apellido
		{
			get
			{
				return mApellido;
			}
			set
			{
				mApellido = value;
			}
		}

		public string Cedula
		{
			get
			{
				return mCedula;
			}
			set
			{
				mCedula = value;
			}
		}

		public string Fecha_de_nacimiento
		{
			get
			{
				return mFecha_de_nacimiento;
			}
			set
			{
				mFecha_de_nacimiento = value;
			}
		}

		public clsBeChofer()
		{
		}

		public clsBeChofer(ref int ID_Chofer, string Nombre, string Apellido, string Cedula, string Fecha_de_nacimiento)
		{
		    mID_Chofer = ID_Chofer;
			mNombre = Nombre;
			mApellido = Apellido;
			mCedula = Cedula;
			mFecha_de_nacimiento = Fecha_de_nacimiento;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}
