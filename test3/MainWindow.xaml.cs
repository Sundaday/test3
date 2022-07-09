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
        private ObservableCollection<InfosTier> infos;
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
        public List<InfosTier> GetTier()
        {
            InfosTier infosTier = new InfosTier();
            try
            {
                ITiersService service = new TiersService("http://localhost:12345/Webservices100/BIJOU/");
                List<Client> clients = service.ClientsList(1, 1);
                var jsonString = JsonConvert.SerializeObject(clients);
                //const string clientAsText = "[{\"TypeTiers\":0,\"NumeroTiers\":\"BAGUES\",\"NumeroTiersPayeur\":\"BAGUES\",\"IdCategorieComptable\":1,\"IdCategorieTarifaire\":1,\"IdModeleReglement\":4,\"Intitule\":\"Bague'senor\",\"Qualite\":\"\",\"Abrege\":\"Bague'senor\",\"Contact\":\"MlleLeeOndine\",\"CompteCollectif\":\"4110000\",\"Adresse\":\"RuetêtedOr\",\"Complement\":\"BP65993\",\"CodePostal\":\"57000\",\"Ville\":\"Metz\",\"Region\":\"Lorraine\",\"Pays\":\"France\",\"Telephone\":\"0665870000\",\"Fax\":\"0665870001\",\"Email\":\"bagues@bagues.fr\",\"SiteWeb\":\"bagues.com\",\"NumeroSiret\":\"02556852465474\",\"NumeroTva\":\"546789\",\"CodeEdi\":\"\",\"CodeNAF\":\"32.12Z\",\"Commentaire\":\"\",\"Langue\":0,\"EstEnSommeil\":false,\"IdDepot\":0,\"NumeroCentraleAchat\":null,\"CessionCreance\":false,\"EncoursAutorise\":50000.000000,\"IdRisque\":1,\"ModeControleEnCours\":0,\"AutomatiserEcritureMultiEcheances\":false,\"AutorisationLettrageAutomatique\":true,\"ExclureRappelsReleve\":false,\"Facebook\":\"\",\"LinkedIn\":\"\",\"InfosLibres\":[{\"Name\":\"Datecréationsociété\",\"Type\":2,\"Size\":0,\"EstCalculee\":false,\"Value\":\"/Date(549496800000+0200)/\"},{\"Name\":\"Capitalsocial\",\"Type\":3,\"Size\":0,\"EstCalculee\":false,\"Value\":0.000000},{\"Name\":\"ActionnairePal\",\"Type\":0,\"Size\":69,\"EstCalculee\":false,\"Value\":\"\"},{\"Name\":\"ScoreBanquedeFrance\",\"Type\":0,\"Size\":14,\"EstCalculee\":false,\"Value\":\"\"},{\"Name\":\"Totalpointsfidélité\",\"Type\":3,\"Size\":0,\"EstCalculee\":true,\"Value\":0.000000},{\"Name\":\"Pointsfidélitérestants\",\"Type\":3,\"Size\":0,\"EstCalculee\":true,\"Value\":0.000000},{\"Name\":\"Finvaliditécartefidélité\",\"Type\":1,\"Size\":0,\"EstCalculee\":false,\"Value\":\"/Date(1199055600000+0100)/\"},{\"Name\":\"Datenégociationrèglement\",\"Type\":2,\"Size\":0,\"EstCalculee\":false,\"Value\":\"/Date(1214776800000+0200)/\"},{\"Name\":\"TauxEscompteDefaut\",\"Type\":3,\"Size\":0,\"EstCalculee\":false,\"Value\":null},{\"Name\":\"Délaiescompteenjours\",\"Type\":3,\"Size\":0,\"EstCalculee\":false,\"Value\":null}],\"Createur\":\"ERP1\",\"DateModification\":\"/Date(1567675116000+0200)/\",\"ExclureTraitementMarketing\":false,\"GDPRActif\":false,\"IdDevise\":0,\"Statistique01\":\"Est\",\"Statistique02\":\"\",\"Statistique03\":\"\",\"Statistique04\":\"\",\"Statistique05\":\"\",\"Statistique06\":\"\",\"Statistique07\":\"\",\"Statistique08\":\"\",\"Statistique09\":\"\",\"Statistique10\":\"\",\"Facture\":1,\"Saut\":true,\"Analytique\":3,\"CodeAffaire\":\"953INDE\",\"DateCreation\":\"/Date(1104706800000+0100)/\",\"UtilisateurCreateur\":null}]";
                List<InfosTier> infosTiers = JsonConvert.DeserializeObject<List<InfosTier>>(jsonString);
                return myDeserializedClass;
            }catch (Exception ex)
            {

            }
        }
    }
}