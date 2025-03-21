namespace NCina_C968_Assessment.Inventory
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced() {}

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partId, name, price, inStock, min, max) {
            CompanyName = companyName;
        }
    }
}
