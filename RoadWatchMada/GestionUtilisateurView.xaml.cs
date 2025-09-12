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
    /// Logique d'interaction pour GestionUtilisateurView.xaml
    /// </summary>
    public partial class GestionUtilisateurView : UserControl
    {
        private List<Utilisateur> _tousUtilisateurs;
        private int _pageCourante = 1;
        private const int _itemsParPage = 5;

        public GestionUtilisateurView()
        {
            InitializeComponent();
            ChargerUtilisateurs();
            AfficherUtilisateurs();
        }

        private void ChargerUtilisateurs()
        {
            // Données d'exemple avec des noms malgaches
            _tousUtilisateurs = new List<Utilisateur>
            {
                new Utilisateur { Id = 1, Nom = "Rakoto", Prenom = "Jean", DateNaissance = new DateTime(1985, 5, 15), Email = "jean.rakoto@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 2, Nom = "Rasoa", Prenom = "Marie", DateNaissance = new DateTime(1990, 8, 22), Email = "marie.rasoa@mail.mg", Profil = "Responsable" },
                new Utilisateur { Id = 3, Nom = "Randria", Prenom = "Paul", DateNaissance = new DateTime(1988, 3, 10), Email = "paul.randria@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 4, Nom = "Razafy", Prenom = "Lucie", DateNaissance = new DateTime(1992, 12, 5), Email = "lucie.razafy@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 5, Nom = "Andriana", Prenom = "Pierre", DateNaissance = new DateTime(1980, 7, 18), Email = "pierre.andriana@mail.mg", Profil = "Responsable" },
                new Utilisateur { Id = 6, Nom = "Ramananto", Prenom = "Sophie", DateNaissance = new DateTime(1995, 2, 28), Email = "sophie.ramananto@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 7, Nom = "Rajaona", Prenom = "Marc", DateNaissance = new DateTime(1987, 9, 14), Email = "marc.rajaona@mail.mg", Profil = "Responsable" },
                new Utilisateur { Id = 8, Nom = "Ravelo", Prenom = "Nirina", DateNaissance = new DateTime(1993, 6, 30), Email = "nirina.ravelo@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 9, Nom = "Ratsima", Prenom = "Hery", DateNaissance = new DateTime(1983, 11, 8), Email = "hery.ratsima@mail.mg", Profil = "Public" },
                new Utilisateur { Id = 10, Nom = "Randrianarisoa", Prenom = "Lala", DateNaissance = new DateTime(1991, 4, 17), Email = "lala.randrianarisoa@mail.mg", Profil = "Responsable" }
            };
        }

        private void AfficherUtilisateurs()
        {
            var utilisateursPage = _tousUtilisateurs
                .Skip((_pageCourante - 1) * _itemsParPage)
                .Take(_itemsParPage)
                .ToList();

            dgUtilisateurs.ItemsSource = utilisateursPage;

            // Mise à jour de la pagination
            int totalPages = (int)Math.Ceiling((double)_tousUtilisateurs.Count / _itemsParPage);
            txtPageCourante.Text = _pageCourante.ToString();
            txtTotalPages.Text = totalPages.ToString();

            // Gestion des boutons de navigation
            UpdatePaginationButtons(totalPages);
        }

        private void UpdatePaginationButtons(int totalPages)
        {
            // Implémentation pour désactiver les boutons quand nécessaire
        }

        // Gestion des événements de pagination
        private void BtnPremier_Click(object sender, RoutedEventArgs e)
        {
            _pageCourante = 1;
            AfficherUtilisateurs();
        }

        private void BtnPrecedent_Click(object sender, RoutedEventArgs e)
        {
            if (_pageCourante > 1)
            {
                _pageCourante--;
                AfficherUtilisateurs();
            }
        }

        private void BtnSuivant_Click(object sender, RoutedEventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_tousUtilisateurs.Count / _itemsParPage);
            if (_pageCourante < totalPages)
            {
                _pageCourante++;
                AfficherUtilisateurs();
            }
        }

        private void BtnDernier_Click(object sender, RoutedEventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_tousUtilisateurs.Count / _itemsParPage);
            _pageCourante = totalPages;
            AfficherUtilisateurs();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var utilisateur = button?.DataContext as Utilisateur;
            if (utilisateur != null)
            {
                MessageBox.Show($"Modification de l'utilisateur: {utilisateur.Nom} {utilisateur.Prenom}");
            }
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var utilisateur = button?.DataContext as Utilisateur;
            if (utilisateur != null)
            {
                var result = MessageBox.Show($"Voulez-vous vraiment supprimer {utilisateur.Nom} {utilisateur.Prenom} ?",
                    "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Utilisateur supprimé (simulation)");
                }
            }
        }

    }
}
