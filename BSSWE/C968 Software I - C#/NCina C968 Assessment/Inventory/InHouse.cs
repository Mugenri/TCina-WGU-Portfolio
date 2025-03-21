namespace NCina_C968_Assessment.Inventory
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse() {}

        public InHouse(int partId, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partId, name, price, inStock, min, max) {
            MachineID = machineID;
        }

    }
}
