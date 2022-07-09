using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;
using WebServices100.ServiceContracts.ServiceContract;

namespace test3
{
    internal class ViewModel
    {
        public ObservableCollection<InfosTier> InfosTiers { get; set; }
    }
}
