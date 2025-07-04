namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string line = default;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);


                Item item = new Item(itemName, price);
                Box box = new Box(serialNumber, item, quantity);
              
                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();
            
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
             
            }

        }
        class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }

            public decimal Price { get; set; }

        }

        class Box
        {
            public Box(string serialNumber, Item item, int itemQuantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
            }

            public string SerialNumber { get; set; }
            
            public Item Item { get; set; }
            
            public int ItemQuantity { get; set; }

            public decimal BoxPrice => ItemQuantity * Item.Price;


        }
        
    }
}
