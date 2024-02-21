public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach(Product prod in _products)
        {
            totalPrice += prod.GetTotalCost();
        }
        if(_customer.IsInUSA() == true)
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
           
    }

    public void GetPackingLable()
    {
        foreach(Product prod in _products)
        {
            Console.WriteLine($"  {prod.GetProductName()}, {prod.GetProductId()}");
        }
        Console.WriteLine();
    }

    public void GetShippingLable()
    {
        Console.WriteLine($"  {_customer.GetCustomerName()}");
        Console.WriteLine($"  {_customer.GetCustomerAddress().GetAddress()}");
    }
}