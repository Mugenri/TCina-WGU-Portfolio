using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NCina_C968_Assessment.Inventory;

namespace NCina_C968_Assessment
{
    public partial class AddProduct : Form
    {
        private Product newProduct = new Product();

        public AddProduct()
        {
            InitializeComponent();
            UpdateFieldColor();
        }

        private void UpdateFieldColor()
        {
            //all have text
            _ = nameBox.Text == "" ? nameBox.BackColor = Color.LightSalmon : nameBox.BackColor = Color.White;
            _ = priceBox.Text == "" ? priceBox.BackColor = Color.LightSalmon : priceBox.BackColor = Color.White;
            _ = inventoryBox.Text == "" ? inventoryBox.BackColor = Color.LightSalmon : inventoryBox.BackColor = Color.White;
            _ = minBox.Text == "" ? minBox.BackColor = Color.LightSalmon : minBox.BackColor = Color.White;
            _ = maxBox.Text == "" ? maxBox.BackColor = Color.LightSalmon : maxBox.BackColor = Color.White;
        }

        //Event Handling
        private void AddProduct_Load(object sender, EventArgs e)
        {
            idBox.Text = $"{Inventory.Inventory.numProducts + 1}";
            candidateList.DataSource = Inventory.Inventory.AllParts;
            associatedPartsList.DataSource = newProduct.AssociatedParts;
            candidateList.ClearSelection();
            associatedPartsList.ClearSelection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validate fields for saving
            try
            {
                int productId = int.Parse(idBox.Text);
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

                //add text info to product
                newProduct.ProductID = productId;
                newProduct.Name = name;
                newProduct.Price = price;
                newProduct.InStock = inStock;
                newProduct.Min = min;
                newProduct.Max = max;

                Inventory.Inventory.addProduct(newProduct);
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("One or more fields are incorrect.");
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (candidateList.SelectedRows.Count > 0)
                {
                    Part newPart = (Part)candidateList.CurrentRow.DataBoundItem;
                    if (!newProduct.AssociatedParts.Contains(newPart)) //no duplicates
                    {
                        newProduct.addAssociatedPart(newPart);
                        candidateList.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add duplicate parts to product.");
                        candidateList.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (associatedPartsList.SelectedRows.Count > 0)
                {
                    //confirm remove messagebox
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this part?", "Remove Part", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Part newPart = (Part)associatedPartsList.CurrentRow.DataBoundItem;
                        newProduct.removeAssociatedPart(newPart.PartID);
                        associatedPartsList.ClearSelection();
                    }
                    else
                    {
                        associatedPartsList.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Main().Show();
        }

        private void infoBoxes_TextChanged(object sender, EventArgs e)
        {
            UpdateFieldColor();
        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {
            //search part by id
            //OR return messagebox if none found
            candidateList.ClearSelection();
            try
            {
                int partId = int.Parse(searchPartBox.Text);
                Part partToFind = Inventory.Inventory.lookupPart(partId);

                foreach (DataGridViewRow row in candidateList.Rows)
                {
                    if (row.DataBoundItem == partToFind)
                    {
                        row.Selected = true;
                        return;
                    }
                }
                MessageBox.Show("Part ID not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}