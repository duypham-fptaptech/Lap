using System;
using Customer;
using Order;


namespace Customer
{
    class CustomerName
    {
        public String customerName { get; set; }
    }
}

namespace Order
{   class GroceryItems
    {
        public void groceryItems()
        {
            Console.WriteLine("Grocery Items");
        }
    }

    class BakeryProducts
    {
        public void bakeryProducts()
        {
            Console.WriteLine("Bakery Products");
        }
    }
}
class Programs
{
    public static void Mains(string[] args)
    {
        CustomerName customerName = new CustomerName();
        customerName.customerName = "Customer";
        Console.WriteLine(customerName);

        Console.WriteLine("Customer has choice grocery items: ");
        GroceryItems groceryItems = new GroceryItems();
        groceryItems.groceryItems();
    }
}