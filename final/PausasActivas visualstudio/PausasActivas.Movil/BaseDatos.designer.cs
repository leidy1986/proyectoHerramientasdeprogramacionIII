﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.225
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PausasActivas.Movil
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
	
	
	public partial class BaseDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertPerfil(Perfil instance);
    partial void UpdatePerfil(Perfil instance);
    partial void DeletePerfil(Perfil instance);
    partial void InsertEjercicio(Ejercicio instance);
    partial void UpdateEjercicio(Ejercicio instance);
    partial void DeleteEjercicio(Ejercicio instance);
    partial void InsertPausaRealizada(PausaRealizada instance);
    partial void UpdatePausaRealizada(PausaRealizada instance);
    partial void DeletePausaRealizada(PausaRealizada instance);
    #endregion
		
		public BaseDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
	
		public BaseDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		
		public System.Data.Linq.Table<Perfil> Perfil
		{
			get
			{
				return this.GetTable<Perfil>();
			}
		}
		
		public System.Data.Linq.Table<Ejercicio> Ejercicio
		{
			get
			{
				return this.GetTable<Ejercicio>();
			}
		}
		
		public System.Data.Linq.Table<PausaRealizada> PausaRealizada
		{
			get
			{
				return this.GetTable<PausaRealizada>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Perfil : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Nivel;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNivelChanging(int value);
    partial void OnNivelChanged();
    #endregion
		
		public Perfil()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nivel", IsPrimaryKey=true)]
		public int Nivel
		{
			get
			{
				return this._Nivel;
			}
			set
			{
				if ((this._Nivel != value))
				{
					this.OnNivelChanging(value);
					this.SendPropertyChanging();
					this._Nivel = value;
					this.SendPropertyChanged("Nivel");
					this.OnNivelChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Ejercicio : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Identificador;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private string _Imagen;
		
		private int _Nivel;
		
		private int _Tiempo;
		
		private EntitySet<PausaRealizada> _PausaRealizada;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdentificadorChanging(int value);
    partial void OnIdentificadorChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnImagenChanging(string value);
    partial void OnImagenChanged();
    partial void OnNivelChanging(int value);
    partial void OnNivelChanged();
    partial void OnTiempoChanging(int value);
    partial void OnTiempoChanged();
    #endregion
		
		public Ejercicio()
		{
			this._PausaRealizada = new EntitySet<PausaRealizada>(new Action<PausaRealizada>(this.attach_PausaRealizada), new Action<PausaRealizada>(this.detach_PausaRealizada));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Identificador", IsPrimaryKey=true)]
		public int Identificador
		{
			get
			{
				return this._Identificador;
			}
			set
			{
				if ((this._Identificador != value))
				{
					this.OnIdentificadorChanging(value);
					this.SendPropertyChanging();
					this._Identificador = value;
					this.SendPropertyChanged("Identificador");
					this.OnIdentificadorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", CanBeNull=false)]
		public string Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this.OnImagenChanging(value);
					this.SendPropertyChanging();
					this._Imagen = value;
					this.SendPropertyChanged("Imagen");
					this.OnImagenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nivel")]
		public int Nivel
		{
			get
			{
				return this._Nivel;
			}
			set
			{
				if ((this._Nivel != value))
				{
					this.OnNivelChanging(value);
					this.SendPropertyChanging();
					this._Nivel = value;
					this.SendPropertyChanged("Nivel");
					this.OnNivelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tiempo")]
		public int Tiempo
		{
			get
			{
				return this._Tiempo;
			}
			set
			{
				if ((this._Tiempo != value))
				{
					this.OnTiempoChanging(value);
					this.SendPropertyChanging();
					this._Tiempo = value;
					this.SendPropertyChanged("Tiempo");
					this.OnTiempoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ejercicio_PausaRealizada", Storage="_PausaRealizada", ThisKey="Identificador", OtherKey="Ejercicio")]
		public EntitySet<PausaRealizada> PausaRealizada
		{
			get
			{
				return this._PausaRealizada;
			}
			set
			{
				this._PausaRealizada.Assign(value);
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
		
		private void attach_PausaRealizada(PausaRealizada entity)
		{
			this.SendPropertyChanging();
			entity.Ejercicio1 = this;
		}
		
		private void detach_PausaRealizada(PausaRealizada entity)
		{
			this.SendPropertyChanging();
			entity.Ejercicio1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class PausaRealizada : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Identificador;
		
		private System.DateTime _FechaHoraEsperada;
		
		private System.DateTime _FechaHoraRealizada;
		
		private int _TiempoEsperado;
		
		private int _TiempoRealizado;
		
		private int _Nivel;
		
		private int _Ejercicio;
		
		private EntityRef<Ejercicio> _Ejercicio1;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdentificadorChanging(int value);
    partial void OnIdentificadorChanged();
    partial void OnFechaHoraEsperadaChanging(System.DateTime value);
    partial void OnFechaHoraEsperadaChanged();
    partial void OnFechaHoraRealizadaChanging(System.DateTime value);
    partial void OnFechaHoraRealizadaChanged();
    partial void OnTiempoEsperadoChanging(int value);
    partial void OnTiempoEsperadoChanged();
    partial void OnTiempoRealizadoChanging(int value);
    partial void OnTiempoRealizadoChanged();
    partial void OnNivelChanging(int value);
    partial void OnNivelChanged();
    partial void OnEjercicioChanging(int value);
    partial void OnEjercicioChanged();
    #endregion
		
		public PausaRealizada()
		{
			this._Ejercicio1 = default(EntityRef<Ejercicio>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Identificador", IsPrimaryKey=true)]
		public int Identificador
		{
			get
			{
				return this._Identificador;
			}
			set
			{
				if ((this._Identificador != value))
				{
					this.OnIdentificadorChanging(value);
					this.SendPropertyChanging();
					this._Identificador = value;
					this.SendPropertyChanged("Identificador");
					this.OnIdentificadorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaHoraEsperada")]
		public System.DateTime FechaHoraEsperada
		{
			get
			{
				return this._FechaHoraEsperada;
			}
			set
			{
				if ((this._FechaHoraEsperada != value))
				{
					this.OnFechaHoraEsperadaChanging(value);
					this.SendPropertyChanging();
					this._FechaHoraEsperada = value;
					this.SendPropertyChanged("FechaHoraEsperada");
					this.OnFechaHoraEsperadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaHoraRealizada")]
		public System.DateTime FechaHoraRealizada
		{
			get
			{
				return this._FechaHoraRealizada;
			}
			set
			{
				if ((this._FechaHoraRealizada != value))
				{
					this.OnFechaHoraRealizadaChanging(value);
					this.SendPropertyChanging();
					this._FechaHoraRealizada = value;
					this.SendPropertyChanged("FechaHoraRealizada");
					this.OnFechaHoraRealizadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TiempoEsperado")]
		public int TiempoEsperado
		{
			get
			{
				return this._TiempoEsperado;
			}
			set
			{
				if ((this._TiempoEsperado != value))
				{
					this.OnTiempoEsperadoChanging(value);
					this.SendPropertyChanging();
					this._TiempoEsperado = value;
					this.SendPropertyChanged("TiempoEsperado");
					this.OnTiempoEsperadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TiempoRealizado")]
		public int TiempoRealizado
		{
			get
			{
				return this._TiempoRealizado;
			}
			set
			{
				if ((this._TiempoRealizado != value))
				{
					this.OnTiempoRealizadoChanging(value);
					this.SendPropertyChanging();
					this._TiempoRealizado = value;
					this.SendPropertyChanged("TiempoRealizado");
					this.OnTiempoRealizadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nivel")]
		public int Nivel
		{
			get
			{
				return this._Nivel;
			}
			set
			{
				if ((this._Nivel != value))
				{
					this.OnNivelChanging(value);
					this.SendPropertyChanging();
					this._Nivel = value;
					this.SendPropertyChanged("Nivel");
					this.OnNivelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ejercicio")]
		public int Ejercicio
		{
			get
			{
				return this._Ejercicio;
			}
			set
			{
				if ((this._Ejercicio != value))
				{
					if (this._Ejercicio1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEjercicioChanging(value);
					this.SendPropertyChanging();
					this._Ejercicio = value;
					this.SendPropertyChanged("Ejercicio");
					this.OnEjercicioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ejercicio_PausaRealizada", Storage="_Ejercicio1", ThisKey="Ejercicio", OtherKey="Identificador", IsForeignKey=true)]
		public Ejercicio Ejercicio1
		{
			get
			{
				return this._Ejercicio1.Entity;
			}
			set
			{
				Ejercicio previousValue = this._Ejercicio1.Entity;
				if (((previousValue != value) 
							|| (this._Ejercicio1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ejercicio1.Entity = null;
						previousValue.PausaRealizada.Remove(this);
					}
					this._Ejercicio1.Entity = value;
					if ((value != null))
					{
						value.PausaRealizada.Add(this);
						this._Ejercicio = value.Identificador;
					}
					else
					{
						this._Ejercicio = default(int);
					}
					this.SendPropertyChanged("Ejercicio1");
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
}
#pragma warning restore 1591
