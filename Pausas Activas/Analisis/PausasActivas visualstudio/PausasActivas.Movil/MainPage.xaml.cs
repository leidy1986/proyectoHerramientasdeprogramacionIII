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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //1. El sistema valida que existe un perfil
            using (BaseDatosDataContext contexto
                = new BaseDatosDataContext(App.cadenaConexion))
            { 
                //Select * from Perfil
                var consulta = (from p in contexto.Perfil
                               select p).ToList();

                if (consulta.Count == 0)
                {
                    NavigationService.Navigate(
                        new Uri("/AdministrarPerfil.xaml", 
                            UriKind.Relative));
                }
            }
        }

        private void Administrar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AdministrarPerfil.xaml",UriKind.Relative));
        }

        private void Ejercicio_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EjercicioView.xaml", UriKind.Relative));
        }


    }
}