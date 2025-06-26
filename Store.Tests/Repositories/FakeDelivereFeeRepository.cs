using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDelivereFeeRepository : IDeliveryFeeRepository
    {
        public decimal Get(string zipCode)
        {
            return 10;
        }
    }
}
