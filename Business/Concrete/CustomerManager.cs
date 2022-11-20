using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public bool Add(Customer customer)
        {
            _customerDal.Add(customer);
            return true;
        }

        public bool GetCustomerTop5()
        {
            var data = _customerDal.Top5();
            return true;
        }
    }
}
