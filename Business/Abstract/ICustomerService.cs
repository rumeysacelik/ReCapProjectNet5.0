using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(int customerId);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);
    }
}
