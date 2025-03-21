using System;
using System.ComponentModel;
using System.Linq;

namespace NCina_C968_Assessment.Inventory
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        //total number of products/parts created (for indexing)
        public static int numProducts = 0;
        public static int numParts = 0;

        public Inventory() {}

        public static void addProduct(Product product)
        {
            Products.Add(product);
            numProducts++;
        }
        

        public static bool removeProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    Products.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }

            return new Product(); //not found
        }

        public static void updateProduct(int productID, Product product)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    p.AssociatedParts = product.AssociatedParts;
                    //ID remains unchanged
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.InStock = product.InStock;
                    p.Min = product.Min;
                    p.Max = product.Max;
                    return;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
            numParts++;
            return;
        }

        public static bool deletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }

            return new InHouse();
        }

        public static void updatePart(int partID, Part part)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    //must be re-added, can't account for inhouse/outsource type otherwise
                    AllParts.Remove(p);
                    AllParts.Add(part);
                    return;
                }
            }
        }
    }
}
