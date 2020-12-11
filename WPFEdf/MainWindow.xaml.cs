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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFEdf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtLogin.Text == null)
            {
                MessageBox.Show("Veuillez saisir un login", "login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if(txtMdp.Text == null)
                {
                    MessageBox.Show("Veuillez saisir un mot de passe", "mot de passe", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {


                    controleur leControleur = gst.controleur.ToList().Find(ctrl => ctrl.login == txtLogin.Text && ctrl.mdp == txtMdp.Text);

                    if (leControleur == null)
                    {
                        MessageBox.Show("On ne trouve pas ce controleur dans la base de donnée", "controleur", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    
                    else
                    {
                        if(leControleur.statut == "admin")
                        {
                            FNTGestionEdf fnt = new FNTGestionEdf();
                            fnt.Show();
                        }
                        else
                        {
                            FNTControleur fnt = new FNTControleur();
                            fnt.Show();
                        }
                        
                    }

                    //var query = from ctr in gst.controleur
                    //            where ctr.login == txtLogin.Text && ctr.mdp == txtMdp.Text
                    //            select ctr;

                    //if (query == null)
                    //{
                    //    MessageBox.Show("On ne trouve pas ce controleur dans la base de donnée", "controleur", MessageBoxButton.OK, MessageBoxImage.Information);
                    //}
                    //else
                    //{
                    //    FNTGestionEdf fnt = new FNTGestionEdf();
                    //    fnt.Show();
                    //}




                }
            }
        }
    }
}
