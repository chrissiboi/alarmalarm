﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WTF
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Feuerwehr")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnCreated();
    partial void InsertT_Einsätze(T_Einsätze instance);
    partial void UpdateT_Einsätze(T_Einsätze instance);
    partial void DeleteT_Einsätze(T_Einsätze instance);
    partial void InsertT_FarzeugFlotte(T_FarzeugFlotte instance);
    partial void UpdateT_FarzeugFlotte(T_FarzeugFlotte instance);
    partial void DeleteT_FarzeugFlotte(T_FarzeugFlotte instance);
    partial void InsertT_Route(T_Route instance);
    partial void UpdateT_Route(T_Route instance);
    partial void DeleteT_Route(T_Route instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::WTF.Properties.Settings.Default.FeuerwehrConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<T_Einsätze> T_Einsätze
		{
			get
			{
				return this.GetTable<T_Einsätze>();
			}
		}
		
		public System.Data.Linq.Table<T_EinsätzeFarzeugFlotte> T_EinsätzeFarzeugFlotte
		{
			get
			{
				return this.GetTable<T_EinsätzeFarzeugFlotte>();
			}
		}
		
		public System.Data.Linq.Table<T_FarzeugFlotte> T_FarzeugFlotte
		{
			get
			{
				return this.GetTable<T_FarzeugFlotte>();
			}
		}
		
		public System.Data.Linq.Table<T_Route> T_Route
		{
			get
			{
				return this.GetTable<T_Route>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Einsätze")]
	public partial class T_Einsätze : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_ID;
		
		private System.DateTime _Datum;
		
		private string _Ergebnis;
		
		private int _Einsatzdauer;
		
		private int _f_Route_ID;
		
		private EntityRef<T_Route> _T_Route;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnDatumChanging(System.DateTime value);
    partial void OnDatumChanged();
    partial void OnErgebnisChanging(string value);
    partial void OnErgebnisChanged();
    partial void OnEinsatzdauerChanging(int value);
    partial void OnEinsatzdauerChanged();
    partial void Onf_Route_IDChanging(int value);
    partial void Onf_Route_IDChanged();
    #endregion
		
		public T_Einsätze()
		{
			this._T_Route = default(EntityRef<T_Route>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum", DbType="DateTime NOT NULL")]
		public System.DateTime Datum
		{
			get
			{
				return this._Datum;
			}
			set
			{
				if ((this._Datum != value))
				{
					this.OnDatumChanging(value);
					this.SendPropertyChanging();
					this._Datum = value;
					this.SendPropertyChanged("Datum");
					this.OnDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ergebnis", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Ergebnis
		{
			get
			{
				return this._Ergebnis;
			}
			set
			{
				if ((this._Ergebnis != value))
				{
					this.OnErgebnisChanging(value);
					this.SendPropertyChanging();
					this._Ergebnis = value;
					this.SendPropertyChanged("Ergebnis");
					this.OnErgebnisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Einsatzdauer", DbType="Int NOT NULL")]
		public int Einsatzdauer
		{
			get
			{
				return this._Einsatzdauer;
			}
			set
			{
				if ((this._Einsatzdauer != value))
				{
					this.OnEinsatzdauerChanging(value);
					this.SendPropertyChanging();
					this._Einsatzdauer = value;
					this.SendPropertyChanged("Einsatzdauer");
					this.OnEinsatzdauerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_f_Route_ID", DbType="Int NOT NULL")]
		public int f_Route_ID
		{
			get
			{
				return this._f_Route_ID;
			}
			set
			{
				if ((this._f_Route_ID != value))
				{
					if (this._T_Route.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onf_Route_IDChanging(value);
					this.SendPropertyChanging();
					this._f_Route_ID = value;
					this.SendPropertyChanged("f_Route_ID");
					this.Onf_Route_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Route_T_Einsätze", Storage="_T_Route", ThisKey="f_Route_ID", OtherKey="P_ID", IsForeignKey=true)]
		public T_Route T_Route
		{
			get
			{
				return this._T_Route.Entity;
			}
			set
			{
				T_Route previousValue = this._T_Route.Entity;
				if (((previousValue != value) 
							|| (this._T_Route.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._T_Route.Entity = null;
						previousValue.T_Einsätze.Remove(this);
					}
					this._T_Route.Entity = value;
					if ((value != null))
					{
						value.T_Einsätze.Add(this);
						this._f_Route_ID = value.P_ID;
					}
					else
					{
						this._f_Route_ID = default(int);
					}
					this.SendPropertyChanged("T_Route");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_EinsätzeFarzeugFlotte")]
	public partial class T_EinsätzeFarzeugFlotte
	{
		
		private System.Nullable<int> _einsätze_ID;
		
		private string _farzeigflotte;
		
		public T_EinsätzeFarzeugFlotte()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_einsätze_ID", DbType="Int")]
		public System.Nullable<int> einsätze_ID
		{
			get
			{
				return this._einsätze_ID;
			}
			set
			{
				if ((this._einsätze_ID != value))
				{
					this._einsätze_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_farzeigflotte", DbType="VarChar(10)")]
		public string farzeigflotte
		{
			get
			{
				return this._farzeigflotte;
			}
			set
			{
				if ((this._farzeigflotte != value))
				{
					this._farzeigflotte = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_FarzeugFlotte")]
	public partial class T_FarzeugFlotte : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _farzeugnummer;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnfarzeugnummerChanging(string value);
    partial void OnfarzeugnummerChanged();
    #endregion
		
		public T_FarzeugFlotte()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_farzeugnummer", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string farzeugnummer
		{
			get
			{
				return this._farzeugnummer;
			}
			set
			{
				if ((this._farzeugnummer != value))
				{
					this.OnfarzeugnummerChanging(value);
					this.SendPropertyChanging();
					this._farzeugnummer = value;
					this.SendPropertyChanged("farzeugnummer");
					this.OnfarzeugnummerChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Route")]
	public partial class T_Route : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_ID;
		
		private decimal _leange;
		
		private int _fahrdauer;
		
		private EntitySet<T_Einsätze> _T_Einsätze;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnleangeChanging(decimal value);
    partial void OnleangeChanged();
    partial void OnfahrdauerChanging(int value);
    partial void OnfahrdauerChanged();
    #endregion
		
		public T_Route()
		{
			this._T_Einsätze = new EntitySet<T_Einsätze>(new Action<T_Einsätze>(this.attach_T_Einsätze), new Action<T_Einsätze>(this.detach_T_Einsätze));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_leange", DbType="Decimal(16,2) NOT NULL")]
		public decimal leange
		{
			get
			{
				return this._leange;
			}
			set
			{
				if ((this._leange != value))
				{
					this.OnleangeChanging(value);
					this.SendPropertyChanging();
					this._leange = value;
					this.SendPropertyChanged("leange");
					this.OnleangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fahrdauer", DbType="Int NOT NULL")]
		public int fahrdauer
		{
			get
			{
				return this._fahrdauer;
			}
			set
			{
				if ((this._fahrdauer != value))
				{
					this.OnfahrdauerChanging(value);
					this.SendPropertyChanging();
					this._fahrdauer = value;
					this.SendPropertyChanged("fahrdauer");
					this.OnfahrdauerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Route_T_Einsätze", Storage="_T_Einsätze", ThisKey="P_ID", OtherKey="f_Route_ID")]
		public EntitySet<T_Einsätze> T_Einsätze
		{
			get
			{
				return this._T_Einsätze;
			}
			set
			{
				this._T_Einsätze.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_T_Einsätze(T_Einsätze entity)
		{
			this.SendPropertyChanging();
			entity.T_Route = this;
		}
		
		private void detach_T_Einsätze(T_Einsätze entity)
		{
			this.SendPropertyChanging();
			entity.T_Route = null;
		}
	}
}
#pragma warning restore 1591