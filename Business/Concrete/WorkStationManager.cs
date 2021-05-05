using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrate
{
    public class WorkStationManager : IWorkStationService
    {
        private IWorkStationDal _workStationDal;

        public WorkStationManager(IWorkStationDal workStationDal)
        {
            _workStationDal = workStationDal;
        }

        public void Add(WorkStation workStation)
        {
            ValidationTool.Validate(new WorkStationValidator(),workStation);
            _workStationDal.Add(workStation);
        }

        public void Delete(WorkStation workStation)
        {
            _workStationDal.Delete(workStation);
        }

        public List<WorkStation> GetAll()
        {
            return _workStationDal.GetAll();
        }

        public void Update(WorkStation workStation)
        {
            ValidationTool.Validate(new WorkStationValidator(), workStation);
            _workStationDal.Update(workStation);
        }
    }
}
