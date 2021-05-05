using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Prescription :IEntity
    {
        public int Id { get; set; }
        public string AnaUrunKodu { get; set; }
        public int MiktarSayısı { get; set; }
        public int SatırSayısı { get; set; }
        public string Acıklama { get; set; }
    }
}
