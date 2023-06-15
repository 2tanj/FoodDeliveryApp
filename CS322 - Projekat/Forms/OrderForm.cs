using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322___Projekat.Forms
{
    public partial class OrderForm : Form
    {
        public static Restorant SelectedRestorant;
        public static List<FoodItem> PickedItems;

        public OrderForm()
        {
            SelectedRestorant = MenuForm.SelectedRestorant;
            PickedItems = Gui.MenuGUI.SelectedItems;

            InitializeComponent();

            if(PickedItems.Count < 2)
                lblProducts.Text = PickedItems.Count.ToString() + " product from ";
            else
                lblProducts.Text = PickedItems.Count.ToString() + " products from ";

            lblRestorant.Text = SelectedRestorant.Name;

            lblPrice.Text = "Total price: " + FoodItem.GetTotalPrice(PickedItems).ToString() + "din";
            lblPriceTax.Text = "Price after tax: " + (FoodItem.GetTotalPrice(PickedItems) * 1.4).ToString() + "din";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // extending form height to be in order with the amout of ordered items
            this.Height += 42 * PickedItems.Count;

            // moving all the controls that are on the bottom of the form down to be in order with the amout of ordered items
            pnlBottom.Location = new Point(pnlBottom.Location.X, this.Height - pnlBottom.Height);
            pnlLeft.Location = new Point(pnlLeft.Location.X, this.Height - pnlBottom.Height - 73);
            pnlRight.Location = new Point(pnlRight.Location.X, this.Height - pnlBottom.Height - 73);

            // drawing all the ordered items
            for (int i = 0; i < PickedItems.Count; i++)
            {
                _ = new Gui.OrderItemsGUI(PickedItems[i], this, lblProducts, lblPrice, lblPriceTax);
            }
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // reseting starting height when form is closed so everything can work as indended when opened again
            Gui.OrderItemsGUI._HEIGHT = 74;
        }

        //ORDERING FUNCTIONALITY
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string message;
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Order order = new Order(null, Globals.USER.UserId, SelectedRestorant.Name, FoodItem.GetTotalPrice(PickedItems), time);

            //if cart is empty throw error
            if (PickedItems.Count < 1)
            {
                msgError.Show();
                this.Close();
                return;
            }

            if(PickedItems.Count < 2)
                message = "You ordered one product!";
            else            
                message = "You ordered " + PickedItems.Count.ToString() + " products!";

            if (mailReceipt.Checked)
                message += "\nAn email receipt was sent to:\n" + Globals.USER.Email;

            if (payMethod.Checked)
                message += "\n\nPayment method: CARD";
            else
                message += "\n\nPayment method: CASH";

            Database.AddOrder(order);
            msgSuccsses.Show(message);

            //PickedItems.Clear();
            //Globals.MENU_FORM.Size = new Size(366, 499);
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //MAIL SENDING RESOURCES
        //https://github.com/jstedfast/MailKit
        //https://www.sendinblue.com/pricing/
    }
}
