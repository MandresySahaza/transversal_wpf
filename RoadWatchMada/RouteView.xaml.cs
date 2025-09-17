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
    /// Logique d'interaction pour RouteView.xaml
    /// </summary>
    public partial class RouteView : UserControl
    {
        public RouteView()
        {
            InitializeComponent();
            ChargerDonneesExemple();
            //ChargerRegions();
            //ChargerTypesRoute();
        }

        private void ChargerDonneesExemple()
        {
            var routes = new List<Route>
            {
                new Route { Id = 1, Nom = "RN2 - Antananarivo Toamasina" },
                new Route { Id = 2, Nom = "RN4 - Antananarivo Mahajanga" },
                new Route { Id = 3, Nom = "RN7 - Antananarivo Toliara"},
                new Route { Id = 4, Nom = "RN6 - Antsiranana Ambilobe" },
                new Route { Id = 5, Nom = "RN13 - Ihosy Farafangana" },
                //new Route { Id = 6, Nom = "RN10 - Morombe Toliara", Region = "Atsimo-Andrefana", TypeRoute = "Route Nationale" },
                //new Route { Id = 7, Nom = "RN44 - Fianarantsoa Manakara", Region = "Vatovavy", TypeRoute = "Route Nationale" },
                //new Route { Id = 8, Nom = "Route d'Antsirabe", Region = "Vakinankaratra", TypeRoute = "Route Régionale" },
                //new Route { Id = 9, Nom = "Route d'Ambatolampy", Region = "Vakinankaratra", TypeRoute = "Route Régionale" },
                //new Route { Id = 10, Nom = "Route de Moramanga", Region = "Alaotra-Mangoro", TypeRoute = "Route Régionale" },
                //new Route { Id = 11, Nom = "Route d'Antsiranana", Region = "Diana", TypeRoute = "Route Régionale" },
                //new Route { Id = 12, Nom = "Route de Nosy Be", Region = "Diana", TypeRoute = "Route Régionale" },
                //new Route { Id = 13, Nom = "Route de Fort Dauphin", Region = "Anosy", TypeRoute = "Route Régionale" },
                //new Route { Id = 14, Nom = "Route de Sambava", Region = "Sava", TypeRoute = "Route Régionale" },
                //new Route { Id = 15, Nom = "Route d'Antalaha", Region = "Sava", TypeRoute = "Route Régionale" }
            };

            dgRoutes.ItemsSource = routes;
            txtTotalRoutes.Text = $"({routes.Count} routes)";
        }

        //private void ChargerRegions()
        //{
        //    var regions = new List<string>
        //    {
        //        "Analamanga", "Vakinankaratra", "Itasy", "Bongolava", "Menabe",
        //        "Boeny", "Sofia", "Betsiboka", "Melaky", "Alaotra-Mangoro",
        //        "Atsinanana", "Analanjirofo", "Amoron'i Mania", "Haute Matsiatra",
        //        "Vatovavy", "Fitovinany", "Atsimo-Atsinanana", "Ihorombe",
        //        "Atsimo-Andrefana", "Androy", "Anosy", "Diana", "Sava"
        //    };

        //    foreach (var region in regions)
        //    {
        //        cmbFiltreRegion.Items.Add(new ComboBoxItem { Content = region });
        //    }
        //}

        //private void ChargerTypesRoute()
        //{
        //    var types = new List<string>
        //    {
        //        "Route Nationale", "Route Régionale", "Route Communale", "Route Rurale"
        //    };

        //    foreach (var type in types)
        //    {
        //        cmbFiltreType.Items.Add(new ComboBoxItem { Content = type });
        //    }
        //}
    }
}
