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
    /// Logique d'interaction pour CategorieSignalView.xaml
    /// </summary>
    public partial class CategorieSignalView : UserControl
    {
        public CategorieSignalView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
        }

        private void ChargerDonneesExemple()
        {
            var categories = new List<CategorieSignal>
            {
                new CategorieSignal { Id = 1, Nom = "Route endommagée", Description = "Routes avec nids-de-poule, fissures ou détériorations" },
                new CategorieSignal { Id = 2, Nom = "Accident", Description = "Accidents de la route et collisions" },
                new CategorieSignal { Id = 3, Nom = "Obstacle", Description = "Objets ou débris sur la chaussée" },
                //new CategorieSignal { Id = 4, Nom = "travaux", Description = "Routes en cours de construction" },
                //new CategorieSignal { Id = 5, Nom = "Éboulement", Description = "Chutes de pierres ou terrains instables" }
                //new CategorieSignal { Id = 6, Nom = "Signalisation défectueuse", Description = "Panneaux ou feux tricolores endommagés" },
                //new CategorieSignal { Id = 7, Nom = "Éclairage public", Description = "Problèmes d'éclairage des routes" },
                new CategorieSignal { Id = 4, Nom = "Travaux", Description = "Travaux en cours sur la voie publique" }
            };

            dgCategories.ItemsSource = categories;
            txtTotalCategories.Text = $"({categories.Count} catégories)";
        }
    }
}

