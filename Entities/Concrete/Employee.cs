using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string TcNo { get; set; }
        public string Gorevi { get; set; }
        public decimal BirimSaatMaliyeti { get; set; }
        public decimal AylıkMaliyeti { get; set; }
    }

}
