using CoffeeShopCustomers.Abstract;
using CoffeeShopCustomers.Adapters;
using CoffeeShopCustomers.Concrete;
using CoffeeShopCustomers.Entities;
using System;

namespace CoffeeShopCustomers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //BaseCustomerManager customerManager = new KahveDunyasiCustomerManager(); KAveDunyasi does not require IDCheck
            // BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerIdCheckManager()); // this is for our local study, no mernis check reuslt, returns true automatically
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1970,02,14), FirstName="Ahmet", LastName="Gozde", Id=1, NationalId="12345"});
        }
    }
}
