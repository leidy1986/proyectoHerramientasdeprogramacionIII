//      *********    NO MODIFIQUE ESTE ARCHIVO     *********
//      Este archivo se regenera mediante una herramienta de diseño.
//       Si realiza cambios en este archivo, puede causar errores.
namespace Expression.Blend.SampleData.Perfiles
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class Perfiles { }
#else

	public class Perfiles : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public Perfiles()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/PausasActivas.Movil;component/SampleData/Perfiles/Perfiles.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private double _Codigo = 0;

		public double Codigo
		{
			get
			{
				return this._Codigo;
			}

			set
			{
				if (this._Codigo != value)
				{
					this._Codigo = value;
					this.OnPropertyChanged("Codigo");
				}
			}
		}

		private string _Nombre = string.Empty;

		public string Nombre
		{
			get
			{
				return this._Nombre;
			}

			set
			{
				if (this._Nombre != value)
				{
					this._Nombre = value;
					this.OnPropertyChanged("Nombre");
				}
			}
		}

		private System.Windows.Media.ImageSource _Imagen = null;

		public System.Windows.Media.ImageSource Imagen
		{
			get
			{
				return this._Imagen;
			}

			set
			{
				if (this._Imagen != value)
				{
					this._Imagen = value;
					this.OnPropertyChanged("Imagen");
				}
			}
		}

		private string _Descripción = string.Empty;

		public string Descripción
		{
			get
			{
				return this._Descripción;
			}

			set
			{
				if (this._Descripción != value)
				{
					this._Descripción = value;
					this.OnPropertyChanged("Descripción");
				}
			}
		}
	}
#endif
}
