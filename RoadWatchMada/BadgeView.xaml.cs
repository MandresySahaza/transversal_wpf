using RoadWatchMada.Models;
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

namespace RoadWatchMada
{
    /// <summary>
    /// Logique d'interaction pour BadgeView.xaml
    /// </summary>
    public partial class BadgeView : UserControl
    {
        public BadgeView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
        }

        private void ChargerDonneesExemple()
        {
            var badges = new List<Badge>
            {
                new Badge { Id = 1, Nom = "Débutant Signalement", ScoreMin = 0 },
                new Badge { Id = 2, Nom = "Contributeur Actif", ScoreMin = 10 },
                new Badge { Id = 3, Nom = "Expert Route", ScoreMin = 50 },
                new Badge { Id = 4, Nom = "Super Vérificateur", ScoreMin = 100 },
                new Badge { Id = 5, Nom = "Maître Signalement", ScoreMin = 200 },
                //new Badge { Id = 6, Nom = "Légende RoadWatch", ScoreMin = 500 },
                //new Badge { Id = 7, Nom = "Protecteur Communauté", ScoreMin = 25 },
                //new Badge { Id = 8, Nom = "Détective Route", ScoreMin = 75 },
                //new Badge { Id = 9, Nom = "Gardiens des Routes", ScoreMin = 150 },
                //new Badge { Id = 10, Nom = "Héros Madagascar", ScoreMin = 300 }
            };

            dgBadges.ItemsSource = badges;
            txtTotalBadges.Text = $"({badges.Count} badges)";
        }
    }
}
