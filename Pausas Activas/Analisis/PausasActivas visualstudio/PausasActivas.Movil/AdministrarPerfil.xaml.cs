using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PausasActivas.Movil
{
    public partial class AdministrarPerfil : PhoneApplicationPage
    {
        public AdministrarPerfil()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            using (BaseDatosDataContext contexto
                = new BaseDatosDataContext(App.cadenaConexion))
            {
                Perfil perfilConsultado = (from p in contexto.Perfil
                                           select p).FirstOrDefault();

                bool esNuevo = false;
                if (perfilConsultado == null)
                {
                    perfilConsultado = new Perfil();
                    esNuevo = true;
                }

                if (this.lstNiveles.SelectedItem == null)
                    MessageBox.Show("Por favor seleccione el nivel");
                else
                {
                    Expression.Blend.SampleData.Perfiles.Item objetoSeleccionado =
                        (Expression.Blend.SampleData.Perfiles.Item)this.lstNiveles.SelectedItem;
                    
                    perfilConsultado.Nivel = Convert.ToInt32(objetoSeleccionado.Codigo);
                }

                if (esNuevo)
                {
                    contexto.Perfil.InsertOnSubmit(perfilConsultado);
                }

                contexto.SubmitChanges();
                MessageBox.Show("Perfil actualizado!");
                NavigationService.GoBack();
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
        	// TODO: Agregar implementación de controlador de eventos aquí.
        }
    }
}