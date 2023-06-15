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
    public partial class OrderHistoryForm : Form
    {
        List<Order> Orders = new List<Order>();

        public OrderHistoryForm()
        {
            Database.LoadOrders(ref Orders, Globals.USER);

            InitializeComponent();

            // drawing all orders
            for (int i = 0; i < Orders.Count; i++)
                _ = new Gui.HistoryGUI(this, Orders[i]);
            
        }

        // reseting starting height when form is closed so everything can work as indended when opened again
        private void OrderHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gui.HistoryGUI._HEIGHT = 49;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
