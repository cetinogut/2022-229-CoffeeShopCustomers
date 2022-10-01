using CoffeeShopCustomers.Abstract;
using CoffeeShopCustomers.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace CoffeeShopCustomers.Adapters
{
    public class MernisServiceAdapter : ICustomerIdCheckService
    {
        bool idCheckResult = false;
        public bool CheckIfRealPerson(Customer customer)
        {
            var client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var clientIdCheckServiceResponse = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            idCheckResult = clientIdCheckServiceResponse.Body.TCKimlikNoDogrulaResult;

            return idCheckResult;
        }
    }
}
