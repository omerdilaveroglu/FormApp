using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IWorkStationService
    {
        List<WorkStation> GetAll();
        void Add(WorkStation workStation);
        void Update(WorkStation workStation);
        void Delete(WorkStation workStation);
    }
}
