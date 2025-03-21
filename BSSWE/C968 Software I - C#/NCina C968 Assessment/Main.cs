using System;
using System.Windows.Forms;
using NCina_C968_Assessment.Inventory;

namespace NCina_C968_Assessment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Event Handling
        private void Main_Load(object sender, EventArgs e)
        {
            partsList.DataSource = Inventory.Inventory.AllParts;
            productsList.DataSource = Inventory.Inventory.Products;
            partsList.ClearSelection();
            productsList.ClearSelection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            new AddPart().Show();
            Hide();
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            //validate part is selected
            try
            {
                if (partsList.SelectedRows.Count > 0)
                {
                    new ModifyPart((Part)partsList.CurrentRow.DataBoundItem).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("No part selected");
                    partsList.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            //validate part is selected
            try
            {
                if (partsList.SelectedRows.Count > 0)
                {
                    //confirm delete messagebox
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) { 
                        Inventory.Inventory.deletePart((Part)partsList.CurrentRow.DataBoundItem);
                        partsList.ClearSelection();
                    }
                    else
                    {
                        partsList.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("No part selected");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new AddProduct().Show();
            Hide();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            //validate a product is selected
            try
            {
                if (productsList.SelectedRows.Count > 0)
                {
                    Product selected = (Product)productsList.CurrentRow.DataBoundItem;
                    new ModifyProduct(selected).Show();
                    Hide();
                } 
                else
                {
                    MessageBox.Show("No product selected.");
                    productsList.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsList.SelectedRows.Count > 0)
                {
                    Product product = (Product)productsList.CurrentRow.DataBoundItem;
                    if (product.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot remove a product that still has parts associated with it.");
                        return;
                    }
                    else
                    {
                        //confirm delete messagebox
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Inventory.Inventory.removeProduct(product.ProductID);
                            productsList.ClearSelection();
                        }
                        else
                        {
                            productsList.ClearSelection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No product selected");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {
            //search part by id
            //OR return messagebox if none found
            partsList.ClearSelection();
            try
            {
                int partId = int.Parse(searchPartBox.Text);
                Part partToFind = Inventory.Inventory.lookupPart(partId);

                foreach (DataGridViewRow row in partsList.Rows) {
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

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            //search product by id
            //OR return messagebox if none found
            productsList.ClearSelection();
            try
            {
                int productId = int.Parse(searchProductBox.Text);
                Product productToFind = Inventory.Inventory.lookupProduct(productId);

                foreach (DataGridViewRow row in productsList.Rows)
                {
                    if (row.DataBoundItem == productToFind)
                    {
                        row.Selected = true;
                        return;
                    }
                }
                MessageBox.Show("Product ID not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
