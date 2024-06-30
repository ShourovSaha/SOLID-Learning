using SRP.Data;
using SRP.Models;

namespace SRP.Services
{
    public class CustomerSearch
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerSearch(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Customer> SearchByCountry(string country)
        {
            var customers = _dbContext.Customers.Where(x => x.Country.Contains(country))
                                                .OrderBy(x => x.CustomerID)
                                                .ToList();
            return customers;
        }

        public List<Customer> SearchByComapanyName(string companyName)
        {
            var customers = _dbContext.Customers.Where(x => x.CompanyName.Contains(companyName))
                                                .OrderBy(x =>x.CustomerID)
                                                .ToList();
            return customers;
        }
    }
}
