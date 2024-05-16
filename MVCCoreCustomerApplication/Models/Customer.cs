namespace MVCCoreCustomerApplication.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }

        public string CustomerAmount { get; set; }

        public decimal CustomerCode { get; set; }
    }

    public class GoldCustomer : Customer
    {

    }

    public class DiscountedCustomer : Customer
    {

    }
}
