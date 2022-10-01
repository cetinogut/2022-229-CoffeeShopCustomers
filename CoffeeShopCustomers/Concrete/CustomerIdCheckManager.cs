using CoffeeShopCustomers.Abstract;
using CoffeeShopCustomers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomers.Concrete
{
    public class CustomerIdCheckManager : ICustomerIdCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(); // if we do this operation here, than we are prone to Mernis.
            //İf mernis stops our program salso stops, which is not good at s
            return true;
        }
    }
}
