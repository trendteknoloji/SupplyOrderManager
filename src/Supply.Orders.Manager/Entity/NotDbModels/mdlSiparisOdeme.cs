using Supply.Orders.Manager.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.NotDbModels
{
    public class mdlSiparisOdeme : mdlSiparis
    {
        public List<mdlOdeme> OdemeListesi { get; set; }
    }
}
