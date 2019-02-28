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
    public partial class Update : Form
    {
        private Item currItem;

        public Update(Item item)
        {
            InitializeComponent();
            Item UpdateItem = item;
            tbUpdateID.Text = UpdateItem.ID.ToString();
            tbUpdateName.Text = UpdateItem.Name;
            tbUpdateDescription.Text = UpdateItem.Description;
            tbUpdateCost.Text = UpdateItem.Cost.ToString();
            tbUpdateDateAcquired.Text = UpdateItem.DateAcquired.ToString("MM/dd/yyyy");
            tbUpdateQuantity.Text = UpdateItem.Quantity.ToString();
        }

        

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbUpdateID.Text);
            string name = tbUpdateName.Text;
            string description = tbUpdateDescription.Text;
            decimal cost = Convert.ToDecimal(tbUpdateCost.Text);
            DateTime dateAcquired = Convert.ToDateTime(tbUpdateDateAcquired.Text);
            int quantity = Convert.ToInt32(tbUpdateQuantity.Text);

            currItem = new Item();
            currItem.Change(id, name, description, cost, dateAcquired, quantity);
            this.Close();
        }

        public void Clear()
        {
            tbUpdateID.Clear();
            tbUpdateName.Clear();
            tbUpdateDescription.Clear();
            tbUpdateCost.Clear();
            tbUpdateDateAcquired.Clear();
            tbUpdateQuantity.Clear();
        }
    }
}
