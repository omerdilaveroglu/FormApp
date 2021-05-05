using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPrescriptionService
    {
        List<Prescription> GetAll();
        void Add(Prescription prescription);
        void Update(Prescription prescription);
        void Delete(Prescription prescription);
    }
}
