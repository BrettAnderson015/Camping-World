using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampingWorld
{
    public partial class Add : Form
    {
        private Item currItem;

        public Add()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int searchid = Convert.ToInt32(tbAddID.Text);
            currItem = Item.GetSingleItem(searchid);
            int searchedID = currItem.SearchForID(searchid);


            int id = Convert.ToInt32(tbAddID.Text);
            string name = tbAddName.Text;
            string description = tbAddDescription.Text;
            decimal cost = Convert.ToDecimal(tbAddCost.Text);
            DateTime dateAcquired = Convert.ToDateTime(tbAddDateAcquired.Text);
            int quantity = Convert.ToInt32(tbAddQuantity.Text) + currItem.Quantity;

            if (searchedID > 0)
            {
                currItem.Change(id, name, description, cost, dateAcquired, quantity);
            }
            else
            {
                currItem = Item.Insert(id, name, description, cost, dateAcquired, quantity);
            }
            Clear();
        }

        private void buttonDoneAdding_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            tbAddID.Clear();
            tbAddName.Clear();
            tbAddDescription.Clear();
            tbAddCost.Clear();
            tbAddDateAcquired.Clear();
            tbAddQuantity.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = tbAddName.Text;
            List<Item> searchitems = Item.GetItemByName(name);
            LVSearch.Items.Clear();
            foreach(Item i in searchitems)
            {
                ListViewItem searchitem = new ListViewItem(new string[] { i.ID.ToString(), i.Name, i.Description, i.Cost.ToString(), i.DateAcquired.ToString("MM/dd/yyyy"), i.Quantity.ToString() });
                searchitem.Tag = i;
                LVSearch.Items.Add(searchitem);
            }
        }

        private void LVSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LVSearch.SelectedItems.Count > 0)
            {
                ListViewItem selection = LVSearch.SelectedItems[0];
                currItem = (Item)selection.Tag;
                tbAddID.Text = currItem.ID.ToString();
                tbAddName.Text = currItem.Name;
                tbAddDescription.Text = currItem.Description;
                tbAddCost.Text = currItem.Cost.ToString();
                tbAddDateAcquired.Text = currItem.DateAcquired.ToString();

            }
        }
    }
}
