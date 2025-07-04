

namespace _03._Orders
{
    internal class Program
    {
        class Product
        {
            public Product(string name, decimal price, decimal quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            internal void Update(decimal newPrice, decimal newQuantity)
            {
                Price = newPrice;
                Quantity += newQuantity;
            }
            public override string ToString()
            {
                return $"{Name} -> {TotalPrice():f2}";
            }

            private decimal TotalPrice()
            {
                return Price * Quantity;
            }

            static void Main(string[] args)
            {
                Dictionary<string, Product> products = new Dictionary<string, Product>();
                string input;
                while ((input = Console.ReadLine()) != "buy")
                {
                    string[] arguments = input.Split();
                    string name = arguments[0];
                    decimal price = decimal.Parse(arguments[1]);
                    decimal quantity = decimal.Parse(arguments[2]);

                    Product newProduct = new Product(name, price, quantity);
                    if (!products.ContainsKey(name))
                    {
                        products.Add(newProduct.Name, newProduct);
                    }
                    else
                    {
                        products[newProduct.Name].Update(newProduct.Price, newProduct.Quantity);
                    }
                }
                foreach (KeyValuePair<string, Product> productPair in products)
                {
                    Console.WriteLine(productPair.Value);
                }

            }
        }
    }
}
  
