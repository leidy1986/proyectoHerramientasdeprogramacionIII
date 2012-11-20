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
    public partial class EjercicioViewç : PhoneApplicationPage
    {
        public EjercicioViewç()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Usted no ha realizado el ejercicio.");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}