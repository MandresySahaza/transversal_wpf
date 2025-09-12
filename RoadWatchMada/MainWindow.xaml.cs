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
            // Pour l'instant, on affiche un message simple
            var textBlock = new TextBlock
            {
                Text = "Écran de Validation Signalement",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 24,
                Foreground = (System.Windows.Media.Brush)FindResource("SecondaryColor")
            };

            MainContent.Content = textBlock;
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
    }
}