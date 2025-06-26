using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "12345678910")
                return new Customer("Ronaldo Domingues", "ronaldo@email.com");

            return null;
        }
    }
}
