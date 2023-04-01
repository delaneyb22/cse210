using System;
using System.Collections.Generic;

class ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Product 1", "001", 15.00, 10);
            Product product2 = new Product("Product 2", "002", 7.00, 5);

            
            Address customer1Address = new Address("100 Woodlawn St.", "Forks", "WA", "USA");
            Customer customer1 = new Customer("John Smith", customer1Address);

            Address customer2Address = new Address("854 Oakland Ave.", "Smallville", "ON", "Canada");
            Customer customer2 = new Customer("Jane Doe", customer2Address);

           
            Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
            Order order2 = new Order(new List<Product> { product1 }, customer2);

            Console.WriteLine("Order 1 packing label:\n" + order1.GetPackingLabel());
            Console.WriteLine("Order 1 shipping label:\n" + order1.GetShippingLabel());
            Console.WriteLine("Order 1 total price: $" + order1.GetTotalCost());

            Console.WriteLine("Order 2 packing label:\n" + order2.GetPackingLabel());
            Console.WriteLine("Order 2 shipping label:\n" + order2.GetShippingLabel());
            Console.WriteLine("Order 2 total price: $" + order2.GetTotalCost());

            Console.ReadLine();
        }
    }
   class Order {
    private Product[] products;
    private Customer customer;

    public Order(Product[] products, Customer customer) {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalCost() {
        double totalCost = 0;
        foreach (Product product in products) {
            totalCost += product.GetPrice();
        }
        if (customer.IsInUSA()) {
            totalCost += 5;
        } else {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += product.GetName() + " (ID: " + product.GetId() + ")\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() {
        Customer customer = this.customer;
        string shippingLabel = customer.GetName() + "\n" + customer.GetAddress().GetAddressString();
        return shippingLabel;
    }
}


    class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetTotalPrice()
        {
            return price * quantity;
        }
    }

    class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string StateProvince
        {
            get { return stateProvince; }
            set { stateProvince = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public bool IsInUSA()
        {
            return country.Equals("USA");
        }

        public override string ToString()
        {
            return street
        }
    }
    class Customer{
        private string name;
        private Address address;

           public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }


    }
}