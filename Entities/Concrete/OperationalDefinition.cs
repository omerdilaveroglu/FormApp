using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class OperationalDefinition :IEntity
    {
        public int Id { get; set; }
        public string OperasyonKodu { get; set; }
        public int ToplamOperasyonSuresi { get; set; }
        public int IslemSuresi { get; set; }
        public int BeklemeSuresi { get; set; }
        public int TasımaSuresi { get; set; }
        public string OperasyonAcıklama { get; set; }
    }
}
