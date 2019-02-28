using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampingWorld
{
    public partial class Form1 : Form
    {
        private Item currItem;

        public Form1()
        {
            InitializeComponent();
            Item.InitializeDB();
        }

        public void LoadAll()
        {
            List<Item> items = Item.GetItems();
            LVinventory.Items.Clear();
            foreach(Item i in items)
            {
                ListViewItem item = new ListViewItem(new string[] { i.ID.ToString(), i.Name, i.Description, i.Cost.ToString(), i.DateAcquired.ToString("MM/dd/yyyy"), i.Quantity.ToString() });
                item.Tag = i;
                LVinventory.Items.Add(item);
            }
        }

        public void LoadAllSales()
        {
            List<Item> items = Item.GetSalesItems();
            LVSales.Items.Clear();
            foreach (Item i in items)
            {
                ListViewItem item = new ListViewItem(new string[] { i.ID.ToString(), i.Name, i.Description, i.Cost.ToString(), i.DateAcquired.ToString("MM/dd/yyyy"), i.Quantity.ToString() });
                item.Tag = i;
                LVSales.Items.Add(item);
            }
        }

        public void LoadCart()
        {
            LVSales.Items.Clear();
            foreach(ListViewItem item in CartList)
            {
                LVSales.Items.Add(item);
            }
        }

        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void buttonAddForm_Click(object sender, EventArgs e)
        {
            Add changeForm = new Add();
            changeForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LVinventory.SelectedItems[0].Text);
            currItem = new Item();
            currItem.Remove(id);
            LoadAll();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Update UpdateForm = new Update(currItem);
            UpdateForm.Show();
        }

        private void LVinventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LVinventory.SelectedItems.Count > 0)
            {
                ListViewItem selection = LVinventory.SelectedItems[0];

                currItem = (Item)selection.Tag;
            }
        }

        public List<ListViewItem> CartList = new List<ListViewItem>();

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LVinventory.SelectedItems[0].Text);
            string name = currItem.Name;
            string description = currItem.Description;
            decimal cost = Convert.ToDecimal(currItem.Cost);
            DateTime dateAcquired = currItem.DateAcquired;
            DateTime dateSold = DateTime.Now;
            int quantityChange;
            
            if(string.IsNullOrWhiteSpace(tbSaleQuantity.Text) == true)
            {
                MessageBox.Show("Quantity can not be blank");
            }
            else
            {
                quantityChange = Convert.ToInt32(tbSaleQuantity.Text);
                int quantity = Convert.ToInt32(currItem.Quantity) - quantityChange;

                if (quantity >= 0)
                {
                    currItem.Change(id, name, description, cost, dateAcquired, quantity);
                    LoadAll();

                    currItem = Item.InsertIntoSales(id, name, description, cost, dateSold, quantityChange);

                    ListViewItem i = new ListViewItem(new string[] { currItem.ID.ToString(), currItem.Name, currItem.Description, currItem.Cost.ToString(), currItem.DateAcquired.ToString("MM/dd/yyyy"), currItem.Quantity.ToString() });
                    CartList.Add(i);
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Not enough inventory in stock");
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            LVSales.Items.Clear();
            MessageBox.Show("checkout not included in this app");
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {

        }
    }
}
