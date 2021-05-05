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
    public class PrescriptionManager : IPrescriptionService
    {
        private IPrescriptionDal _prescriptionDal;

        public PrescriptionManager(IPrescriptionDal prescriptionDal)
        {
            _prescriptionDal = prescriptionDal;
        }

        public void Add(Prescription prescription)
        {
            ValidationTool.Validate(new PrescriptionValidator(),prescription);
            _prescriptionDal.Add(prescription);
        }

        public void Delete(Prescription prescription)
        {
            _prescriptionDal.Delete(prescription);
        }

        public List<Prescription> GetAll()
        {
            return _prescriptionDal.GetAll();
        }

        public void Update(Prescription prescription)
        {
            ValidationTool.Validate(new PrescriptionValidator(), prescription);
            _prescriptionDal.Update(prescription);
        }
    }
}
