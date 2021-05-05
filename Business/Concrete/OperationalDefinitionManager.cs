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
    public class OperationalDefinitionManager : IOperationalDefinitionService
    {
        private IOperationalDefinitionDal _operationalDefinitionDal;

        public OperationalDefinitionManager(IOperationalDefinitionDal operationalDefinitionDal)
        {
            _operationalDefinitionDal = operationalDefinitionDal;
        }

        public void Add(OperationalDefinition operationalDefinition)
        {
            ValidationTool.Validate(new OperationalDefinitionValidator(),operationalDefinition);
            _operationalDefinitionDal.Add(operationalDefinition);
        }

        public List<OperationalDefinition> GetAll()
        {
            return _operationalDefinitionDal.GetAll();
        }
    }
}
