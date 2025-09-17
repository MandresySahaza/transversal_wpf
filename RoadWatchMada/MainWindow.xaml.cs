using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoadWatchMada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button _currentActiveButton;

        public MainWindow()
        {
            InitializeComponent();
            SetActiveMenuButton(btnGestionUtilisateur);
            AfficherGestionUtilisateur();
        }

        private void SetActiveMenuButton(Button button)
        {
            if (_currentActiveButton != null)
            {
                _currentActiveButton.Style = (Style)FindResource("MenuButtonStyle");
            }

            button.Style = (Style)FindResource("MenuButtonActiveStyle");
            _currentActiveButton = button;
        }

        private void AfficherGestionUtilisateur()
        {
            MainContent.Content = new GestionUtilisateurView();
        }

        private void AfficherValidationSignalement()
        {
            MainContent.Content = new ValidationSignalementView();
        }

        private void BtnGestionUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherGestionUtilisateur();
        }

        private void BtnValidationSignalement_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherValidationSignalement();
        }

        private void BtnCategorieSignal_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherCategorieSignal();
        }

        private void AfficherCategorieSignal()
        {
            MainContent.Content = new CategorieSignalView();
        }

        private void BtnTypeSignal_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherTypeSignal();
        }

        private void AfficherTypeSignal()
        {
            MainContent.Content = new TypeSignalView();
        }

        private void BtnRoute_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherRoute();
        }

        private void AfficherRoute()
        {
            MainContent.Content = new RouteView();
        }
        private void BtnVille_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherVille();
        }

        private void AfficherVille()
        {
            MainContent.Content = new VilleView();
        }
        private void BtnQuartier_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherQuartier();
        }

        private void AfficherQuartier()
        {
            MainContent.Content = new QuartierView();
        }

        private void BtnBadge_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenuButton((Button)sender);
            AfficherBadge();
        }

        private void AfficherBadge()
        {
            MainContent.Content = new BadgeView();
        }
    }
}