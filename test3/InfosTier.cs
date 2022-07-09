using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace test3 
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class InfosTier
    {
        [JsonProperty("TypeTiers")]
        public int TypeTiers { get; set; }

        [JsonProperty("NumeroTiers")]
        public string NumeroTiers { get; set; }

        [JsonProperty("NumeroTiersPayeur")]
        public string NumeroTiersPayeur { get; set; }

        [JsonProperty("IdCategorieComptable")]
        public int IdCategorieComptable { get; set; }

        [JsonProperty("IdCategorieTarifaire")]
        public int IdCategorieTarifaire { get; set; }

        [JsonProperty("IdModeleReglement")]
        public int IdModeleReglement { get; set; }

        [JsonProperty("Intitule")]
        public string Intitule { get; set; }

        [JsonProperty("Qualite")]
        public string Qualite { get; set; }

        [JsonProperty("Abrege")]
        public string Abrege { get; set; }

        [JsonProperty("Contact")]
        public string Contact { get; set; }

        [JsonProperty("CompteCollectif")]
        public string CompteCollectif { get; set; }

        [JsonProperty("Adresse")]
        public string Adresse { get; set; }

        [JsonProperty("Complement")]
        public string Complement { get; set; }

        [JsonProperty("CodePostal")]
        public string CodePostal { get; set; }

        [JsonProperty("Ville")]
        public string Ville { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Pays")]
        public string Pays { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("SiteWeb")]
        public string SiteWeb { get; set; }

        [JsonProperty("NumeroSiret")]
        public string NumeroSiret { get; set; }

        [JsonProperty("NumeroTva")]
        public string NumeroTva { get; set; }

        [JsonProperty("CodeEdi")]
        public string CodeEdi { get; set; }

        [JsonProperty("CodeNAF")]
        public string CodeNAF { get; set; }

        [JsonProperty("Commentaire")]
        public string Commentaire { get; set; }

        [JsonProperty("Langue")]
        public int Langue { get; set; }

        [JsonProperty("EstEnSommeil")]
        public bool EstEnSommeil { get; set; }

        [JsonProperty("IdDepot")]
        public int IdDepot { get; set; }

        [JsonProperty("NumeroCentraleAchat")]
        public object NumeroCentraleAchat { get; set; }

        [JsonProperty("CessionCreance")]
        public bool CessionCreance { get; set; }

        [JsonProperty("EncoursAutorise")]
        public double EncoursAutorise { get; set; }

        [JsonProperty("IdRisque")]
        public int IdRisque { get; set; }

        [JsonProperty("ModeControleEnCours")]
        public int ModeControleEnCours { get; set; }

        [JsonProperty("AutomatiserEcritureMultiEcheances")]
        public bool AutomatiserEcritureMultiEcheances { get; set; }

        [JsonProperty("AutorisationLettrageAutomatique")]
        public bool AutorisationLettrageAutomatique { get; set; }

        [JsonProperty("ExclureRappelsReleve")]
        public bool ExclureRappelsReleve { get; set; }

        [JsonProperty("Facebook")]
        public string Facebook { get; set; }

        [JsonProperty("LinkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("InfosLibres")]
        public List<InfosLibre> InfosLibres { get; set; }

        [JsonProperty("Createur")]
        public string Createur { get; set; }

        [JsonProperty("DateModification")]
        public DateTime DateModification { get; set; }

        [JsonProperty("ExclureTraitementMarketing")]
        public bool ExclureTraitementMarketing { get; set; }

        [JsonProperty("GDPRActif")]
        public bool GDPRActif { get; set; }

        [JsonProperty("IdDevise")]
        public int IdDevise { get; set; }

        [JsonProperty("Statistique01")]
        public string Statistique01 { get; set; }

        [JsonProperty("Statistique02")]
        public string Statistique02 { get; set; }

        [JsonProperty("Statistique03")]
        public string Statistique03 { get; set; }

        [JsonProperty("Statistique04")]
        public string Statistique04 { get; set; }

        [JsonProperty("Statistique05")]
        public string Statistique05 { get; set; }

        [JsonProperty("Statistique06")]
        public string Statistique06 { get; set; }

        [JsonProperty("Statistique07")]
        public string Statistique07 { get; set; }

        [JsonProperty("Statistique08")]
        public string Statistique08 { get; set; }

        [JsonProperty("Statistique09")]
        public string Statistique09 { get; set; }

        [JsonProperty("Statistique10")]
        public string Statistique10 { get; set; }

        [JsonProperty("Facture")]
        public int Facture { get; set; }

        [JsonProperty("Saut")]
        public bool Saut { get; set; }

        [JsonProperty("Analytique")]
        public int Analytique { get; set; }

        [JsonProperty("CodeAffaire")]
        public string CodeAffaire { get; set; }

        [JsonProperty("DateCreation")]
        public DateTime DateCreation { get; set; }

        [JsonProperty("UtilisateurCreateur")]
        public object UtilisateurCreateur { get; set; }
    }
    public class InfosLibre
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public int Type { get; set; }

        [JsonProperty("Size")]
        public int Size { get; set; }

        [JsonProperty("EstCalculee")]
        public bool EstCalculee { get; set; }

        [JsonProperty("Value")]
        public object Value { get; set; }
    }
}
