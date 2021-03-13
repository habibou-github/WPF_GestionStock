using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Navigation_Drawer_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Materiel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Materiel.Visibility = Visibility.Visible;
            Perssonel.Visibility = Visibility.Collapsed;
            Servive.Visibility = Visibility.Collapsed;
            Commande.Visibility = Visibility.Collapsed;
            Statistics.Visibility = Visibility.Collapsed;
        }


        private void datagridMateriel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-E7828JU\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True;");

                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    String query = "SELECT * FROM materiel";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.ExecuteNonQuery();

                    SqlDataAdapter data = new SqlDataAdapter(sqlCmd);
                    DataTable dt = new DataTable("materiel");
                    data.Fill(dt);
                    datagridMateriel.ItemsSource = dt.DefaultView;
                    data.Update(dt);
                    sqlCon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjouterMat ajouterM = new AjouterMat();
            ajouterM.Show();
            Close();
            
        }
        private void BtnMoifier_Click(object sender, RoutedEventArgs e)
        {
            ModefierMateriel modefierMateriel = new ModefierMateriel();
            modefierMateriel.Show();
            Close();
        }
        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {

        }









        //PERSSONE__________________________________________________________________________________________________________________________________________//
        //__________________________________________________________________________________________________________________________________________________//



        public void Personnel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Materiel.Visibility = Visibility.Collapsed;
            Perssonel.Visibility = Visibility.Visible;
            Servive.Visibility = Visibility.Collapsed;
            Commande.Visibility = Visibility.Collapsed;
            Statistics.Visibility = Visibility.Collapsed;


        }

        private void BtnLoadPers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAjouterPers_Click(object sender, RoutedEventArgs e)
        {
            AjouterPers ajouterPers = new AjouterPers();
            ajouterPers.Show();
            Close();
        }

        private void BtnModifierPers_Click(object sender, RoutedEventArgs e)
        {
            ModefierPers modefierPers = new ModefierPers();
            modefierPers.Show();
            Close();
        }

        private void BtnSupprimerPers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPc_Click(object sender, RoutedEventArgs e)
        {
            PasserCommande passerCommande = new PasserCommande();
            passerCommande.Show();
            this.Close();
        }

        //PERSSONE__________________________________________________________________________________________________________________________________________//
        //__________________________________________________________________________________________________________________________________________________//



        public void Service_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Materiel.Visibility = Visibility.Collapsed;
            Perssonel.Visibility = Visibility.Collapsed;
            Servive.Visibility = Visibility.Visible;
            Commande.Visibility = Visibility.Collapsed;
            Statistics.Visibility = Visibility.Collapsed;
        }






















        private void Logout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }











        //SERVICE__________________________________________________________________________________________________________________________________________//
        //__________________________________________________________________________________________________________________________________________________//
        private void BtnLoadS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSupprimerS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAjouterS_Click(object sender, RoutedEventArgs e)
        {

        }





        //SERVICE__________________________________________________________________________________________________________________________________________//
        //__________________________________________________________________________________________________________________________________________________//

        public void Commande_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Materiel.Visibility = Visibility.Collapsed;
            Perssonel.Visibility = Visibility.Collapsed;
            Servive.Visibility = Visibility.Collapsed;
            Commande.Visibility = Visibility.Visible;
            Statistics.Visibility = Visibility.Collapsed;
        }

        private void btnLoadCmd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void supprimerCmd_Click(object sender, RoutedEventArgs e)
        {

        }











        //STATISTICS__________________________________________________________________________________________________________________________________________//
        //__________________________________________________________________________________________________________________________________________________//

        public void Statistics_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Materiel.Visibility = Visibility.Collapsed;
            Perssonel.Visibility = Visibility.Collapsed;
            Servive.Visibility = Visibility.Collapsed;
            Commande.Visibility = Visibility.Collapsed;
            Statistics.Visibility = Visibility.Visible;
        }


    }
}
