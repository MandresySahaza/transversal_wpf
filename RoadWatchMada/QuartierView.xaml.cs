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
    /// Logique d'interaction pour QuartierView.xaml
    /// </summary>
    public partial class QuartierView : UserControl
    {
        public QuartierView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
            ChargerVilles();
        }

        private void ChargerDonneesExemple()
        {
            var quartiers = new List<Quartier>
            {
                new Quartier { Id = 1, Nom = "Analakely", Ville = "Antananarivo" },
                new Quartier { Id = 2, Nom = "Isoraka", Ville = "Antananarivo" },
                new Quartier { Id = 3, Nom = "Ambohijatovo", Ville = "Antananarivo" },
                new Quartier { Id = 4, Nom = "Anosy", Ville = "Antananarivo" },
                new Quartier { Id = 5, Nom = "Andravoahangy", Ville = "Antananarivo" },
                //new Quartier { Id = 6, Nom = "Ambanidia", Ville = "Antananarivo" },
                //new Quartier { Id = 7, Nom = "Betsimitatatra", Ville = "Antananarivo" },
                //new Quartier { Id = 8, Nom = "Tanambao", Ville = "Toamasina" },
                //new Quartier { Id = 9, Nom = "Bazarikely", Ville = "Toamasina" },
                //new Quartier { Id = 10, Nom = "Analamalotra", Ville = "Toamasina" },
                //new Quartier { Id = 11, Nom = "Morarano", Ville = "Toamasina" },
                //new Quartier { Id = 12, Nom = "Antsena", Ville = "Fianarantsoa" },
                //new Quartier { Id = 13, Nom = "Ambalavao", Ville = "Fianarantsoa" },
                //new Quartier { Id = 14, Nom = "Andoharanofotsy", Ville = "Antsirabe" },
                //new Quartier { Id = 15, Nom = "Antanambao", Ville = "Antsirabe" },
                //new Quartier { Id = 16, Nom = "Mahazoarivo", Ville = "Antsirabe" },
                //new Quartier { Id = 17, Nom = "Marolaka", Ville = "Mahajanga" },
                //new Quartier { Id = 18, Nom = "Antsahavola", Ville = "Mahajanga" },
                //new Quartier { Id = 19, Nom = "Amborovy", Ville = "Mahajanga" },
                //new Quartier { Id = 20, Nom = "Ankify", Ville = "Antsiranana" },
                //new Quartier { Id = 21, Nom = "Joffreville", Ville = "Antsiranana" },
                //new Quartier { Id = 22, Nom = "Ambalavao", Ville = "Toliara" },
                //new Quartier { Id = 23, Nom = "Ankilibe", Ville = "Toliara" },
                //new Quartier { Id = 24, Nom = "Betsimitatatra", Ville = "Toliara" }
            };

            dgQuartiers.ItemsSource = quartiers;
            txtTotalQuartiers.Text = $"({quartiers.Count} quartiers)";
        }

        private void ChargerVilles()
        {
            var villes = new List<string>
            {
                "Antananarivo", "Toamasina", "Antsirabe", "Fianarantsoa",
                "Mahajanga", "Toliara", "Antsiranana", "Moramanga",
                "Ambatondrazaka", "Morondava", "Manakara", "Sambava"
            };

            foreach (var ville in villes)
            {
                cmbFiltreVille.Items.Add(new ComboBoxItem { Content = ville });
            }
        }
    }
}
