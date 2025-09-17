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
    /// Logique d'interaction pour ValidationSignalementView.xaml
    /// </summary>
    public partial class ValidationSignalementView : UserControl
    {
        public ValidationSignalementView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
            ChargerStatuts();
        }

        private void ChargerDonneesExemple()
        {
            var signalements = new List<Signalement>
            {
                new Signalement {
                    Id = 1,
                    NomSignaleur = "Rakoto",
                    PrenomSignaleur = "Jean",
                    DateSignalement = DateTime.Now.AddDays(-2),
                    Statut = "En attente Validation",
                    Categorie = "Route endommagée",
                    Localisation = "RN2, PK 12, Antananarivo"
                },
                new Signalement {
                    Id = 2,
                    NomSignaleur = "Rasoa",
                    PrenomSignaleur = "Marie",
                    DateSignalement = DateTime.Now.AddDays(-1),
                    Statut = "En attente Validation",
                    Categorie = "Accident",
                    Localisation = "RN4, PK 45, Mahajanga"
                },
                new Signalement {
                    Id = 3,
                    NomSignaleur = "Randria",
                    PrenomSignaleur = "Paul",
                    DateSignalement = DateTime.Now.AddDays(-3),
                    Statut = "En attente Validation",
                    Categorie = "Obstacle",
                    Localisation = "RN7, PK 78, Antsirabe"
                },
                new Signalement {
                    Id = 4,
                    NomSignaleur = "Razafy",
                    PrenomSignaleur = "Lucie",
                    DateSignalement = DateTime.Now.AddDays(-1),
                    Statut = "En attente Validation",
                    Categorie = "Inondation",
                    Localisation = "RN13, PK 23, Fianarantsoa"
                },
                new Signalement {
                    Id = 5,
                    NomSignaleur = "Andriana",
                    PrenomSignaleur = "Pierre",
                    DateSignalement = DateTime.Now.AddDays(-4),
                    Statut = "En attente Validation",
                    Categorie = "Éboulement",
                    Localisation = "RN6, PK 56, Antsiranana"
                },
                new Signalement {
                    Id = 6,
                    NomSignaleur = "Ramananto",
                    PrenomSignaleur = "Sophie",
                    DateSignalement = DateTime.Now,
                    Statut = "En attente Validation",
                    Categorie = "Signalisation défectueuse",
                    Localisation = "RN44, PK 34, Manakara"
                }
            };

            dgSignalements.ItemsSource = signalements;
            txtTotalSignalements.Text = $"({signalements.Count} signalements)";
        }

        private void ChargerStatuts()
        {
            var statuts = new List<string>
            {
                "En attente Validation",
                "Validé",
                "Refusé",
                "En cours de traitement",
                "Résolu"
            };

            foreach (var statut in statuts)
            {
                cmbFiltreStatut.Items.Add(new ComboBoxItem { Content = statut });
            }
        }
    }
}
