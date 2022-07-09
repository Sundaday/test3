using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
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
using WebServices100.Model.DataContract;
using WebServices100.Proxy;
using WebServices100.ServiceContracts.ServiceContract;

namespace test3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            
            #region viewModelTest1
            this.viewModel = new ViewModel
            {
                InfosTiers = new ObservableCollection<InfosTier>
                {
                    new InfosTier
                    {
                        TypeTiers = 1,
                        Contact = "gfdbdsb",
                        Adresse = "fdbdfb",
                        CodePostal = "12345",
                        Ville = "gfebb",
                        Pays = "fnkdbknfb",
                        Telephone = "0515351351",
                        IdCategorieComptable = 1,
                        IdCategorieTarifaire = 1
                    },
                    new InfosTier
                    {
                        TypeTiers = 2,
                        Contact = "gfdbdsb",
                        Adresse = "fdbdfb",
                        CodePostal = "12345",
                        Ville = "gfebb",
                        Pays = "fnkdbknfb",
                        Telephone = "0515351351",
                        IdCategorieComptable = 2,
                        IdCategorieTarifaire = 2
                    },
                    new InfosTier
                    {
                        TypeTiers = 3,
                        Contact = "gfdbdsb",
                        Adresse = "fdbdfb",
                        CodePostal = "12345",
                        Ville = "gfebb",
                        Pays = "fnkdbknfb",
                        Telephone = "0515351351",
                        IdCategorieComptable = 3,
                        IdCategorieTarifaire = 3
                    }
                }
            };
            this.DataContext = this.viewModel; ;
            #endregion 
        }

        private void SeeData(object sender, RoutedEventArgs e)
        {
            
        }
        
    }
}