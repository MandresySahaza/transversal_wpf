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
    /// Logique d'interaction pour VilleView.xaml
    /// </summary>
    public partial class VilleView : UserControl
    {
        public VilleView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
        }

        private void ChargerDonneesExemple()
        {
            var villes = new List<Ville>
            {
                new Ville { Id = 1, Nom = "Antananarivo" },
                new Ville { Id = 2, Nom = "Toamasina" },
                new Ville { Id = 3, Nom = "Antsirabe" },
                new Ville { Id = 4, Nom = "Fianarantsoa" },
                new Ville { Id = 5, Nom = "Mahajanga" },
                //new Ville { Id = 6, Nom = "Toliara" },
                //new Ville { Id = 7, Nom = "Antsiranana" },
                //new Ville { Id = 8, Nom = "Moramanga" },
                //new Ville { Id = 9, Nom = "Ambatondrazaka" },
                //new Ville { Id = 10, Nom = "Morondava" },
                //new Ville { Id = 11, Nom = "Manakara" },
                //new Ville { Id = 12, Nom = "Sambava" },
                //new Ville { Id = 13, Nom = "Ambositra" },
                //new Ville { Id = 14, Nom = "Ambalavao" },
                //new Ville { Id = 15, Nom = "Farafangana" },
                //new Ville { Id = 16, Nom = "Maroantsetra" },
                //new Ville { Id = 17, Nom = "Antalaha" },
                //new Ville { Id = 18, Nom = "Ihosy" },
                //new Ville { Id = 19, Nom = "Mananjary" },
                //new Ville { Id = 20, Nom = "Taolagnaro" }
            };

            dgVilles.ItemsSource = villes;
            txtTotalVilles.Text = $"({villes.Count} villes)";
        }
    }
}
