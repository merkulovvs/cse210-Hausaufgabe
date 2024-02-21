using System.Diagnostics.Contracts;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }


    public bool IsInUSA()
    {
        if(this._address.GetCountry().ToLower() == "usa")
        {
            return true;
        }
        
        else
        {
            return false;
        }

    }

    
    
    
    

}