using CoffeeShopCustomers.Abstract;
using CoffeeShopCustomers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomers.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private readonly ICustomerIdCheckService _customerIdCheckService;

        public StarbucksCustomerManager(ICustomerIdCheckService customerIdCheckService)
        {
            _customerIdCheckService = customerIdCheckService;
        }
        public override void Save(Customer customer)
        {
            //Mernis ID check
            if (_customerIdCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid Id. Please check the Id Number");
                //throw new Exception("Not a valid person");
            }
        }
    }
}
