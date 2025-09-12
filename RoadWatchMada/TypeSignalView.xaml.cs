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
    /// Logique d'interaction pour TypeSignalView.xaml
    /// </summary>
    public partial class TypeSignalView : UserControl
    {
        public TypeSignalView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
            ChargerCategories();
        }

        private void ChargerDonneesExemple()
        {
            var typesSignal = new List<TypeSignal>
            {
                new TypeSignal { Id = 1, Nom = "Nid-de-poule", Description = "Trou dans la chaussée", Categorie = "Route endommagée" },
                new TypeSignal { Id = 2, Nom = "Fissure", Description = "Fissure importante sur la route", Categorie = "Route endommagée" },
                new TypeSignal { Id = 3, Nom = "Chaussée déformée", Description = "Déformation de la surface routière", Categorie = "Route endommagée" },
                new TypeSignal { Id = 4, Nom = "Collision", Description = "Accident entre véhicules", Categorie = "Accident" },
                new TypeSignal { Id = 5, Nom = "Sortie de route", Description = "Véhicule quittant la chaussée", Categorie = "Accident" },
                //new TypeSignal { Id = 6, Nom = "Arbre tombé", Description = "Arbre obstruant la voie", Categorie = "Obstacle" },
                //new TypeSignal { Id = 7, Nom = "Débris", Description = "Objets sur la chaussée", Categorie = "Obstacle" },
                //new TypeSignal { Id = 8, Nom = "Inondation mineure", Description = "Eau sur chaussée", Categorie = "Inondation" },
                //new TypeSignal { Id = 9, Nom = "Inondation majeure", Description = "Route impraticable", Categorie = "Inondation" },
                //new TypeSignal { Id = 10, Nom = "Éboulement rocheux", Description = "Chute de pierres", Categorie = "Éboulement" }
            };

            dgTypesSignal.ItemsSource = typesSignal;
            txtTotalTypes.Text = $"({typesSignal.Count} types)";
        }

        private void ChargerCategories()
        {
            // Ajouter les catégories au ComboBox de filtre
            cmbFiltreCategorie.Items.Add(new ComboBoxItem { Content = "Route endommagée" });
            cmbFiltreCategorie.Items.Add(new ComboBoxItem { Content = "Accident" });
            cmbFiltreCategorie.Items.Add(new ComboBoxItem { Content = "Obstacle" });
            cmbFiltreCategorie.Items.Add(new ComboBoxItem { Content = "Inondation" });
            cmbFiltreCategorie.Items.Add(new ComboBoxItem { Content = "Éboulement" });
        }
    }
}
