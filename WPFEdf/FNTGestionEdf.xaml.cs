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
    /// Logique d'interaction pour FNTGestionEdf.xaml
    /// </summary>
    public partial class FNTGestionEdf : Window
    {
        edfEntities gst;
        public FNTGestionEdf()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstControleurs.ItemsSource = gst.controleur.ToList();
        }

        private void lstControleurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstControleurs.SelectedItem != null)
            {
                lstClients.ItemsSource = gst.client.ToList().FindAll(clt => clt.idcontroleur == (lstControleurs.SelectedItem as controleur).id);
            }
        }

        private void insContro_Click(object sender, RoutedEventArgs e)
        {
            if(txtNomControleur.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom du controleur", "nom du controleur", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }
            else
            {
                if (txtPrenomControleur.Text == "")
                {
                    MessageBox.Show("Veuillez saisir le prenom du controleur", "Prenom du controleur", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    controleur ctr = new controleur()
                    {
                        id = gst.controleur.ToList().Max(ct => ct.id + 1),
                        nom = txtNomControleur.Text,
                        prenom = txtPrenomControleur.Text,
                        login = txtNomControleur.Text.Substring(0, 1).ToLower() + txtPrenomControleur.Text.Substring(0, 1).ToLower(),
                        mdp = txtNomControleur.Text.Substring(0, 1).ToLower() + txtPrenomControleur.Text.Substring(0, 1).ToLower() + 123,
                        statut = "ctrl"
                    };

                    gst.controleur.Add(ctr);
                    gst.SaveChanges();

                    MessageBox.Show("Votre controleur a bien été inséré", "Insertion", MessageBoxButton.OK, MessageBoxImage.Information);


                    lstControleurs.ItemsSource = gst.controleur.ToList();
                }
                
            }
        }

        private void insClient_Click(object sender, RoutedEventArgs e)
        {
            if(txtNomClient.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom du client", "Nom du client", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                if (txtPrenomClient.Text == "")
                {
                    MessageBox.Show("Veuillez saisir le prenom du client", "Prenom du client", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    if (lstControleurs.SelectedItem == null)
                    {
                        MessageBox.Show("Veuillez saisir un controleur", "controleur", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        client cli = new client()
                        {
                            identifiant = gst.client.ToList().Max(c => c.identifiant + 1),
                            nom = txtNomClient.Text,
                            prenom = txtPrenomClient.Text,
                            ancienReleve = 0,
                            dernierReleve = 0,
                            idcontroleur = (lstControleurs.SelectedItem as controleur).id
                        };
                        gst.client.Add(cli);
                        gst.SaveChanges();

                        MessageBox.Show("Votre client a bien été inséré", "Insertion", MessageBoxButton.OK, MessageBoxImage.Information);

                        lstClients.ItemsSource = gst.client.ToList().FindAll(clt => clt.idcontroleur == (lstControleurs.SelectedItem as controleur).id);
                    }
                }
                
            }
        }
    }
}
