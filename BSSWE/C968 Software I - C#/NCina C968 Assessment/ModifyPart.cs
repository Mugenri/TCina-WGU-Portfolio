using System;
using System.Drawing;
using System.Windows.Forms;
using NCina_C968_Assessment.Inventory;

namespace NCina_C968_Assessment
{
    public partial class ModifyPart : Form
    {
        private Part MPart;

        public ModifyPart(Part part)
        {
            InitializeComponent();
            MPart = part;
        }

        private void UpdateFieldColor()
        {
            //all have text
            _ = nameBox.Text == "" ? nameBox.BackColor = Color.LightSalmon : nameBox.BackColor = Color.White;
            _ = priceBox.Text == "" ? priceBox.BackColor = Color.LightSalmon : priceBox.BackColor = Color.White;
            _ = inventoryBox.Text == "" ? inventoryBox.BackColor = Color.LightSalmon : inventoryBox.BackColor = Color.White;
            _ = minBox.Text == "" ? minBox.BackColor = Color.LightSalmon : minBox.BackColor = Color.White;
            _ = maxBox.Text == "" ? maxBox.BackColor = Color.LightSalmon : maxBox.BackColor = Color.White;
            _ = machineCompanyBox.Text == "" ? machineCompanyBox.BackColor = Color.LightSalmon : machineCompanyBox.BackColor = Color.White;
        }

        //Event Handling
        private void ModifyPart_Load(object sender, EventArgs e)
        {
            idBox.Text = $"{MPart.PartID}";
            nameBox.Text = $"{MPart.Name}";
            priceBox.Text = $"{MPart.Price}";
            inventoryBox.Text = $"{MPart.InStock}";
            minBox.Text = $"{MPart.Min}";
            maxBox.Text = $"{MPart.Max}";
            //Variable field
            if (MPart.GetType() == typeof(InHouse))
            {
                InHouse part = (InHouse)MPart;
                machineCompanyBox.Text = $"{part.MachineID}";
                inHouseRadio.Checked = true;
            }
            else
            {
                Outsourced part = (Outsourced)MPart;
                machineCompanyBox.Text = $"{part.CompanyName}";
                outsourcedRadio.Checked = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validate fields for saving
            try
            {
                int partId = int.Parse(idBox.Text);
                string name = nameBox.Text;
                decimal price = decimal.Parse(priceBox.Text);
                int inStock = int.Parse(inventoryBox.Text);
                int min = int.Parse(minBox.Text);
                int max = int.Parse(maxBox.Text);

                if (nameBox.Text == "")
                {
                    throw new ArgumentOutOfRangeException("Product Name Required.");
                }

                if (min > max)
                {
                    MessageBox.Show("Min/Max values are incorrect.");
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory out of range.");
                    return;
                }

                //save new part
                if (inHouseRadio.Checked)
                {
                    int machineId = int.Parse(machineCompanyBox.Text);
                    Inventory.Inventory.updatePart(partId, new InHouse(partId, name, price, inStock, min, max, machineId));
                }
                else
                {
                    string companyName = machineCompanyBox.Text;
                    Inventory.Inventory.updatePart(partId, new Outsourced(partId, name, price, inStock, min, max, companyName));
                }
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("One or more fields are incorrect.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Machine ID";
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Company Name";
        }

        private void ModifyPart_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Main().Show();
        }

        private void infoBoxes_TextChanged(object sender, EventArgs e)
        {
            UpdateFieldColor();
        }
    }
}
