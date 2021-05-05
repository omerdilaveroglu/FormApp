using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class WorkStation : IEntity
    {
        public int Id { get; set; }
        public string IsIstasyonKodu { get; set; }
        public string IstasyonAcıklama { get; set; }
        public string HammaddeAmbarı { get; set; }
        public decimal IstasyonMaliyeti { get; set; }
    }
}
