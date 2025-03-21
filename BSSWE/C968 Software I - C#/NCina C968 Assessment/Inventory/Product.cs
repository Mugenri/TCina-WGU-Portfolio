using System.ComponentModel;

namespace NCina_C968_Assessment.Inventory
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() {}

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partID) {
                    AssociatedParts.Remove(p);
                    return true;
                }
            }

            return false; //not found
        }

        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }

            return new InHouse(); //not found
        }
    }
}
