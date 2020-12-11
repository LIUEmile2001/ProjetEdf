using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFEdf
{
    /// <summary>
    /// Logique d'interaction pour FNTControleur.xaml
    /// </summary>
    public partial class FNTControleur : Window
    {
        edfEntities gst;
        public FNTControleur()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();

            //lstClients.ItemsSource = (from cli in gst.client
            //                          where gst.controleur.Any(ctrl => ctrl.id == cli.idcontroleur)
            //                          select cli).ToList<client>();

            var query = from cli in gst.client
                        join ctrl in gst.controleur on cli.idcontroleur equals ctrl.id
                        where cli.idcontroleur == ctrl.id
                        select cli;

            lstClients.ItemsSource = query.ToList();
        }

        private void btnReleve_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
