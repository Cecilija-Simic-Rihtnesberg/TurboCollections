using System;
using TurboCollections;

namespace CustomerManagement

{
    
    public class CustomerManager
    {
        private IDataAccess dataAccess;

        public CustomerManager(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Customer GetCustomer(int id)
        {
            return this.dataAccess.GetCustomer(id);
        }

        public void SaveCustomer(Customer customer)
        {
            this.dataAccess.SaveCustomer(customer);
        }
    }

    public class Customer
    {
    }

    public interface IDataAccess
    {
        Customer GetCustomer(int id);
        void SaveCustomer(Customer customer);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var turbolist = new TurboList<float>();
        }
    }
    

}